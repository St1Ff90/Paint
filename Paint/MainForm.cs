using ModderPack;
using Paint;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.ToolStripItem;

namespace Paint
{
    public partial class MainForm : Form
    {
        private bool _isClicked;
        private string _currentTool;
        private string _currentFile;
        private int _maxPointsCount;
        private Pen pen;
        private Brush brush;
        private Bitmap _temp;
        private bool isFilled;
        private int borderWidth;

        private Action<Graphics, Pen, int, int> Draw;
        private Action<Graphics, Brush, int, int, int> Fill;
        private Action<int, int> Start;
        private Action DisposeItem;
        private List<Figure> _currentHistory = new List<Figure>();
        private List<Figure> _redoList = new List<Figure>();



        private Figure _figure;
        private static string pathToModsList = @"ToolsDllPath.xml";

        public MainForm()
        {
            InitializeComponent();
            pbMain.Image = new Bitmap(pbMain.Width, pbMain.Height);
            _temp = (Bitmap)pbMain.Image.Clone();
            GetPen();
        }

        #region Save/Load
        private void SaveFile(string neededFileTypes)
        {
            saveFileDialog.Filter = neededFileTypes;

            if (string.IsNullOrEmpty(_currentFile))
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                    {
                        SaveFileToXML(fs);
                    }
                }
            }
            else
            {
                using (FileStream fs = new FileStream(_currentFile, FileMode.OpenOrCreate))
                {
                    SaveFileToXML(fs);
                }
            }
            saveFileDialog.Reset();
        }

        private void SaveAsFile(string neededFileTypes)
        {
            saveFileDialog.Filter = neededFileTypes;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    switch (Path.GetExtension(saveFileDialog.FileName))
                    {
                        case ".bmp":
                            using (MemoryStream memory = new MemoryStream())
                            using (var bitmap = new Bitmap(pbMain.Width, pbMain.Height))
                            using (var graphics = Graphics.FromImage(bitmap))
                            {
                                graphics.Clear(Color.White);
                                graphics.DrawImage(_temp, 0, 0, _temp.Width, _temp.Height);
                                bitmap.Save(memory, ImageFormat.Bmp);
                                byte[] bytes = memory.ToArray();
                                fs.Write(bytes, 0, bytes.Length);
                            }
                            break;
                        case ".xml":
                            SaveFileToXML(fs);
                            saveFileDialog.Reset();
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void SaveFileToXML(FileStream fs)
        {
            fs.SetLength(0);
            XmlSerializer serializerFigure = new XmlSerializer(typeof(List<Figure>));
            serializerFigure.Serialize(fs, _currentHistory);
            _currentFile = saveFileDialog.FileName;
            this.Text = _currentFile;
        }

        private void LoadFile(string neededFileTypes)
        {
            openFileDialog.Filter = neededFileTypes;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(String.Format(openFileDialog.FileName), FileMode.OpenOrCreate))
                {
                    XmlSerializer serializerFigure = new XmlSerializer(typeof(List<Figure>));
                    _currentHistory = (List<Figure>)serializerFigure.Deserialize(fs);
                }
                _currentFile = openFileDialog.FileName;
                DrawFromHyistory();
                openFileDialog.Reset();
            }
        }

        #endregion

        #region ModulesManager
        private void addModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Dll files(*.dll) | *.dll";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadModulesFromFile(openFileDialog.FileName);
                List<ModPath> modPaths = new List<ModPath>();
                SaveModulesToXML(modPaths);
                openFileDialog.Reset();
            }
        }

        private List<ModPath> LoadModulesFromFile(string path)
        {
            var assembly = Assembly.LoadFrom(path);
            var types = assembly
                .GetTypes()
                .Where(x =>
                    x.GetInterface(typeof(IPaintable).FullName) != null);

            List<ModPath> modPaths = new List<ModPath>();

            foreach (var type in types)
            {
                GenerateDelegate(type);
                modPaths.Add(new ModPath { Name = type.Name, Path = openFileDialog.FileName });
            }

            return modPaths;
        }

        private void GenerateDelegate(Type type)
        {
            if (type.GetInterface(typeof(IPaintable).FullName) == null)
            {
                throw new ArgumentException();
            }

            var obj = Activator.CreateInstance(type);
            var toolName = GetPropertyFromType<string>(type, nameof(IPaintable.ToolTitle), obj);
            var maxPoints = GetPropertyFromType<int>(type, nameof(IPaintable.needPointsToDraw), obj);
            var icon = GetPropertyFromType<Bitmap>(type, nameof(IPaintable.Icon), obj);
            var onClickMethodDraw = type.GetMethod(nameof(IPaintable.Draw), BindingFlags.Public | BindingFlags.Instance);
            var actionDraw = (Action<Graphics, Pen, int, int>)Delegate.CreateDelegate(typeof(Action<Graphics, Pen, int, int>), obj, onClickMethodDraw);
            var onClickMethodFill = type.GetMethod(nameof(IPaintable.Fill), BindingFlags.Public | BindingFlags.Instance);
            var actionFill = (Action<Graphics, Brush, int, int, int>)Delegate.CreateDelegate(typeof(Action<Graphics, Brush, int, int, int>), obj, onClickMethodFill);
            var onClickMethodStart = type.GetMethod(nameof(IPaintable.Start), BindingFlags.Public | BindingFlags.Instance);
            var actionAddPoint = (Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), obj, onClickMethodStart);
            var onClickMethodADispose = type.GetMethod(nameof(IPaintable.ClearObj), BindingFlags.Public | BindingFlags.Instance);
            var actionDispose = (Action)Delegate.CreateDelegate(typeof(Action), obj, onClickMethodADispose);

            if (tsMain.Items.Find(toolName, false).Count() == 0)
            {
                lblUsedMods.Text += Environment.NewLine + obj.GetType().Name;

                var onClick = new EventHandler((x, y) =>
                {
                    _currentTool = toolName;
                    Draw = actionDraw;
                    Fill = actionFill;
                    Start = actionAddPoint;
                    DisposeItem = actionDispose;
                    _maxPointsCount = maxPoints;
                });

                ToolStripButton toolStripButton = new ToolStripButton(toolName, icon, onClick, toolName);
                toolStripButton.Click += ToolStripButton_Click;
                tsMain.Items.Add(toolStripButton);
            }
        }

        private T GetPropertyFromType<T>(Type type, string propertyTitle, object instance)
        {
            var property = type
              .GetProperty(
                  propertyTitle,
                  BindingFlags.Public | BindingFlags.Instance);

            var propertyValue = property.GetValue(instance);

            return (T)propertyValue;
        }

        private static void SaveModulesToXML(List<ModPath> modPaths)
        {
            if (modPaths.Count > 0) // тут дописывать а не перетерать
            {
                XmlSerializer serializerPath = new XmlSerializer(typeof(List<ModPath>));
                using (FileStream fs = new FileStream(pathToModsList, FileMode.OpenOrCreate))
                {
                    fs.SetLength(0);
                    serializerPath.Serialize(fs, modPaths);
                }
            }
        }

        #endregion

        #region Service Methods

        private void GetPen()
        {
            int width = 3;
            pen = new Pen(Color.Black, width);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            lblWidth.Text = "Товшина " + width + " px";
            tbWidth.Value = width;
            bntBlack.Select();
        }

        private void HilightMenuItem()
        {
            foreach (ToolStripItem item in tsMain.Items)
            {
                item.BackColor = SystemColors.Control;
                if (item.Name == _currentTool)
                {
                    item.BackColor = SystemColors.ActiveCaption;
                }
            }
        }
        #endregion

        #region PictureBox Buttons
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (_currentTool == null) return;
            _isClicked = false;
            _currentHistory.Add(_figure.DeepCopy());
            _redoList = new List<Figure>();
            _temp = (Bitmap)pbMain.Image.Clone();
            DisposeItem?.Invoke();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_currentTool == null) return;
            _isClicked = true;
            _figure = new Figure();
            _figure.ToolTitle = _currentTool;
            _figure.Color = pen.Color;
            _figure.LineWidth = (int)pen.Width;
            _figure.Points.Add(e.Location);
            Start?.Invoke(e.Location.X, e.Location.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isClicked)
            {
                using (var bitmap = new Bitmap(_temp, pbMain.Width, pbMain.Height))
                using (var graphics = Graphics.FromImage(bitmap))
                {
                    if (_figure.Points.Count == _maxPointsCount)
                    {
                        _figure.Points[_maxPointsCount - 1] = new Point(e.Location.X, e.Location.Y);
                    }
                    else
                    {
                        _figure.Points.Add(e.Location);
                    }

                    Draw?.Invoke(graphics, pen, e.Location.X, e.Location.Y);
                    if(isFilled)
                    {
                        Fill?.Invoke(graphics, brush, e.Location.X, e.Location.Y, borderWidth);
                    }
                    pbMain.Image?.Dispose();
                    pbMain.Image = (Bitmap)bitmap.Clone();
                }
            }
        }
        #endregion

        #region Menu Buttons
        private void ToolStripButton_Click(object? sender, EventArgs e)
        {
            HilightMenuItem();
        }

        private void tsbUnDo_Click(object sender, EventArgs e)
        {
            if (_currentHistory.Count == 0)
            {
                return;
            }
            HilightMenuItem();
            _redoList.Add(_currentHistory[_currentHistory.Count - 1]);
            _currentHistory.RemoveAt(_currentHistory.Count - 1);
            DrawFromHyistory();
        }

        private void tsbReDo_Click(object sender, EventArgs e)
        {
            if (_redoList.Count == 0)
            {
                return;
            }
            HilightMenuItem();
            _currentHistory.Add(_redoList[_redoList.Count - 1]);
            _redoList.RemoveAt(_redoList.Count - 1);
            DrawFromHyistory();
        }

        private void DrawFromHyistory()
        {
            List<string> Errors = new List<string>();
            using (var bitmap = new Bitmap(pbMain.Width, pbMain.Height))
            using (var graphics = Graphics.FromImage(bitmap))
            {
                foreach (var figure in _currentHistory)
                {
                    var toolStripButtonList = tsMain.Items.Find(figure.ToolTitle, false);

                    if (toolStripButtonList.Count() == 0)
                    {
                        string connectionString = FindMoodConnectionString(figure.ToolTitle);

                        if (connectionString != null)
                        {
                            LoadModulesFromFile(connectionString);
                            toolStripButtonList = tsMain.Items.Find(figure.ToolTitle, false);
                        }
                        else
                        {
                            Errors.Add(figure.ToolTitle);
                        }
                    }

                    if (toolStripButtonList.Count() != 0)
                    {
                        ToolStripItem toolStripButton = toolStripButtonList.First();
                        pen = new Pen(figure.Color, figure.LineWidth);
                        toolStripButton.PerformClick();

                        for (int i = 0; i < figure.Points.Count - 1; i++)
                        {
                            Start?.Invoke(figure.Points[i].X, figure.Points[i].Y);
                            Draw?.Invoke(graphics, pen, figure.Points[i + 1].X, figure.Points[i + 1].Y);
                        }
                        DisposeItem?.Invoke();
                        pbMain.Image = (Bitmap)bitmap.Clone();
                    }
                }
            }
            _temp = (Bitmap)pbMain.Image.Clone();
            this.Text = _currentFile;

            if (Errors.Count > 0)
            {
                MessageBox.Show("Відсутні наступні модулі: " + Environment.NewLine + String.Join(Environment.NewLine, Errors));
            }
        }

        private string? FindMoodConnectionString(string modeName)
        {
            List<ModPath>? list = new List<ModPath>();

            if (File.Exists(pathToModsList))
            {
                using (FileStream fs = new FileStream(pathToModsList, FileMode.OpenOrCreate))
                {
                    XmlSerializer serializerPath = new XmlSerializer(typeof(List<ModPath>));
                    list = (List<ModPath>?)serializerPath.Deserialize(fs);
                }
            }
            ModPath? modPath = list?.Where(x => x.Name == modeName).FirstOrDefault();
            string? result = modPath?.Path;
            return result;
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            SaveFile("Dump files(*.xml) | *.xml");
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile("Dump files(*.xml) | *.xml");
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsFile("Dump file (*.xml)|*.xml|Image (*.bmp)|*.bmp");
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentFile = "";
            this.Text = "untitled";
            saveFileDialog.Reset();
            if (_currentHistory.Count != 0)
            {
                DialogResult dialog = MessageBox.Show(
                    "Збереги в файл?",
                    "Зберегти зміни?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                if (dialog == DialogResult.Yes)
                {
                    SaveFile("xml files(*.xml) | *.xml");
                }

                _currentHistory.Clear();
                pbMain.Image?.Dispose();
                pbMain.Image = new Bitmap(pbMain.Width, pbMain.Height);
                _temp = (Bitmap)pbMain.Image.Clone();

                HilightMenuItem();
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFile("Dump file (*.xml)|*.xml|Image (*.bmp)|*.bmp");
        }

        private void tssb_ButtonClick(object sender, EventArgs e)
        {
            tssb.ShowDropDown();
        }

        private void bntYellow_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
        }

        private void bntRed_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
        }

        private void bntBlue_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
        }

        private void bntGreen_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
        }

        private void bntBlack_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
        }

        private void bntGray_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
        }

        private void bntSilver_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
        }

        private void bntWhite_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
        }

        private void bntTan_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
        }

        private void bntMoccassin_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
        }

        private void bntLime_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
        }

        private void bntThistle_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
        }

        private void tbWidth_Scroll(object sender, EventArgs e)
        {
            borderWidth = ((TrackBar)sender).Value;
            lblWidth.Text = "Товшина " + borderWidth + " px";
            pen.Width = borderWidth;
        }

        private void buttonYellowFill_Click(object sender, EventArgs e)
        {
            brush = new SolidBrush(buttonYellowFill.BackColor);
        }

        private void buttonRedFill_Click(object sender, EventArgs e)
        {
            brush = new SolidBrush(buttonRedFill.BackColor);
        }

        private void buttonBlueFill_Click(object sender, EventArgs e)
        {
            brush = new SolidBrush(buttonBlueFill.BackColor);
        }

        private void buttonGreenFill_Click(object sender, EventArgs e)
        {
            brush = new SolidBrush(buttonGreenFill.BackColor);
        }

        private void buttonBlackFill_Click(object sender, EventArgs e)
        {
            brush = new SolidBrush(buttonBlackFill.BackColor);
        }

        private void buttonGrayFill_Click(object sender, EventArgs e)
        {
            brush = new SolidBrush(buttonGrayFill.BackColor);
        }

        private void buttonMoccasinFill_Click(object sender, EventArgs e)
        {
            brush = new SolidBrush(buttonMoccasinFill.BackColor);
        }

        private void buttonThistleFill_Click(object sender, EventArgs e)
        {
            brush = new SolidBrush(buttonThistleFill.BackColor);
        }

        #endregion

        private void buttonFillOn_Click(object sender, EventArgs e)
        {
            isFilled = true;
        }

        private void buttonFillOff_Click(object sender, EventArgs e)
        {
            isFilled = false;
        }
    }
}
