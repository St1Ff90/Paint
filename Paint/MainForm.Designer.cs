﻿namespace Paint
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
            this.panelFillColours = new System.Windows.Forms.Panel();
            this.buttonThistleFill = new System.Windows.Forms.Button();
            this.buttonMoccasinFill = new System.Windows.Forms.Button();
            this.buttonGrayFill = new System.Windows.Forms.Button();
            this.buttonBlackFill = new System.Windows.Forms.Button();
            this.buttonGreenFill = new System.Windows.Forms.Button();
            this.buttonBlueFill = new System.Windows.Forms.Button();
            this.buttonRedFill = new System.Windows.Forms.Button();
            this.buttonYellowFill = new System.Windows.Forms.Button();
            this.buttonFillOff = new System.Windows.Forms.Button();
            this.buttonFillOn = new System.Windows.Forms.Button();
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
            this.select = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelFillColours.SuspendLayout();
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
            this.pbMain.Location = new System.Drawing.Point(0, 27);
            this.pbMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(716, 573);
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            this.pbMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pbMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pbMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelFillColours);
            this.panel1.Controls.Add(this.buttonFillOff);
            this.panel1.Controls.Add(this.buttonFillOn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.tbWidth);
            this.panel1.Controls.Add(this.lblWidth);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(716, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 573);
            this.panel1.TabIndex = 1;
            // 
            // panelFillColours
            // 
            this.panelFillColours.Controls.Add(this.buttonThistleFill);
            this.panelFillColours.Controls.Add(this.buttonMoccasinFill);
            this.panelFillColours.Controls.Add(this.buttonGrayFill);
            this.panelFillColours.Controls.Add(this.buttonBlackFill);
            this.panelFillColours.Controls.Add(this.buttonGreenFill);
            this.panelFillColours.Controls.Add(this.buttonBlueFill);
            this.panelFillColours.Controls.Add(this.buttonRedFill);
            this.panelFillColours.Controls.Add(this.buttonYellowFill);
            this.panelFillColours.Location = new System.Drawing.Point(0, 301);
            this.panelFillColours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelFillColours.Name = "panelFillColours";
            this.panelFillColours.Size = new System.Drawing.Size(198, 111);
            this.panelFillColours.TabIndex = 6;
            // 
            // buttonThistleFill
            // 
            this.buttonThistleFill.BackColor = System.Drawing.Color.Thistle;
            this.buttonThistleFill.Location = new System.Drawing.Point(147, 56);
            this.buttonThistleFill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonThistleFill.Name = "buttonThistleFill";
            this.buttonThistleFill.Size = new System.Drawing.Size(40, 44);
            this.buttonThistleFill.TabIndex = 12;
            this.buttonThistleFill.UseVisualStyleBackColor = false;
            this.buttonThistleFill.Click += new System.EventHandler(this.buttonThistleFill_Click);
            // 
            // buttonMoccasinFill
            // 
            this.buttonMoccasinFill.BackColor = System.Drawing.Color.Moccasin;
            this.buttonMoccasinFill.Location = new System.Drawing.Point(101, 56);
            this.buttonMoccasinFill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMoccasinFill.Name = "buttonMoccasinFill";
            this.buttonMoccasinFill.Size = new System.Drawing.Size(40, 44);
            this.buttonMoccasinFill.TabIndex = 10;
            this.buttonMoccasinFill.UseVisualStyleBackColor = false;
            this.buttonMoccasinFill.Click += new System.EventHandler(this.buttonMoccasinFill_Click);
            // 
            // buttonGrayFill
            // 
            this.buttonGrayFill.BackColor = System.Drawing.Color.Gray;
            this.buttonGrayFill.Location = new System.Drawing.Point(54, 56);
            this.buttonGrayFill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGrayFill.Name = "buttonGrayFill";
            this.buttonGrayFill.Size = new System.Drawing.Size(40, 44);
            this.buttonGrayFill.TabIndex = 6;
            this.buttonGrayFill.UseVisualStyleBackColor = false;
            this.buttonGrayFill.Click += new System.EventHandler(this.buttonGrayFill_Click);
            // 
            // buttonBlackFill
            // 
            this.buttonBlackFill.BackColor = System.Drawing.Color.Black;
            this.buttonBlackFill.Location = new System.Drawing.Point(7, 56);
            this.buttonBlackFill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBlackFill.Name = "buttonBlackFill";
            this.buttonBlackFill.Size = new System.Drawing.Size(40, 44);
            this.buttonBlackFill.TabIndex = 5;
            this.buttonBlackFill.UseVisualStyleBackColor = false;
            this.buttonBlackFill.Click += new System.EventHandler(this.buttonBlackFill_Click);
            // 
            // buttonGreenFill
            // 
            this.buttonGreenFill.BackColor = System.Drawing.Color.Green;
            this.buttonGreenFill.Location = new System.Drawing.Point(147, 4);
            this.buttonGreenFill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGreenFill.Name = "buttonGreenFill";
            this.buttonGreenFill.Size = new System.Drawing.Size(40, 44);
            this.buttonGreenFill.TabIndex = 3;
            this.buttonGreenFill.UseVisualStyleBackColor = false;
            this.buttonGreenFill.Click += new System.EventHandler(this.buttonGreenFill_Click);
            // 
            // buttonBlueFill
            // 
            this.buttonBlueFill.BackColor = System.Drawing.Color.Blue;
            this.buttonBlueFill.Location = new System.Drawing.Point(101, 4);
            this.buttonBlueFill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBlueFill.Name = "buttonBlueFill";
            this.buttonBlueFill.Size = new System.Drawing.Size(40, 44);
            this.buttonBlueFill.TabIndex = 2;
            this.buttonBlueFill.UseVisualStyleBackColor = false;
            this.buttonBlueFill.Click += new System.EventHandler(this.buttonBlueFill_Click);
            // 
            // buttonRedFill
            // 
            this.buttonRedFill.BackColor = System.Drawing.Color.Red;
            this.buttonRedFill.Location = new System.Drawing.Point(54, 4);
            this.buttonRedFill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRedFill.Name = "buttonRedFill";
            this.buttonRedFill.Size = new System.Drawing.Size(40, 44);
            this.buttonRedFill.TabIndex = 1;
            this.buttonRedFill.UseVisualStyleBackColor = false;
            this.buttonRedFill.Click += new System.EventHandler(this.buttonRedFill_Click);
            // 
            // buttonYellowFill
            // 
            this.buttonYellowFill.BackColor = System.Drawing.Color.Yellow;
            this.buttonYellowFill.Location = new System.Drawing.Point(7, 4);
            this.buttonYellowFill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonYellowFill.Name = "buttonYellowFill";
            this.buttonYellowFill.Size = new System.Drawing.Size(40, 44);
            this.buttonYellowFill.TabIndex = 0;
            this.buttonYellowFill.UseVisualStyleBackColor = false;
            this.buttonYellowFill.Click += new System.EventHandler(this.buttonYellowFill_Click);
            // 
            // buttonFillOff
            // 
            this.buttonFillOff.Location = new System.Drawing.Point(101, 245);
            this.buttonFillOff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFillOff.Name = "buttonFillOff";
            this.buttonFillOff.Size = new System.Drawing.Size(87, 55);
            this.buttonFillOff.TabIndex = 5;
            this.buttonFillOff.Text = "Без заливки";
            this.buttonFillOff.UseVisualStyleBackColor = true;
            this.buttonFillOff.Click += new System.EventHandler(this.buttonFillOff_Click);
            // 
            // buttonFillOn
            // 
            this.buttonFillOn.Location = new System.Drawing.Point(7, 245);
            this.buttonFillOn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFillOn.Name = "buttonFillOn";
            this.buttonFillOn.Size = new System.Drawing.Size(87, 55);
            this.buttonFillOn.TabIndex = 4;
            this.buttonFillOn.Text = "Використати заливку";
            this.buttonFillOn.UseVisualStyleBackColor = true;
            this.buttonFillOn.Click += new System.EventHandler(this.buttonFillOn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblUsedMods);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 413);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 160);
            this.panel3.TabIndex = 3;
            // 
            // lblUsedMods
            // 
            this.lblUsedMods.AutoSize = true;
            this.lblUsedMods.Location = new System.Drawing.Point(6, 9);
            this.lblUsedMods.Name = "lblUsedMods";
            this.lblUsedMods.Size = new System.Drawing.Size(132, 20);
            this.lblUsedMods.TabIndex = 0;
            this.lblUsedMods.Text = "Підключені моди:";
            // 
            // tbWidth
            // 
            this.tbWidth.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbWidth.Location = new System.Drawing.Point(0, 191);
            this.tbWidth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbWidth.Minimum = 2;
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(198, 56);
            this.tbWidth.SmallChange = 2;
            this.tbWidth.TabIndex = 0;
            this.tbWidth.TickFrequency = 2;
            this.tbWidth.Value = 4;
            this.tbWidth.Scroll += new System.EventHandler(this.tbWidth_Scroll);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWidth.Location = new System.Drawing.Point(0, 171);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(72, 20);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 171);
            this.panel2.TabIndex = 1;
            // 
            // bntThistle
            // 
            this.bntThistle.BackColor = System.Drawing.Color.Thistle;
            this.bntThistle.Location = new System.Drawing.Point(147, 108);
            this.bntThistle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bntThistle.Name = "bntThistle";
            this.bntThistle.Size = new System.Drawing.Size(40, 44);
            this.bntThistle.TabIndex = 11;
            this.bntThistle.UseVisualStyleBackColor = false;
            this.bntThistle.Click += new System.EventHandler(this.bntThistle_Click);
            // 
            // bntLime
            // 
            this.bntLime.BackColor = System.Drawing.Color.Lime;
            this.bntLime.Location = new System.Drawing.Point(101, 108);
            this.bntLime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bntLime.Name = "bntLime";
            this.bntLime.Size = new System.Drawing.Size(40, 44);
            this.bntLime.TabIndex = 10;
            this.bntLime.UseVisualStyleBackColor = false;
            this.bntLime.Click += new System.EventHandler(this.bntLime_Click);
            // 
            // bntMoccassin
            // 
            this.bntMoccassin.BackColor = System.Drawing.Color.Moccasin;
            this.bntMoccassin.Location = new System.Drawing.Point(54, 108);
            this.bntMoccassin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bntMoccassin.Name = "bntMoccassin";
            this.bntMoccassin.Size = new System.Drawing.Size(40, 44);
            this.bntMoccassin.TabIndex = 9;
            this.bntMoccassin.UseVisualStyleBackColor = false;
            this.bntMoccassin.Click += new System.EventHandler(this.bntMoccassin_Click);
            // 
            // bntTan
            // 
            this.bntTan.BackColor = System.Drawing.Color.Tan;
            this.bntTan.Location = new System.Drawing.Point(7, 108);
            this.bntTan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bntTan.Name = "bntTan";
            this.bntTan.Size = new System.Drawing.Size(40, 44);
            this.bntTan.TabIndex = 8;
            this.bntTan.UseVisualStyleBackColor = false;
            this.bntTan.Click += new System.EventHandler(this.bntTan_Click);
            // 
            // bntSilver
            // 
            this.bntSilver.BackColor = System.Drawing.Color.Silver;
            this.bntSilver.Location = new System.Drawing.Point(101, 56);
            this.bntSilver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bntSilver.Name = "bntSilver";
            this.bntSilver.Size = new System.Drawing.Size(40, 44);
            this.bntSilver.TabIndex = 7;
            this.bntSilver.UseVisualStyleBackColor = false;
            this.bntSilver.Click += new System.EventHandler(this.bntSilver_Click);
            // 
            // bntGray
            // 
            this.bntGray.BackColor = System.Drawing.Color.Gray;
            this.bntGray.Location = new System.Drawing.Point(54, 56);
            this.bntGray.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bntGray.Name = "bntGray";
            this.bntGray.Size = new System.Drawing.Size(40, 44);
            this.bntGray.TabIndex = 6;
            this.bntGray.UseVisualStyleBackColor = false;
            this.bntGray.Click += new System.EventHandler(this.bntGray_Click);
            // 
            // bntBlack
            // 
            this.bntBlack.BackColor = System.Drawing.Color.Black;
            this.bntBlack.Location = new System.Drawing.Point(7, 56);
            this.bntBlack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bntBlack.Name = "bntBlack";
            this.bntBlack.Size = new System.Drawing.Size(40, 44);
            this.bntBlack.TabIndex = 5;
            this.bntBlack.UseVisualStyleBackColor = false;
            this.bntBlack.Click += new System.EventHandler(this.bntBlack_Click);
            // 
            // bntWhite
            // 
            this.bntWhite.BackColor = System.Drawing.Color.White;
            this.bntWhite.Location = new System.Drawing.Point(147, 56);
            this.bntWhite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bntWhite.Name = "bntWhite";
            this.bntWhite.Size = new System.Drawing.Size(40, 44);
            this.bntWhite.TabIndex = 4;
            this.bntWhite.UseVisualStyleBackColor = false;
            this.bntWhite.Click += new System.EventHandler(this.bntWhite_Click);
            // 
            // bntGreen
            // 
            this.bntGreen.BackColor = System.Drawing.Color.Green;
            this.bntGreen.Location = new System.Drawing.Point(147, 4);
            this.bntGreen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bntGreen.Name = "bntGreen";
            this.bntGreen.Size = new System.Drawing.Size(40, 44);
            this.bntGreen.TabIndex = 3;
            this.bntGreen.UseVisualStyleBackColor = false;
            this.bntGreen.Click += new System.EventHandler(this.bntGreen_Click);
            // 
            // bntBlue
            // 
            this.bntBlue.BackColor = System.Drawing.Color.Blue;
            this.bntBlue.Location = new System.Drawing.Point(101, 4);
            this.bntBlue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bntBlue.Name = "bntBlue";
            this.bntBlue.Size = new System.Drawing.Size(40, 44);
            this.bntBlue.TabIndex = 2;
            this.bntBlue.UseVisualStyleBackColor = false;
            this.bntBlue.Click += new System.EventHandler(this.bntBlue_Click);
            // 
            // bntRed
            // 
            this.bntRed.BackColor = System.Drawing.Color.Red;
            this.bntRed.Location = new System.Drawing.Point(54, 4);
            this.bntRed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bntRed.Name = "bntRed";
            this.bntRed.Size = new System.Drawing.Size(40, 44);
            this.bntRed.TabIndex = 1;
            this.bntRed.UseVisualStyleBackColor = false;
            this.bntRed.Click += new System.EventHandler(this.bntRed_Click);
            // 
            // bntYellow
            // 
            this.bntYellow.BackColor = System.Drawing.Color.Yellow;
            this.bntYellow.Location = new System.Drawing.Point(7, 4);
            this.bntYellow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bntYellow.Name = "bntYellow";
            this.bntYellow.Size = new System.Drawing.Size(40, 44);
            this.bntYellow.TabIndex = 0;
            this.bntYellow.UseVisualStyleBackColor = false;
            this.bntYellow.Click += new System.EventHandler(this.bntYellow_Click);
            // 
            // tsMain
            // 
            this.tsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssb,
            this.toolStripSeparator3,
            this.tsbSave,
            this.toolStripSeparator2,
            this.tsbUnDo,
            this.tsbReDo,
            this.toolStripSeparator1,
            this.select});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(914, 27);
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
            this.tssb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssb.Name = "tssb";
            this.tssb.Size = new System.Drawing.Size(70, 24);
            this.tssb.Text = "Меню";
            this.tssb.ButtonClick += new System.EventHandler(this.tssb_ButtonClick);
            // 
            // створитиToolStripMenuItem
            // 
            this.створитиToolStripMenuItem.Name = "створитиToolStripMenuItem";
            this.створитиToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.створитиToolStripMenuItem.Text = "Створити";
            this.створитиToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // додатиМодульToolStripMenuItem
            // 
            this.додатиМодульToolStripMenuItem.Name = "додатиМодульToolStripMenuItem";
            this.додатиМодульToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.додатиМодульToolStripMenuItem.Text = "Додати модуль";
            this.додатиМодульToolStripMenuItem.Click += new System.EventHandler(this.addModuleToolStripMenuItem_Click);
            // 
            // відкритиToolStripMenuItem
            // 
            this.відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            this.відкритиToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.відкритиToolStripMenuItem.Text = "Відкрити";
            this.відкритиToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.зберегтиToolStripMenuItem.Text = "Зберегти";
            this.зберегтиToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // зберегтиЯкToolStripMenuItem
            // 
            this.зберегтиЯкToolStripMenuItem.Name = "зберегтиЯкToolStripMenuItem";
            this.зберегтиЯкToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.зберегтиЯкToolStripMenuItem.Text = "Зберегти як..";
            this.зберегтиЯкToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.вихідToolStripMenuItem.Text = "Вихід";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(29, 24);
            this.tsbSave.Text = "Зберегти";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbUnDo
            // 
            this.tsbUnDo.BackgroundImage = global::Paint.Properties.Resources.undo1;
            this.tsbUnDo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUnDo.Image = ((System.Drawing.Image)(resources.GetObject("tsbUnDo.Image")));
            this.tsbUnDo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUnDo.Name = "tsbUnDo";
            this.tsbUnDo.Size = new System.Drawing.Size(29, 24);
            this.tsbUnDo.Text = "toolStripButton1";
            this.tsbUnDo.Click += new System.EventHandler(this.tsbUnDo_Click);
            // 
            // tsbReDo
            // 
            this.tsbReDo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReDo.Image = ((System.Drawing.Image)(resources.GetObject("tsbReDo.Image")));
            this.tsbReDo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReDo.Name = "tsbReDo";
            this.tsbReDo.Size = new System.Drawing.Size(29, 24);
            this.tsbReDo.Text = "toolStripButton1";
            this.tsbReDo.Click += new System.EventHandler(this.tsbReDo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // select
            // 
            this.select.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.select.Image = global::Paint.Properties.Resources.cursor_11549398080fd7y2r6evj;
            this.select.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(29, 24);
            this.select.Text = "toolStripButton1";
            this.select.Click += new System.EventHandler(this.select_Click_1);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tsMain);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(930, 596);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelFillColours.ResumeLayout(false);
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
        private Button buttonFillOn;
        private Button buttonFillOff;
        private Panel panelFillColours;
        private Button buttonGrayFill;
        private Button buttonBlackFill;
        private Button buttonGreenFill;
        private Button buttonBlueFill;
        private Button buttonRedFill;
        private Button buttonYellowFill;
        private Button buttonThistleFill;
        private Button buttonMoccasinFill;
        private ToolStripButton tsbUnDo;
        private ToolStripButton tsbReDo;
        private ToolStripButton select;
    }
}