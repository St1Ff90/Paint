namespace Paint
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblUsedMods = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TrackBar();
            this.lblWidth = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bntThistle = new System.Windows.Forms.Button();
            this.bntLime = new System.Windows.Forms.Button();
            this.bntMoccassin = new System.Windows.Forms.Button();
            this.bntTan = new System.Windows.Forms.Button();
            this.bntSilver = new System.Windows.Forms.Button();
            this.bntGray = new System.Windows.Forms.Button();
            this.bntBlack = new System.Windows.Forms.Button();
            this.bntWhite = new System.Windows.Forms.Button();
            this.bntGreen = new System.Windows.Forms.Button();
            this.bntBlue = new System.Windows.Forms.Button();
            this.bntRed = new System.Windows.Forms.Button();
            this.bntYellow = new System.Windows.Forms.Button();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tssb = new System.Windows.Forms.ToolStripSplitButton();
            this.створитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиМодульToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиЯкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbUnDo = new System.Windows.Forms.ToolStripButton();
            this.tsbReDo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).BeginInit();
            this.panel2.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbMain
            // 
            this.pbMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMain.Location = new System.Drawing.Point(0, 25);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(627, 425);
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            this.pbMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pbMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pbMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.tbWidth);
            this.panel1.Controls.Add(this.lblWidth);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(627, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 425);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblUsedMods);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 305);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 120);
            this.panel3.TabIndex = 3;
            // 
            // lblUsedMods
            // 
            this.lblUsedMods.AutoSize = true;
            this.lblUsedMods.Location = new System.Drawing.Point(5, 7);
            this.lblUsedMods.Name = "lblUsedMods";
            this.lblUsedMods.Size = new System.Drawing.Size(106, 15);
            this.lblUsedMods.TabIndex = 0;
            this.lblUsedMods.Text = "Підключені моди:";
            // 
            // tbWidth
            // 
            this.tbWidth.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbWidth.Location = new System.Drawing.Point(0, 143);
            this.tbWidth.Minimum = 1;
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(173, 45);
            this.tbWidth.TabIndex = 0;
            this.tbWidth.Value = 1;
            this.tbWidth.Scroll += new System.EventHandler(this.tbWidth_Scroll);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWidth.Location = new System.Drawing.Point(0, 128);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(57, 15);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Товшина";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bntThistle);
            this.panel2.Controls.Add(this.bntLime);
            this.panel2.Controls.Add(this.bntMoccassin);
            this.panel2.Controls.Add(this.bntTan);
            this.panel2.Controls.Add(this.bntSilver);
            this.panel2.Controls.Add(this.bntGray);
            this.panel2.Controls.Add(this.bntBlack);
            this.panel2.Controls.Add(this.bntWhite);
            this.panel2.Controls.Add(this.bntGreen);
            this.panel2.Controls.Add(this.bntBlue);
            this.panel2.Controls.Add(this.bntRed);
            this.panel2.Controls.Add(this.bntYellow);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 128);
            this.panel2.TabIndex = 1;
            // 
            // bntThistle
            // 
            this.bntThistle.BackColor = System.Drawing.Color.Thistle;
            this.bntThistle.Location = new System.Drawing.Point(129, 81);
            this.bntThistle.Name = "bntThistle";
            this.bntThistle.Size = new System.Drawing.Size(35, 33);
            this.bntThistle.TabIndex = 11;
            this.bntThistle.UseVisualStyleBackColor = false;
            this.bntThistle.Click += new System.EventHandler(this.bntThistle_Click);
            // 
            // bntLime
            // 
            this.bntLime.BackColor = System.Drawing.Color.Lime;
            this.bntLime.Location = new System.Drawing.Point(88, 81);
            this.bntLime.Name = "bntLime";
            this.bntLime.Size = new System.Drawing.Size(35, 33);
            this.bntLime.TabIndex = 10;
            this.bntLime.UseVisualStyleBackColor = false;
            this.bntLime.Click += new System.EventHandler(this.bntLime_Click);
            // 
            // bntMoccassin
            // 
            this.bntMoccassin.BackColor = System.Drawing.Color.Moccasin;
            this.bntMoccassin.Location = new System.Drawing.Point(47, 81);
            this.bntMoccassin.Name = "bntMoccassin";
            this.bntMoccassin.Size = new System.Drawing.Size(35, 33);
            this.bntMoccassin.TabIndex = 9;
            this.bntMoccassin.UseVisualStyleBackColor = false;
            this.bntMoccassin.Click += new System.EventHandler(this.bntMoccassin_Click);
            // 
            // bntTan
            // 
            this.bntTan.BackColor = System.Drawing.Color.Tan;
            this.bntTan.Location = new System.Drawing.Point(6, 81);
            this.bntTan.Name = "bntTan";
            this.bntTan.Size = new System.Drawing.Size(35, 33);
            this.bntTan.TabIndex = 8;
            this.bntTan.UseVisualStyleBackColor = false;
            this.bntTan.Click += new System.EventHandler(this.bntTan_Click);
            // 
            // bntSilver
            // 
            this.bntSilver.BackColor = System.Drawing.Color.Silver;
            this.bntSilver.Location = new System.Drawing.Point(88, 42);
            this.bntSilver.Name = "bntSilver";
            this.bntSilver.Size = new System.Drawing.Size(35, 33);
            this.bntSilver.TabIndex = 7;
            this.bntSilver.UseVisualStyleBackColor = false;
            this.bntSilver.Click += new System.EventHandler(this.bntSilver_Click);
            // 
            // bntGray
            // 
            this.bntGray.BackColor = System.Drawing.Color.Gray;
            this.bntGray.Location = new System.Drawing.Point(47, 42);
            this.bntGray.Name = "bntGray";
            this.bntGray.Size = new System.Drawing.Size(35, 33);
            this.bntGray.TabIndex = 6;
            this.bntGray.UseVisualStyleBackColor = false;
            this.bntGray.Click += new System.EventHandler(this.bntGray_Click);
            // 
            // bntBlack
            // 
            this.bntBlack.BackColor = System.Drawing.Color.Black;
            this.bntBlack.Location = new System.Drawing.Point(6, 42);
            this.bntBlack.Name = "bntBlack";
            this.bntBlack.Size = new System.Drawing.Size(35, 33);
            this.bntBlack.TabIndex = 5;
            this.bntBlack.UseVisualStyleBackColor = false;
            this.bntBlack.Click += new System.EventHandler(this.bntBlack_Click);
            // 
            // bntWhite
            // 
            this.bntWhite.BackColor = System.Drawing.Color.White;
            this.bntWhite.Location = new System.Drawing.Point(129, 42);
            this.bntWhite.Name = "bntWhite";
            this.bntWhite.Size = new System.Drawing.Size(35, 33);
            this.bntWhite.TabIndex = 4;
            this.bntWhite.UseVisualStyleBackColor = false;
            this.bntWhite.Click += new System.EventHandler(this.bntWhite_Click);
            // 
            // bntGreen
            // 
            this.bntGreen.BackColor = System.Drawing.Color.Green;
            this.bntGreen.Location = new System.Drawing.Point(129, 3);
            this.bntGreen.Name = "bntGreen";
            this.bntGreen.Size = new System.Drawing.Size(35, 33);
            this.bntGreen.TabIndex = 3;
            this.bntGreen.UseVisualStyleBackColor = false;
            this.bntGreen.Click += new System.EventHandler(this.bntGreen_Click);
            // 
            // bntBlue
            // 
            this.bntBlue.BackColor = System.Drawing.Color.Blue;
            this.bntBlue.Location = new System.Drawing.Point(88, 3);
            this.bntBlue.Name = "bntBlue";
            this.bntBlue.Size = new System.Drawing.Size(35, 33);
            this.bntBlue.TabIndex = 2;
            this.bntBlue.UseVisualStyleBackColor = false;
            this.bntBlue.Click += new System.EventHandler(this.bntBlue_Click);
            // 
            // bntRed
            // 
            this.bntRed.BackColor = System.Drawing.Color.Red;
            this.bntRed.Location = new System.Drawing.Point(47, 3);
            this.bntRed.Name = "bntRed";
            this.bntRed.Size = new System.Drawing.Size(35, 33);
            this.bntRed.TabIndex = 1;
            this.bntRed.UseVisualStyleBackColor = false;
            this.bntRed.Click += new System.EventHandler(this.bntRed_Click);
            // 
            // bntYellow
            // 
            this.bntYellow.BackColor = System.Drawing.Color.Yellow;
            this.bntYellow.Location = new System.Drawing.Point(6, 3);
            this.bntYellow.Name = "bntYellow";
            this.bntYellow.Size = new System.Drawing.Size(35, 33);
            this.bntYellow.TabIndex = 0;
            this.bntYellow.UseVisualStyleBackColor = false;
            this.bntYellow.Click += new System.EventHandler(this.bntYellow_Click);
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssb,
            this.toolStripSeparator3,
            this.tsbSave,
            this.toolStripSeparator2,
            this.tsbUnDo,
            this.tsbReDo,
            this.toolStripSeparator1});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(800, 25);
            this.tsMain.TabIndex = 2;
            this.tsMain.Text = "tsMain";
            // 
            // tssb
            // 
            this.tssb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tssb.DoubleClickEnabled = true;
            this.tssb.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.створитиToolStripMenuItem,
            this.додатиМодульToolStripMenuItem,
            this.відкритиToolStripMenuItem,
            this.зберегтиToolStripMenuItem,
            this.зберегтиЯкToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.tssb.Image = ((System.Drawing.Image)(resources.GetObject("tssb.Image")));
            this.tssb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssb.Name = "tssb";
            this.tssb.Size = new System.Drawing.Size(57, 22);
            this.tssb.Text = "Меню";
            this.tssb.ButtonClick += new System.EventHandler(this.tssb_ButtonClick);
            // 
            // створитиToolStripMenuItem
            // 
            this.створитиToolStripMenuItem.Name = "створитиToolStripMenuItem";
            this.створитиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.створитиToolStripMenuItem.Text = "Створити";
            this.створитиToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // додатиМодульToolStripMenuItem
            // 
            this.додатиМодульToolStripMenuItem.Name = "додатиМодульToolStripMenuItem";
            this.додатиМодульToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.додатиМодульToolStripMenuItem.Text = "Додати модуль";
            this.додатиМодульToolStripMenuItem.Click += new System.EventHandler(this.addModuleToolStripMenuItem_Click);
            // 
            // відкритиToolStripMenuItem
            // 
            this.відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            this.відкритиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.відкритиToolStripMenuItem.Text = "Відкрити";
            this.відкритиToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.зберегтиToolStripMenuItem.Text = "Зберегти";
            this.зберегтиToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // зберегтиЯкToolStripMenuItem
            // 
            this.зберегтиЯкToolStripMenuItem.Name = "зберегтиЯкToolStripMenuItem";
            this.зберегтиЯкToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.зберегтиЯкToolStripMenuItem.Text = "Зберегти як..";
            this.зберегтиЯкToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вихідToolStripMenuItem.Text = "Вихід";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "Зберегти";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbUnDo
            // 
            this.tsbUnDo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUnDo.Image = ((System.Drawing.Image)(resources.GetObject("tsbUnDo.Image")));
            this.tsbUnDo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUnDo.Name = "tsbUnDo";
            this.tsbUnDo.Size = new System.Drawing.Size(23, 22);
            this.tsbUnDo.Text = "Назад";
            this.tsbUnDo.Click += new System.EventHandler(this.tsbUnDo_Click);
            // 
            // tsbReDo
            // 
            this.tsbReDo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReDo.Image = ((System.Drawing.Image)(resources.GetObject("tsbReDo.Image")));
            this.tsbReDo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReDo.Name = "tsbReDo";
            this.tsbReDo.Size = new System.Drawing.Size(23, 22);
            this.tsbReDo.Text = "Вперед";
            this.tsbReDo.Click += new System.EventHandler(this.tsbReDo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tsMain);
            this.MinimumSize = new System.Drawing.Size(816, 459);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbMain;
        private Panel panel1;
        private ToolStrip tsMain;
        private ToolStripButton tsbSave;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSplitButton tssb;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem створитиToolStripMenuItem;
        private ToolStripMenuItem відкритиToolStripMenuItem;
        private ToolStripMenuItem зберегтиToolStripMenuItem;
        private ToolStripMenuItem зберегтиЯкToolStripMenuItem;
        private ToolStripMenuItem вихідToolStripMenuItem;
        private ToolStripButton tsbUnDo;
        private ToolStripButton tsbReDo;
        private ToolStripMenuItem додатиМодульToolStripMenuItem;
        private TrackBar tbWidth;
        private Panel panel2;
        private Button bntThistle;
        private Button bntLime;
        private Button bntMoccassin;
        private Button bntTan;
        private Button bntSilver;
        private Button bntGray;
        private Button bntBlack;
        private Button bntWhite;
        private Button bntGreen;
        private Button bntBlue;
        private Button bntRed;
        private Button bntYellow;
        private Label lblWidth;
        private Panel panel3;
        private Label lblUsedMods;
    }
}