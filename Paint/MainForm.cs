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
        Bitmap _temp;
        private Pen pen;
        //XmlSerializer serializer = new XmlSerializer(typeof(List<IPaintable>));
        private string _currentFile;

        private Action<Graphics, Pen, int, int> Draw;
        private Action<int, int> AddPoint;
        private Action DisposeItem;
        private string _currentTool;

        private UniObj _obj;
        private List<UniObj> _currentHistory = new List<UniObj>();
        private List<UniObj> _redoList = new List<UniObj>();

        public MainForm()
        {
            InitializeComponent();
            pbMain.Image = new Bitmap(pbMain.Width, pbMain.Height);
            _temp = (Bitmap)pbMain.Image.Clone();
        }
        #region Private Methods
        private void GetPen()
        {
            pen = new Pen(Color.Red, 3);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
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

        private void SaveFile(string neededFileTypes)
        {
            saveFileDialog.Filter = neededFileTypes;

            if (string.IsNullOrEmpty(_currentFile))
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                    {
                        fs.SetLength(0);
                        //serializer.Serialize(fs, _history);
                        _currentFile = saveFileDialog.FileName;
                        this.Text = _currentFile;
                    }
                }
            }
            else
            {
                using (FileStream fs = new FileStream(_currentFile, FileMode.OpenOrCreate))
                {
                    //serializer.Serialize(fs, _history);
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
                            fs.SetLength(0);
                            //serializer.Serialize(fs, _history);
                            _currentFile = saveFileDialog.FileName;
                            saveFileDialog.Reset();
                            this.Text = _currentFile;
                            break;
                        default:
                            break;
                    }
                }
            }
        }


        private void GenerateButton(Type type)
        {
            if (type.GetInterface(typeof(IPaintable).FullName) == null)
            {
                throw new ArgumentException();
            }

            var obj = Activator.CreateInstance(type);



            var toolName = GetPropertyFromType<string>(type, nameof(IPaintable.ToolTitle), obj);
            var icon = GetPropertyFromType<Bitmap>(type, nameof(IPaintable.Icon), obj);
            var onClickMethodDraw = type.GetMethod(nameof(IPaintable.Draw), BindingFlags.Public | BindingFlags.Instance);
            var actionDraw = (Action<Graphics, Pen, int, int>)Delegate.CreateDelegate(typeof(Action<Graphics, Pen, int, int>), obj, onClickMethodDraw);
            var onClickMethodAddPoint = type.GetMethod(nameof(IPaintable.AddPoint), BindingFlags.Public | BindingFlags.Instance);
            var actionAddPoint = (Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), obj, onClickMethodAddPoint);
            var onClickMethodADispose = type.GetMethod(nameof(IPaintable.ClearObj), BindingFlags.Public | BindingFlags.Instance);
            var actionDispose = (Action)Delegate.CreateDelegate(typeof(Action), obj, onClickMethodADispose);


            var onClick = new EventHandler((x, y) =>
            {
                _currentTool = toolName;
                Draw = actionDraw;
                AddPoint = actionAddPoint;
                DisposeItem = actionDispose;
                _obj = new UniObj()
                {
                    Title = toolName,
                    Draw = actionDraw,
                    AddPoint = actionAddPoint,
                    DisposeItem = actionDispose
                };

            });

            ToolStripButton toolStripButton = new ToolStripButton(toolName, icon, onClick, toolName);
            toolStripButton.Click += ToolStripButton_Click;
            tsMain.Items.Add(toolStripButton);
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

        private void LoadFile(string neededFileTypes)
        {
            openFileDialog.Filter = neededFileTypes;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(String.Format(openFileDialog.FileName), FileMode.OpenOrCreate))
                {
                    //_history = serializer.Deserialize(fs) as List<BaseTool>;
                }
                _currentFile = openFileDialog.FileName;
                using (var bitmap = new Bitmap(pbMain.Width, pbMain.Height))
                using (var graphics = Graphics.FromImage(bitmap))
                {
                    GetPen();
                    //foreach (var bs in _history)
                    //{
                    //    bs.Draw(graphics, pen);
                    //    pbMain.Image = (Bitmap)bitmap.Clone();

                    //}
                }
                _temp = (Bitmap)pbMain.Image.Clone();
                this.Text = _currentFile;
                openFileDialog.Reset();
            }
        }

        #endregion

        #region PictureBox Buttons
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (_obj == null) return;
            _isClicked = false;
            _temp = (Bitmap)pbMain.Image.Clone();
            _obj.end = e.Location;
            _currentHistory.Add(_obj.DeepCopy());
            _obj.DisposeItem();
            //DisposeItem?.Invoke();

            if (_currentTool is not null)
            {
                UniObj uni = new UniObj();
                uni = _obj;
            }

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_obj == null) return;
            _isClicked = true;
            _obj.AddPoint(e.X, e.Y);
            _obj.start = e.Location;
            _redoList = new List<UniObj>();
            //AddPoint?.Invoke(e.Location.X, e.Location.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isClicked)
            {
                using (var bitmap = new Bitmap(_temp, pbMain.Width, pbMain.Height))
                using (var graphics = Graphics.FromImage(bitmap))
                {
                    GetPen();
                    //Draw?.Invoke(graphics, pen, e.Location.X, e.Location.Y);
                    _obj.Draw(graphics, pen, e.Location.X, e.Location.Y);
                    pbMain.Image?.Dispose();
                    pbMain.Image = (Bitmap)bitmap.Clone();
                }
            }
        }
        #endregion

        #region Menu Buttons
        private void addModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Dll files(*.dll) | *.dll";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var assembly = Assembly.LoadFrom(openFileDialog.FileName);
                var types = assembly
                    .GetTypes()
                    .Where(x =>
                        x.GetInterface(typeof(IPaintable).FullName) != null);

                foreach (var type in types)
                {
                    GenerateButton(type);
                }

                openFileDialog.Reset();
            }
        }

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
            using (var bitmap = new Bitmap(pbMain.Width, pbMain.Height))
            using (var graphics = Graphics.FromImage(bitmap))
            {
                GetPen();
                for (int i = 0; i < _currentHistory.Count; i++)
                {
                    _currentHistory[i].AddPoint(_currentHistory[i].start.X, _currentHistory[i].start.Y);
                    _currentHistory[i].Draw(graphics, pen, _currentHistory[i].end.X, _currentHistory[i].end.Y);
                }
                pbMain.Image?.Dispose();
                pbMain.Image = (Bitmap)bitmap.Clone();
                _temp = (Bitmap)pbMain.Image.Clone();
            }
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
            //currentFile = "";
            //this.Text = "untitled";
            //saveFileDialog.Reset();
            //if (_history.Count != 0)
            //{
            //    DialogResult dialog = MessageBox.Show(
            //        "Збереги в файл?",
            //        "Зберегти зміни?",
            //        MessageBoxButtons.YesNo,
            //        MessageBoxIcon.Warning
            //    );
            //    if (dialog == DialogResult.Yes)
            //    {
            //        SaveFile("xml files(*.xml) | *.xml");
            //    }

            //    _history.Clear();
            //    _temp = new Bitmap(pbMain.Width, pbMain.Height);
            //    pbMain.Image = _temp;
            //    HilightMenuItem();
            //}
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFile("Dump file (*.xml)|*.xml|Image (*.bmp)|*.bmp");
        }

        private void tssb_ButtonClick(object sender, EventArgs e)
        {
            tssb.ShowDropDown();
        }

        #endregion

    }
}
