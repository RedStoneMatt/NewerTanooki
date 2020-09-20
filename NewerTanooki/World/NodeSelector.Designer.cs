using System;
using System.Windows.Forms;

namespace NewerTanooki.World
{
    partial class NodeSelector
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
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 60; // in miliseconds
            timer1.Start();
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NodeSelector));
            this.yoshiPictureBox = new System.Windows.Forms.PictureBox();
            this.yoshiPanel = new System.Windows.Forms.Panel();
            this.marioPictureBox = new System.Windows.Forms.PictureBox();
            this.button1o38 = new System.Windows.Forms.Button();
            this.button1o25 = new System.Windows.Forms.Button();
            this.button1o33 = new System.Windows.Forms.Button();
            this.button1o31 = new System.Windows.Forms.Button();
            this.button1oP5 = new System.Windows.Forms.Button();
            this.button1o7 = new System.Windows.Forms.Button();
            this.button1oP4 = new System.Windows.Forms.Button();
            this.button1o8 = new System.Windows.Forms.Button();
            this.button1oP3 = new System.Windows.Forms.Button();
            this.button1o6 = new System.Windows.Forms.Button();
            this.button1o5 = new System.Windows.Forms.Button();
            this.button1oP2 = new System.Windows.Forms.Button();
            this.button1o15 = new System.Windows.Forms.Button();
            this.button1o3 = new System.Windows.Forms.Button();
            this.button1oP1 = new System.Windows.Forms.Button();
            this.button1o4 = new System.Windows.Forms.Button();
            this.button1o99 = new System.Windows.Forms.Button();
            this.button1o2 = new System.Windows.Forms.Button();
            this.button1o1 = new System.Windows.Forms.Button();
            this.button1oStart = new System.Windows.Forms.Button();
            this.button1o41 = new System.Windows.Forms.Button();
            this.nodeMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nodeTabControl = new System.Windows.Forms.TabControl();
            this.yoshiTabPage = new System.Windows.Forms.TabPage();
            this.fullmapTabPage = new System.Windows.Forms.TabPage();
            this.fullmapPanel = new System.Windows.Forms.Panel();
            this.button10o18 = new System.Windows.Forms.Button();
            this.button10o17 = new System.Windows.Forms.Button();
            this.button10o16 = new System.Windows.Forms.Button();
            this.button7o3 = new System.Windows.Forms.Button();
            this.button7o2 = new System.Windows.Forms.Button();
            this.button7o1 = new System.Windows.Forms.Button();
            this.button6o34 = new System.Windows.Forms.Button();
            this.button6o9 = new System.Windows.Forms.Button();
            this.button6o38 = new System.Windows.Forms.Button();
            this.button6o8 = new System.Windows.Forms.Button();
            this.button6o25 = new System.Windows.Forms.Button();
            this.button6o6 = new System.Windows.Forms.Button();
            this.button6o5 = new System.Windows.Forms.Button();
            this.button6o4 = new System.Windows.Forms.Button();
            this.button6o15 = new System.Windows.Forms.Button();
            this.button6o99 = new System.Windows.Forms.Button();
            this.button6o33 = new System.Windows.Forms.Button();
            this.button6oP1 = new System.Windows.Forms.Button();
            this.button6o7 = new System.Windows.Forms.Button();
            this.button6o3 = new System.Windows.Forms.Button();
            this.button6o2 = new System.Windows.Forms.Button();
            this.button6o1 = new System.Windows.Forms.Button();
            this.button3o6 = new System.Windows.Forms.Button();
            this.button3o34 = new System.Windows.Forms.Button();
            this.button3o38 = new System.Windows.Forms.Button();
            this.button3o25 = new System.Windows.Forms.Button();
            this.button3o7 = new System.Windows.Forms.Button();
            this.button3oP3 = new System.Windows.Forms.Button();
            this.button3o5 = new System.Windows.Forms.Button();
            this.button3oP2 = new System.Windows.Forms.Button();
            this.button3o33 = new System.Windows.Forms.Button();
            this.button3oP1 = new System.Windows.Forms.Button();
            this.button3o99 = new System.Windows.Forms.Button();
            this.button3o15 = new System.Windows.Forms.Button();
            this.button3o4 = new System.Windows.Forms.Button();
            this.button3o2 = new System.Windows.Forms.Button();
            this.button3o3 = new System.Windows.Forms.Button();
            this.button3o1 = new System.Windows.Forms.Button();
            this.button2o38 = new System.Windows.Forms.Button();
            this.button2oP2 = new System.Windows.Forms.Button();
            this.button2oP1 = new System.Windows.Forms.Button();
            this.button2o34 = new System.Windows.Forms.Button();
            this.button2o25 = new System.Windows.Forms.Button();
            this.button2o9 = new System.Windows.Forms.Button();
            this.button2o7 = new System.Windows.Forms.Button();
            this.button2o6 = new System.Windows.Forms.Button();
            this.button2o8 = new System.Windows.Forms.Button();
            this.button2o10 = new System.Windows.Forms.Button();
            this.button2o5 = new System.Windows.Forms.Button();
            this.button2o99 = new System.Windows.Forms.Button();
            this.button2o1 = new System.Windows.Forms.Button();
            this.fullmapPictureBox = new System.Windows.Forms.PictureBox();
            this.sewerTabPage = new System.Windows.Forms.TabPage();
            this.sewerPanel = new System.Windows.Forms.Panel();
            this.button2oP3 = new System.Windows.Forms.Button();
            this.button2o33 = new System.Windows.Forms.Button();
            this.button2o15 = new System.Windows.Forms.Button();
            this.button2o4 = new System.Windows.Forms.Button();
            this.button2o3 = new System.Windows.Forms.Button();
            this.button2o2 = new System.Windows.Forms.Button();
            this.sewerPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.yoshiPictureBox)).BeginInit();
            this.yoshiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marioPictureBox)).BeginInit();
            this.nodeMenuStrip.SuspendLayout();
            this.nodeTabControl.SuspendLayout();
            this.yoshiTabPage.SuspendLayout();
            this.fullmapTabPage.SuspendLayout();
            this.fullmapPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullmapPictureBox)).BeginInit();
            this.sewerTabPage.SuspendLayout();
            this.sewerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sewerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // yoshiPictureBox
            // 
            this.yoshiPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.yoshiPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yoshiPictureBox.Image = global::NewerTanooki.Properties.Resources.Yoshi_s_Island;
            this.yoshiPictureBox.Location = new System.Drawing.Point(0, 0);
            this.yoshiPictureBox.Name = "yoshiPictureBox";
            this.yoshiPictureBox.Size = new System.Drawing.Size(4475, 1776);
            this.yoshiPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.yoshiPictureBox.TabIndex = 0;
            this.yoshiPictureBox.TabStop = false;
            // 
            // yoshiPanel
            // 
            this.yoshiPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yoshiPanel.AutoScroll = true;
            this.yoshiPanel.Controls.Add(this.marioPictureBox);
            this.yoshiPanel.Controls.Add(this.button1o38);
            this.yoshiPanel.Controls.Add(this.button1o25);
            this.yoshiPanel.Controls.Add(this.button1o33);
            this.yoshiPanel.Controls.Add(this.button1o31);
            this.yoshiPanel.Controls.Add(this.button1oP5);
            this.yoshiPanel.Controls.Add(this.button1o7);
            this.yoshiPanel.Controls.Add(this.button1oP4);
            this.yoshiPanel.Controls.Add(this.button1o8);
            this.yoshiPanel.Controls.Add(this.button1oP3);
            this.yoshiPanel.Controls.Add(this.button1o6);
            this.yoshiPanel.Controls.Add(this.button1o5);
            this.yoshiPanel.Controls.Add(this.button1oP2);
            this.yoshiPanel.Controls.Add(this.button1o15);
            this.yoshiPanel.Controls.Add(this.button1o3);
            this.yoshiPanel.Controls.Add(this.button1oP1);
            this.yoshiPanel.Controls.Add(this.button1o4);
            this.yoshiPanel.Controls.Add(this.button1o99);
            this.yoshiPanel.Controls.Add(this.button1o2);
            this.yoshiPanel.Controls.Add(this.button1o1);
            this.yoshiPanel.Controls.Add(this.button1oStart);
            this.yoshiPanel.Controls.Add(this.button1o41);
            this.yoshiPanel.Controls.Add(this.yoshiPictureBox);
            this.yoshiPanel.Location = new System.Drawing.Point(6, 6);
            this.yoshiPanel.Name = "yoshiPanel";
            this.yoshiPanel.Size = new System.Drawing.Size(982, 564);
            this.yoshiPanel.TabIndex = 2;
            // 
            // marioPictureBox
            // 
            this.marioPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.marioPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("marioPictureBox.Image")));
            this.marioPictureBox.Location = new System.Drawing.Point(424, 881);
            this.marioPictureBox.Name = "marioPictureBox";
            this.marioPictureBox.Size = new System.Drawing.Size(52, 63);
            this.marioPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.marioPictureBox.TabIndex = 22;
            this.marioPictureBox.TabStop = false;
            // 
            // button1o38
            // 
            this.button1o38.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button1o38.Image = ((System.Drawing.Image)(resources.GetObject("button1o38.Image")));
            this.button1o38.Location = new System.Drawing.Point(3612, 898);
            this.button1o38.Name = "button1o38";
            this.button1o38.Size = new System.Drawing.Size(38, 38);
            this.button1o38.TabIndex = 21;
            this.button1o38.Text = "55";
            this.button1o38.UseVisualStyleBackColor = true;
            this.button1o38.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button1o25
            // 
            this.button1o25.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button1o25.Image = ((System.Drawing.Image)(resources.GetObject("button1o25.Image")));
            this.button1o25.Location = new System.Drawing.Point(3191, 899);
            this.button1o25.Name = "button1o25";
            this.button1o25.Size = new System.Drawing.Size(38, 38);
            this.button1o25.TabIndex = 20;
            this.button1o25.Text = "54";
            this.button1o25.UseVisualStyleBackColor = true;
            this.button1o25.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button1o33
            // 
            this.button1o33.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button1o33.Image = ((System.Drawing.Image)(resources.GetObject("button1o33.Image")));
            this.button1o33.Location = new System.Drawing.Point(2759, 778);
            this.button1o33.Name = "button1o33";
            this.button1o33.Size = new System.Drawing.Size(38, 38);
            this.button1o33.TabIndex = 19;
            this.button1o33.Text = "39";
            this.button1o33.UseVisualStyleBackColor = true;
            this.button1o33.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button1o31
            // 
            this.button1o31.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button1o31.Image = ((System.Drawing.Image)(resources.GetObject("button1o31.Image")));
            this.button1o31.Location = new System.Drawing.Point(2664, 1306);
            this.button1o31.Name = "button1o31";
            this.button1o31.Size = new System.Drawing.Size(38, 38);
            this.button1o31.TabIndex = 18;
            this.button1o31.Text = "50";
            this.button1o31.UseVisualStyleBackColor = true;
            this.button1o31.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button1oP5
            // 
            this.button1oP5.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button1oP5.Image = ((System.Drawing.Image)(resources.GetObject("button1oP5.Image")));
            this.button1oP5.Location = new System.Drawing.Point(2759, 874);
            this.button1oP5.Name = "button1oP5";
            this.button1oP5.Size = new System.Drawing.Size(38, 38);
            this.button1oP5.TabIndex = 17;
            this.button1oP5.Text = "38";
            this.button1oP5.UseVisualStyleBackColor = true;
            this.button1oP5.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button1o7
            // 
            this.button1o7.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button1o7.Image = ((System.Drawing.Image)(resources.GetObject("button1o7.Image")));
            this.button1o7.Location = new System.Drawing.Point(2542, 634);
            this.button1o7.Name = "button1o7";
            this.button1o7.Size = new System.Drawing.Size(38, 38);
            this.button1o7.TabIndex = 16;
            this.button1o7.Text = "30";
            this.button1o7.UseVisualStyleBackColor = true;
            this.button1o7.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button1oP4
            // 
            this.button1oP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button1oP4.Image = ((System.Drawing.Image)(resources.GetObject("button1oP4.Image")));
            this.button1oP4.Location = new System.Drawing.Point(2542, 874);
            this.button1oP4.Name = "button1oP4";
            this.button1oP4.Size = new System.Drawing.Size(38, 38);
            this.button1oP4.TabIndex = 15;
            this.button1oP4.Text = "35";
            this.button1oP4.UseVisualStyleBackColor = true;
            this.button1oP4.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button1o8
            // 
            this.button1o8.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button1o8.Image = ((System.Drawing.Image)(resources.GetObject("button1o8.Image")));
            this.button1o8.Location = new System.Drawing.Point(2446, 874);
            this.button1o8.Name = "button1o8";
            this.button1o8.Size = new System.Drawing.Size(38, 38);
            this.button1o8.TabIndex = 14;
            this.button1o8.Text = "34";
            this.button1o8.UseVisualStyleBackColor = true;
            this.button1o8.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button1oP3
            // 
            this.button1oP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button1oP3.Image = ((System.Drawing.Image)(resources.GetObject("button1oP3.Image")));
            this.button1oP3.Location = new System.Drawing.Point(2303, 730);
            this.button1oP3.Name = "button1oP3";
            this.button1oP3.Size = new System.Drawing.Size(38, 38);
            this.button1oP3.TabIndex = 13;
            this.button1oP3.Text = "28";
            this.button1oP3.UseVisualStyleBackColor = true;
            this.button1oP3.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button1o6
            // 
            this.button1o6.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button1o6.Image = ((System.Drawing.Image)(resources.GetObject("button1o6.Image")));
            this.button1o6.Location = new System.Drawing.Point(2184, 730);
            this.button1o6.Name = "button1o6";
            this.button1o6.Size = new System.Drawing.Size(38, 38);
            this.button1o6.TabIndex = 12;
            this.button1o6.Text = "27";
            this.button1o6.UseVisualStyleBackColor = true;
            this.button1o6.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button1o5
            // 
            this.button1o5.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button1o5.Image = ((System.Drawing.Image)(resources.GetObject("button1o5.Image")));
            this.button1o5.Location = new System.Drawing.Point(1883, 730);
            this.button1o5.Name = "button1o5";
            this.button1o5.Size = new System.Drawing.Size(38, 38);
            this.button1o5.TabIndex = 11;
            this.button1o5.Text = "26";
            this.button1o5.UseVisualStyleBackColor = true;
            this.button1o5.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button1oP2
            // 
            this.button1oP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button1oP2.Image = ((System.Drawing.Image)(resources.GetObject("button1oP2.Image")));
            this.button1oP2.Location = new System.Drawing.Point(1391, 730);
            this.button1oP2.Name = "button1oP2";
            this.button1oP2.Size = new System.Drawing.Size(38, 38);
            this.button1oP2.TabIndex = 10;
            this.button1oP2.Text = "19";
            this.button1oP2.UseVisualStyleBackColor = true;
            this.button1oP2.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button1o15
            // 
            this.button1o15.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button1o15.Image = ((System.Drawing.Image)(resources.GetObject("button1o15.Image")));
            this.button1o15.Location = new System.Drawing.Point(1583, 730);
            this.button1o15.Name = "button1o15";
            this.button1o15.Size = new System.Drawing.Size(38, 38);
            this.button1o15.TabIndex = 9;
            this.button1o15.Text = "20";
            this.button1o15.UseVisualStyleBackColor = true;
            this.button1o15.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button1o3
            // 
            this.button1o3.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button1o3.Image = ((System.Drawing.Image)(resources.GetObject("button1o3.Image")));
            this.button1o3.Location = new System.Drawing.Point(1248, 658);
            this.button1o3.Name = "button1o3";
            this.button1o3.Size = new System.Drawing.Size(38, 38);
            this.button1o3.TabIndex = 8;
            this.button1o3.Text = "15";
            this.button1o3.UseVisualStyleBackColor = true;
            this.button1o3.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button1oP1
            // 
            this.button1oP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button1oP1.Image = ((System.Drawing.Image)(resources.GetObject("button1oP1.Image")));
            this.button1oP1.Location = new System.Drawing.Point(1127, 899);
            this.button1oP1.Name = "button1oP1";
            this.button1oP1.Size = new System.Drawing.Size(38, 38);
            this.button1oP1.TabIndex = 7;
            this.button1oP1.Text = "11";
            this.button1oP1.UseVisualStyleBackColor = true;
            this.button1oP1.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button1o4
            // 
            this.button1o4.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button1o4.Image = ((System.Drawing.Image)(resources.GetObject("button1o4.Image")));
            this.button1o4.Location = new System.Drawing.Point(1319, 1018);
            this.button1o4.Name = "button1o4";
            this.button1o4.Size = new System.Drawing.Size(38, 38);
            this.button1o4.TabIndex = 6;
            this.button1o4.Text = "17";
            this.button1o4.UseVisualStyleBackColor = true;
            this.button1o4.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button1o99
            // 
            this.button1o99.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button1o99.Image = ((System.Drawing.Image)(resources.GetObject("button1o99.Image")));
            this.button1o99.Location = new System.Drawing.Point(983, 1187);
            this.button1o99.Name = "button1o99";
            this.button1o99.Size = new System.Drawing.Size(38, 38);
            this.button1o99.TabIndex = 5;
            this.button1o99.Text = "10";
            this.button1o99.UseVisualStyleBackColor = true;
            this.button1o99.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button1o2
            // 
            this.button1o2.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button1o2.Image = ((System.Drawing.Image)(resources.GetObject("button1o2.Image")));
            this.button1o2.Location = new System.Drawing.Point(959, 899);
            this.button1o2.Name = "button1o2";
            this.button1o2.Size = new System.Drawing.Size(38, 38);
            this.button1o2.TabIndex = 4;
            this.button1o2.Text = "7";
            this.button1o2.UseVisualStyleBackColor = true;
            this.button1o2.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button1o1
            // 
            this.button1o1.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button1o1.Image = ((System.Drawing.Image)(resources.GetObject("button1o1.Image")));
            this.button1o1.Location = new System.Drawing.Point(647, 922);
            this.button1o1.Name = "button1o1";
            this.button1o1.Size = new System.Drawing.Size(38, 38);
            this.button1o1.TabIndex = 3;
            this.button1o1.Text = "1";
            this.button1o1.UseVisualStyleBackColor = true;
            this.button1o1.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button1oStart
            // 
            this.button1oStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button1oStart.Image = ((System.Drawing.Image)(resources.GetObject("button1oStart.Image")));
            this.button1oStart.Location = new System.Drawing.Point(430, 922);
            this.button1oStart.Name = "button1oStart";
            this.button1oStart.Size = new System.Drawing.Size(38, 38);
            this.button1oStart.TabIndex = 2;
            this.button1oStart.Text = "0";
            this.button1oStart.UseVisualStyleBackColor = true;
            this.button1oStart.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button1o41
            // 
            this.button1o41.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button1o41.Image = ((System.Drawing.Image)(resources.GetObject("button1o41.Image")));
            this.button1o41.Location = new System.Drawing.Point(647, 706);
            this.button1o41.Name = "button1o41";
            this.button1o41.Size = new System.Drawing.Size(38, 38);
            this.button1o41.TabIndex = 1;
            this.button1o41.Text = "4";
            this.button1o41.UseVisualStyleBackColor = true;
            this.button1o41.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // nodeMenuStrip
            // 
            this.nodeMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.nodeMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.nodeMenuStrip.Name = "nodeMenuStrip";
            this.nodeMenuStrip.Size = new System.Drawing.Size(1026, 24);
            this.nodeMenuStrip.TabIndex = 3;
            this.nodeMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doneToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // doneToolStripMenuItem
            // 
            this.doneToolStripMenuItem.Name = "doneToolStripMenuItem";
            this.doneToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.doneToolStripMenuItem.Text = "Done";
            this.doneToolStripMenuItem.Click += new System.EventHandler(this.doneToolStripMenuItem_Click);
            // 
            // nodeTabControl
            // 
            this.nodeTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nodeTabControl.Controls.Add(this.yoshiTabPage);
            this.nodeTabControl.Controls.Add(this.fullmapTabPage);
            this.nodeTabControl.Controls.Add(this.sewerTabPage);
            this.nodeTabControl.Location = new System.Drawing.Point(12, 27);
            this.nodeTabControl.Name = "nodeTabControl";
            this.nodeTabControl.SelectedIndex = 0;
            this.nodeTabControl.Size = new System.Drawing.Size(1002, 602);
            this.nodeTabControl.TabIndex = 4;
            // 
            // yoshiTabPage
            // 
            this.yoshiTabPage.Controls.Add(this.yoshiPanel);
            this.yoshiTabPage.Location = new System.Drawing.Point(4, 22);
            this.yoshiTabPage.Name = "yoshiTabPage";
            this.yoshiTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.yoshiTabPage.Size = new System.Drawing.Size(994, 576);
            this.yoshiTabPage.TabIndex = 0;
            this.yoshiTabPage.Text = "YoshiIsland";
            this.yoshiTabPage.UseVisualStyleBackColor = true;
            // 
            // fullmapTabPage
            // 
            this.fullmapTabPage.Controls.Add(this.fullmapPanel);
            this.fullmapTabPage.Location = new System.Drawing.Point(4, 22);
            this.fullmapTabPage.Name = "fullmapTabPage";
            this.fullmapTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.fullmapTabPage.Size = new System.Drawing.Size(994, 576);
            this.fullmapTabPage.TabIndex = 1;
            this.fullmapTabPage.Text = "Fullmap";
            this.fullmapTabPage.UseVisualStyleBackColor = true;
            // 
            // fullmapPanel
            // 
            this.fullmapPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullmapPanel.AutoScroll = true;
            this.fullmapPanel.Controls.Add(this.button10o18);
            this.fullmapPanel.Controls.Add(this.button10o17);
            this.fullmapPanel.Controls.Add(this.button10o16);
            this.fullmapPanel.Controls.Add(this.button7o3);
            this.fullmapPanel.Controls.Add(this.button7o2);
            this.fullmapPanel.Controls.Add(this.button7o1);
            this.fullmapPanel.Controls.Add(this.button6o34);
            this.fullmapPanel.Controls.Add(this.button6o9);
            this.fullmapPanel.Controls.Add(this.button6o38);
            this.fullmapPanel.Controls.Add(this.button6o8);
            this.fullmapPanel.Controls.Add(this.button6o25);
            this.fullmapPanel.Controls.Add(this.button6o6);
            this.fullmapPanel.Controls.Add(this.button6o5);
            this.fullmapPanel.Controls.Add(this.button6o4);
            this.fullmapPanel.Controls.Add(this.button6o15);
            this.fullmapPanel.Controls.Add(this.button6o99);
            this.fullmapPanel.Controls.Add(this.button6o33);
            this.fullmapPanel.Controls.Add(this.button6oP1);
            this.fullmapPanel.Controls.Add(this.button6o7);
            this.fullmapPanel.Controls.Add(this.button6o3);
            this.fullmapPanel.Controls.Add(this.button6o2);
            this.fullmapPanel.Controls.Add(this.button6o1);
            this.fullmapPanel.Controls.Add(this.button3o6);
            this.fullmapPanel.Controls.Add(this.button3o34);
            this.fullmapPanel.Controls.Add(this.button3o38);
            this.fullmapPanel.Controls.Add(this.button3o25);
            this.fullmapPanel.Controls.Add(this.button3o7);
            this.fullmapPanel.Controls.Add(this.button3oP3);
            this.fullmapPanel.Controls.Add(this.button3o5);
            this.fullmapPanel.Controls.Add(this.button3oP2);
            this.fullmapPanel.Controls.Add(this.button3o33);
            this.fullmapPanel.Controls.Add(this.button3oP1);
            this.fullmapPanel.Controls.Add(this.button3o99);
            this.fullmapPanel.Controls.Add(this.button3o15);
            this.fullmapPanel.Controls.Add(this.button3o4);
            this.fullmapPanel.Controls.Add(this.button3o2);
            this.fullmapPanel.Controls.Add(this.button3o3);
            this.fullmapPanel.Controls.Add(this.button3o1);
            this.fullmapPanel.Controls.Add(this.button2o38);
            this.fullmapPanel.Controls.Add(this.button2oP2);
            this.fullmapPanel.Controls.Add(this.button2oP1);
            this.fullmapPanel.Controls.Add(this.button2o34);
            this.fullmapPanel.Controls.Add(this.button2o25);
            this.fullmapPanel.Controls.Add(this.button2o9);
            this.fullmapPanel.Controls.Add(this.button2o7);
            this.fullmapPanel.Controls.Add(this.button2o6);
            this.fullmapPanel.Controls.Add(this.button2o8);
            this.fullmapPanel.Controls.Add(this.button2o10);
            this.fullmapPanel.Controls.Add(this.button2o5);
            this.fullmapPanel.Controls.Add(this.button2o99);
            this.fullmapPanel.Controls.Add(this.button2o1);
            this.fullmapPanel.Controls.Add(this.fullmapPictureBox);
            this.fullmapPanel.Location = new System.Drawing.Point(6, 6);
            this.fullmapPanel.Name = "fullmapPanel";
            this.fullmapPanel.Size = new System.Drawing.Size(982, 567);
            this.fullmapPanel.TabIndex = 0;
            // 
            // button10o18
            // 
            this.button10o18.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button10o18.Image = ((System.Drawing.Image)(resources.GetObject("button10o18.Image")));
            this.button10o18.Location = new System.Drawing.Point(738, 3346);
            this.button10o18.Name = "button10o18";
            this.button10o18.Size = new System.Drawing.Size(38, 38);
            this.button10o18.TabIndex = 54;
            this.button10o18.Text = "182";
            this.button10o18.UseVisualStyleBackColor = true;
            this.button10o18.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button10o17
            // 
            this.button10o17.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button10o17.Image = ((System.Drawing.Image)(resources.GetObject("button10o17.Image")));
            this.button10o17.Location = new System.Drawing.Point(1122, 3358);
            this.button10o17.Name = "button10o17";
            this.button10o17.Size = new System.Drawing.Size(38, 38);
            this.button10o17.TabIndex = 53;
            this.button10o17.Text = "181";
            this.button10o17.UseVisualStyleBackColor = true;
            this.button10o17.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button10o16
            // 
            this.button10o16.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button10o16.Image = ((System.Drawing.Image)(resources.GetObject("button10o16.Image")));
            this.button10o16.Location = new System.Drawing.Point(1122, 3070);
            this.button10o16.Name = "button10o16";
            this.button10o16.Size = new System.Drawing.Size(38, 38);
            this.button10o16.TabIndex = 52;
            this.button10o16.Text = "180";
            this.button10o16.UseVisualStyleBackColor = true;
            this.button10o16.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button7o3
            // 
            this.button7o3.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button7o3.Image = ((System.Drawing.Image)(resources.GetObject("button7o3.Image")));
            this.button7o3.Location = new System.Drawing.Point(1363, 1342);
            this.button7o3.Name = "button7o3";
            this.button7o3.Size = new System.Drawing.Size(38, 38);
            this.button7o3.TabIndex = 51;
            this.button7o3.Text = "131";
            this.button7o3.UseVisualStyleBackColor = true;
            this.button7o3.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button7o2
            // 
            this.button7o2.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button7o2.Image = ((System.Drawing.Image)(resources.GetObject("button7o2.Image")));
            this.button7o2.Location = new System.Drawing.Point(1637, 1474);
            this.button7o2.Name = "button7o2";
            this.button7o2.Size = new System.Drawing.Size(38, 38);
            this.button7o2.TabIndex = 50;
            this.button7o2.Text = "130";
            this.button7o2.UseVisualStyleBackColor = true;
            this.button7o2.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button7o1
            // 
            this.button7o1.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button7o1.Image = ((System.Drawing.Image)(resources.GetObject("button7o1.Image")));
            this.button7o1.Location = new System.Drawing.Point(1854, 1919);
            this.button7o1.Name = "button7o1";
            this.button7o1.Size = new System.Drawing.Size(38, 38);
            this.button7o1.TabIndex = 49;
            this.button7o1.Text = "129";
            this.button7o1.UseVisualStyleBackColor = true;
            this.button7o1.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button6o34
            // 
            this.button6o34.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button6o34.Image = ((System.Drawing.Image)(resources.GetObject("button6o34.Image")));
            this.button6o34.Location = new System.Drawing.Point(1674, 2782);
            this.button6o34.Name = "button6o34";
            this.button6o34.Size = new System.Drawing.Size(38, 38);
            this.button6o34.TabIndex = 48;
            this.button6o34.Text = "179";
            this.button6o34.UseVisualStyleBackColor = true;
            this.button6o34.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button6o9
            // 
            this.button6o9.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button6o9.Image = ((System.Drawing.Image)(resources.GetObject("button6o9.Image")));
            this.button6o9.Location = new System.Drawing.Point(1530, 3070);
            this.button6o9.Name = "button6o9";
            this.button6o9.Size = new System.Drawing.Size(38, 38);
            this.button6o9.TabIndex = 47;
            this.button6o9.Text = "160";
            this.button6o9.UseVisualStyleBackColor = true;
            this.button6o9.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button6o38
            // 
            this.button6o38.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button6o38.Image = ((System.Drawing.Image)(resources.GetObject("button6o38.Image")));
            this.button6o38.Location = new System.Drawing.Point(1854, 2218);
            this.button6o38.Name = "button6o38";
            this.button6o38.Size = new System.Drawing.Size(38, 38);
            this.button6o38.TabIndex = 46;
            this.button6o38.Text = "125";
            this.button6o38.UseVisualStyleBackColor = true;
            this.button6o38.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button6o8
            // 
            this.button6o8.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button6o8.Image = ((System.Drawing.Image)(resources.GetObject("button6o8.Image")));
            this.button6o8.Location = new System.Drawing.Point(1530, 2782);
            this.button6o8.Name = "button6o8";
            this.button6o8.Size = new System.Drawing.Size(38, 38);
            this.button6o8.TabIndex = 45;
            this.button6o8.Text = "122";
            this.button6o8.UseVisualStyleBackColor = true;
            this.button6o8.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button6o25
            // 
            this.button6o25.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button6o25.Image = ((System.Drawing.Image)(resources.GetObject("button6o25.Image")));
            this.button6o25.Location = new System.Drawing.Point(1530, 2638);
            this.button6o25.Name = "button6o25";
            this.button6o25.Size = new System.Drawing.Size(38, 38);
            this.button6o25.TabIndex = 44;
            this.button6o25.Text = "119";
            this.button6o25.UseVisualStyleBackColor = true;
            this.button6o25.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button6o6
            // 
            this.button6o6.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button6o6.Image = ((System.Drawing.Image)(resources.GetObject("button6o6.Image")));
            this.button6o6.Location = new System.Drawing.Point(1266, 2638);
            this.button6o6.Name = "button6o6";
            this.button6o6.Size = new System.Drawing.Size(38, 38);
            this.button6o6.TabIndex = 43;
            this.button6o6.Text = "116";
            this.button6o6.UseVisualStyleBackColor = true;
            this.button6o6.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button6o5
            // 
            this.button6o5.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button6o5.Image = ((System.Drawing.Image)(resources.GetObject("button6o5.Image")));
            this.button6o5.Location = new System.Drawing.Point(1074, 2638);
            this.button6o5.Name = "button6o5";
            this.button6o5.Size = new System.Drawing.Size(38, 38);
            this.button6o5.TabIndex = 42;
            this.button6o5.Text = "115";
            this.button6o5.UseVisualStyleBackColor = true;
            this.button6o5.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button6o4
            // 
            this.button6o4.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button6o4.Image = ((System.Drawing.Image)(resources.GetObject("button6o4.Image")));
            this.button6o4.Location = new System.Drawing.Point(1074, 2422);
            this.button6o4.Name = "button6o4";
            this.button6o4.Size = new System.Drawing.Size(38, 38);
            this.button6o4.TabIndex = 41;
            this.button6o4.Text = "114";
            this.button6o4.UseVisualStyleBackColor = true;
            this.button6o4.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button6o15
            // 
            this.button6o15.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button6o15.Image = ((System.Drawing.Image)(resources.GetObject("button6o15.Image")));
            this.button6o15.Location = new System.Drawing.Point(881, 2494);
            this.button6o15.Name = "button6o15";
            this.button6o15.Size = new System.Drawing.Size(38, 38);
            this.button6o15.TabIndex = 40;
            this.button6o15.Text = "113";
            this.button6o15.UseVisualStyleBackColor = true;
            this.button6o15.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button6o99
            // 
            this.button6o99.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button6o99.Image = ((System.Drawing.Image)(resources.GetObject("button6o99.Image")));
            this.button6o99.Location = new System.Drawing.Point(354, 2494);
            this.button6o99.Name = "button6o99";
            this.button6o99.Size = new System.Drawing.Size(38, 38);
            this.button6o99.TabIndex = 39;
            this.button6o99.Text = "157";
            this.button6o99.UseVisualStyleBackColor = true;
            this.button6o99.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button6o33
            // 
            this.button6o33.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button6o33.Image = ((System.Drawing.Image)(resources.GetObject("button6o33.Image")));
            this.button6o33.Location = new System.Drawing.Point(547, 2494);
            this.button6o33.Name = "button6o33";
            this.button6o33.Size = new System.Drawing.Size(38, 38);
            this.button6o33.TabIndex = 38;
            this.button6o33.Text = "156";
            this.button6o33.UseVisualStyleBackColor = true;
            this.button6o33.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button6oP1
            // 
            this.button6oP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button6oP1.Image = ((System.Drawing.Image)(resources.GetObject("button6oP1.Image")));
            this.button6oP1.Location = new System.Drawing.Point(450, 2494);
            this.button6oP1.Name = "button6oP1";
            this.button6oP1.Size = new System.Drawing.Size(38, 38);
            this.button6oP1.TabIndex = 37;
            this.button6oP1.Text = "110";
            this.button6oP1.UseVisualStyleBackColor = true;
            this.button6oP1.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button6o7
            // 
            this.button6o7.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button6o7.Image = ((System.Drawing.Image)(resources.GetObject("button6o7.Image")));
            this.button6o7.Location = new System.Drawing.Point(450, 2302);
            this.button6o7.Name = "button6o7";
            this.button6o7.Size = new System.Drawing.Size(38, 38);
            this.button6o7.TabIndex = 36;
            this.button6o7.Text = "109";
            this.button6o7.UseVisualStyleBackColor = true;
            this.button6o7.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button6o3
            // 
            this.button6o3.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button6o3.Image = ((System.Drawing.Image)(resources.GetObject("button6o3.Image")));
            this.button6o3.Location = new System.Drawing.Point(642, 2302);
            this.button6o3.Name = "button6o3";
            this.button6o3.Size = new System.Drawing.Size(38, 38);
            this.button6o3.TabIndex = 35;
            this.button6o3.Text = "107";
            this.button6o3.UseVisualStyleBackColor = true;
            this.button6o3.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button6o2
            // 
            this.button6o2.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button6o2.Image = ((System.Drawing.Image)(resources.GetObject("button6o2.Image")));
            this.button6o2.Location = new System.Drawing.Point(642, 2181);
            this.button6o2.Name = "button6o2";
            this.button6o2.Size = new System.Drawing.Size(38, 38);
            this.button6o2.TabIndex = 34;
            this.button6o2.Text = "106";
            this.button6o2.UseVisualStyleBackColor = true;
            this.button6o2.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button6o1
            // 
            this.button6o1.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button6o1.Image = ((System.Drawing.Image)(resources.GetObject("button6o1.Image")));
            this.button6o1.Location = new System.Drawing.Point(545, 1846);
            this.button6o1.Name = "button6o1";
            this.button6o1.Size = new System.Drawing.Size(38, 38);
            this.button6o1.TabIndex = 33;
            this.button6o1.Text = "105";
            this.button6o1.UseVisualStyleBackColor = true;
            this.button6o1.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button3o6
            // 
            this.button3o6.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button3o6.Image = ((System.Drawing.Image)(resources.GetObject("button3o6.Image")));
            this.button3o6.Location = new System.Drawing.Point(2658, 1822);
            this.button3o6.Name = "button3o6";
            this.button3o6.Size = new System.Drawing.Size(38, 38);
            this.button3o6.TabIndex = 32;
            this.button3o6.Text = "87";
            this.button3o6.UseVisualStyleBackColor = true;
            this.button3o6.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button3o34
            // 
            this.button3o34.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button3o34.Image = ((System.Drawing.Image)(resources.GetObject("button3o34.Image")));
            this.button3o34.Location = new System.Drawing.Point(2466, 1703);
            this.button3o34.Name = "button3o34";
            this.button3o34.Size = new System.Drawing.Size(38, 38);
            this.button3o34.TabIndex = 31;
            this.button3o34.Text = "95";
            this.button3o34.UseVisualStyleBackColor = true;
            this.button3o34.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button3o38
            // 
            this.button3o38.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button3o38.Image = ((System.Drawing.Image)(resources.GetObject("button3o38.Image")));
            this.button3o38.Location = new System.Drawing.Point(2010, 1750);
            this.button3o38.Name = "button3o38";
            this.button3o38.Size = new System.Drawing.Size(38, 38);
            this.button3o38.TabIndex = 30;
            this.button3o38.Text = "94";
            this.button3o38.UseVisualStyleBackColor = true;
            this.button3o38.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button3o25
            // 
            this.button3o25.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button3o25.Image = ((System.Drawing.Image)(resources.GetObject("button3o25.Image")));
            this.button3o25.Location = new System.Drawing.Point(2155, 1894);
            this.button3o25.Name = "button3o25";
            this.button3o25.Size = new System.Drawing.Size(38, 38);
            this.button3o25.TabIndex = 29;
            this.button3o25.Text = "92";
            this.button3o25.UseVisualStyleBackColor = true;
            this.button3o25.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button3o7
            // 
            this.button3o7.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button3o7.Image = ((System.Drawing.Image)(resources.GetObject("button3o7.Image")));
            this.button3o7.Location = new System.Drawing.Point(2298, 1894);
            this.button3o7.Name = "button3o7";
            this.button3o7.Size = new System.Drawing.Size(38, 38);
            this.button3o7.TabIndex = 28;
            this.button3o7.Text = "89";
            this.button3o7.UseVisualStyleBackColor = true;
            this.button3o7.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button3oP3
            // 
            this.button3oP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button3oP3.Image = ((System.Drawing.Image)(resources.GetObject("button3oP3.Image")));
            this.button3oP3.Location = new System.Drawing.Point(2466, 1774);
            this.button3oP3.Name = "button3oP3";
            this.button3oP3.Size = new System.Drawing.Size(38, 38);
            this.button3oP3.TabIndex = 27;
            this.button3oP3.Text = "88";
            this.button3oP3.UseVisualStyleBackColor = true;
            this.button3oP3.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button3o5
            // 
            this.button3o5.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button3o5.Image = ((System.Drawing.Image)(resources.GetObject("button3o5.Image")));
            this.button3o5.Location = new System.Drawing.Point(2298, 2036);
            this.button3o5.Name = "button3o5";
            this.button3o5.Size = new System.Drawing.Size(38, 38);
            this.button3o5.TabIndex = 26;
            this.button3o5.Text = "85";
            this.button3o5.UseVisualStyleBackColor = true;
            this.button3o5.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button3oP2
            // 
            this.button3oP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button3oP2.Image = ((System.Drawing.Image)(resources.GetObject("button3oP2.Image")));
            this.button3oP2.Location = new System.Drawing.Point(2658, 1942);
            this.button3oP2.Name = "button3oP2";
            this.button3oP2.Size = new System.Drawing.Size(38, 38);
            this.button3oP2.TabIndex = 25;
            this.button3oP2.Text = "83";
            this.button3oP2.UseVisualStyleBackColor = true;
            this.button3oP2.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button3o33
            // 
            this.button3o33.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button3o33.Image = ((System.Drawing.Image)(resources.GetObject("button3o33.Image")));
            this.button3o33.Location = new System.Drawing.Point(2537, 2302);
            this.button3o33.Name = "button3o33";
            this.button3o33.Size = new System.Drawing.Size(38, 38);
            this.button3o33.TabIndex = 24;
            this.button3o33.Text = "78";
            this.button3o33.UseVisualStyleBackColor = true;
            this.button3o33.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button3oP1
            // 
            this.button3oP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button3oP1.Image = ((System.Drawing.Image)(resources.GetObject("button3oP1.Image")));
            this.button3oP1.Location = new System.Drawing.Point(2658, 2302);
            this.button3oP1.Name = "button3oP1";
            this.button3oP1.Size = new System.Drawing.Size(38, 38);
            this.button3oP1.TabIndex = 23;
            this.button3oP1.Text = "77";
            this.button3oP1.UseVisualStyleBackColor = true;
            this.button3oP1.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button3o99
            // 
            this.button3o99.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button3o99.Image = ((System.Drawing.Image)(resources.GetObject("button3o99.Image")));
            this.button3o99.Location = new System.Drawing.Point(3402, 2495);
            this.button3o99.Name = "button3o99";
            this.button3o99.Size = new System.Drawing.Size(38, 38);
            this.button3o99.TabIndex = 22;
            this.button3o99.Text = "71";
            this.button3o99.UseVisualStyleBackColor = true;
            this.button3o99.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button3o15
            // 
            this.button3o15.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button3o15.Image = ((System.Drawing.Image)(resources.GetObject("button3o15.Image")));
            this.button3o15.Location = new System.Drawing.Point(2754, 2302);
            this.button3o15.Name = "button3o15";
            this.button3o15.Size = new System.Drawing.Size(38, 38);
            this.button3o15.TabIndex = 21;
            this.button3o15.Text = "67";
            this.button3o15.UseVisualStyleBackColor = true;
            this.button3o15.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button3o4
            // 
            this.button3o4.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button3o4.Image = ((System.Drawing.Image)(resources.GetObject("button3o4.Image")));
            this.button3o4.Location = new System.Drawing.Point(3197, 2267);
            this.button3o4.Name = "button3o4";
            this.button3o4.Size = new System.Drawing.Size(38, 38);
            this.button3o4.TabIndex = 20;
            this.button3o4.Text = "62";
            this.button3o4.UseVisualStyleBackColor = true;
            this.button3o4.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button3o2
            // 
            this.button3o2.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button3o2.Image = ((System.Drawing.Image)(resources.GetObject("button3o2.Image")));
            this.button3o2.Location = new System.Drawing.Point(3113, 2516);
            this.button3o2.Name = "button3o2";
            this.button3o2.Size = new System.Drawing.Size(38, 38);
            this.button3o2.TabIndex = 19;
            this.button3o2.Text = "58";
            this.button3o2.UseVisualStyleBackColor = true;
            this.button3o2.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button3o3
            // 
            this.button3o3.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button3o3.Image = ((System.Drawing.Image)(resources.GetObject("button3o3.Image")));
            this.button3o3.Location = new System.Drawing.Point(2657, 2662);
            this.button3o3.Name = "button3o3";
            this.button3o3.Size = new System.Drawing.Size(38, 38);
            this.button3o3.TabIndex = 18;
            this.button3o3.Text = "57";
            this.button3o3.UseVisualStyleBackColor = true;
            this.button3o3.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button3o1
            // 
            this.button3o1.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button3o1.Image = ((System.Drawing.Image)(resources.GetObject("button3o1.Image")));
            this.button3o1.Location = new System.Drawing.Point(3114, 2662);
            this.button3o1.Name = "button3o1";
            this.button3o1.Size = new System.Drawing.Size(38, 38);
            this.button3o1.TabIndex = 17;
            this.button3o1.Text = "41";
            this.button3o1.UseVisualStyleBackColor = true;
            this.button3o1.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button2o38
            // 
            this.button2o38.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button2o38.Image = ((System.Drawing.Image)(resources.GetObject("button2o38.Image")));
            this.button2o38.Location = new System.Drawing.Point(3210, 2902);
            this.button2o38.Name = "button2o38";
            this.button2o38.Size = new System.Drawing.Size(38, 38);
            this.button2o38.TabIndex = 16;
            this.button2o38.Text = "27";
            this.button2o38.UseVisualStyleBackColor = true;
            this.button2o38.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button2oP2
            // 
            this.button2oP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button2oP2.Image = ((System.Drawing.Image)(resources.GetObject("button2oP2.Image")));
            this.button2oP2.Location = new System.Drawing.Point(2946, 3166);
            this.button2oP2.Name = "button2oP2";
            this.button2oP2.Size = new System.Drawing.Size(38, 38);
            this.button2oP2.TabIndex = 15;
            this.button2oP2.Text = "24";
            this.button2oP2.UseVisualStyleBackColor = true;
            this.button2oP2.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button2oP1
            // 
            this.button2oP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button2oP1.Image = ((System.Drawing.Image)(resources.GetObject("button2oP1.Image")));
            this.button2oP1.Location = new System.Drawing.Point(2201, 3526);
            this.button2oP1.Name = "button2oP1";
            this.button2oP1.Size = new System.Drawing.Size(38, 38);
            this.button2oP1.TabIndex = 14;
            this.button2oP1.Text = "3";
            this.button2oP1.UseVisualStyleBackColor = true;
            this.button2oP1.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button2o34
            // 
            this.button2o34.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button2o34.Image = ((System.Drawing.Image)(resources.GetObject("button2o34.Image")));
            this.button2o34.Location = new System.Drawing.Point(3042, 3166);
            this.button2o34.Name = "button2o34";
            this.button2o34.Size = new System.Drawing.Size(38, 38);
            this.button2o34.TabIndex = 13;
            this.button2o34.Text = "39";
            this.button2o34.UseVisualStyleBackColor = true;
            this.button2o34.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button2o25
            // 
            this.button2o25.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button2o25.Image = ((System.Drawing.Image)(resources.GetObject("button2o25.Image")));
            this.button2o25.Location = new System.Drawing.Point(2946, 3022);
            this.button2o25.Name = "button2o25";
            this.button2o25.Size = new System.Drawing.Size(38, 38);
            this.button2o25.TabIndex = 12;
            this.button2o25.Text = "25";
            this.button2o25.UseVisualStyleBackColor = true;
            this.button2o25.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button2o9
            // 
            this.button2o9.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button2o9.Image = ((System.Drawing.Image)(resources.GetObject("button2o9.Image")));
            this.button2o9.Location = new System.Drawing.Point(2730, 3382);
            this.button2o9.Name = "button2o9";
            this.button2o9.Size = new System.Drawing.Size(38, 38);
            this.button2o9.TabIndex = 11;
            this.button2o9.Text = "17";
            this.button2o9.UseVisualStyleBackColor = true;
            this.button2o9.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button2o7
            // 
            this.button2o7.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button2o7.Image = ((System.Drawing.Image)(resources.GetObject("button2o7.Image")));
            this.button2o7.Location = new System.Drawing.Point(2802, 3166);
            this.button2o7.Name = "button2o7";
            this.button2o7.Size = new System.Drawing.Size(38, 38);
            this.button2o7.TabIndex = 10;
            this.button2o7.Text = "21";
            this.button2o7.UseVisualStyleBackColor = true;
            this.button2o7.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button2o6
            // 
            this.button2o6.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button2o6.Image = ((System.Drawing.Image)(resources.GetObject("button2o6.Image")));
            this.button2o6.Location = new System.Drawing.Point(2538, 3216);
            this.button2o6.Name = "button2o6";
            this.button2o6.Size = new System.Drawing.Size(38, 38);
            this.button2o6.TabIndex = 9;
            this.button2o6.Text = "20";
            this.button2o6.UseVisualStyleBackColor = true;
            this.button2o6.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button2o8
            // 
            this.button2o8.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button2o8.Image = ((System.Drawing.Image)(resources.GetObject("button2o8.Image")));
            this.button2o8.Location = new System.Drawing.Point(2515, 3382);
            this.button2o8.Name = "button2o8";
            this.button2o8.Size = new System.Drawing.Size(38, 38);
            this.button2o8.TabIndex = 8;
            this.button2o8.Text = "16";
            this.button2o8.UseVisualStyleBackColor = true;
            this.button2o8.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button2o10
            // 
            this.button2o10.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button2o10.Image = ((System.Drawing.Image)(resources.GetObject("button2o10.Image")));
            this.button2o10.Location = new System.Drawing.Point(2490, 3022);
            this.button2o10.Name = "button2o10";
            this.button2o10.Size = new System.Drawing.Size(38, 38);
            this.button2o10.TabIndex = 7;
            this.button2o10.Text = "12";
            this.button2o10.UseVisualStyleBackColor = true;
            this.button2o10.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button2o5
            // 
            this.button2o5.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button2o5.Image = ((System.Drawing.Image)(resources.GetObject("button2o5.Image")));
            this.button2o5.Location = new System.Drawing.Point(2345, 3214);
            this.button2o5.Name = "button2o5";
            this.button2o5.Size = new System.Drawing.Size(38, 38);
            this.button2o5.TabIndex = 6;
            this.button2o5.Text = "10";
            this.button2o5.UseVisualStyleBackColor = true;
            this.button2o5.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button2o99
            // 
            this.button2o99.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button2o99.Image = ((System.Drawing.Image)(resources.GetObject("button2o99.Image")));
            this.button2o99.Location = new System.Drawing.Point(2274, 3622);
            this.button2o99.Name = "button2o99";
            this.button2o99.Size = new System.Drawing.Size(38, 38);
            this.button2o99.TabIndex = 5;
            this.button2o99.Text = "0";
            this.button2o99.UseVisualStyleBackColor = true;
            this.button2o99.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button2o1
            // 
            this.button2o1.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button2o1.Image = ((System.Drawing.Image)(resources.GetObject("button2o1.Image")));
            this.button2o1.Location = new System.Drawing.Point(2106, 3526);
            this.button2o1.Name = "button2o1";
            this.button2o1.Size = new System.Drawing.Size(38, 38);
            this.button2o1.TabIndex = 4;
            this.button2o1.Text = "4";
            this.button2o1.UseVisualStyleBackColor = true;
            this.button2o1.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // fullmapPictureBox
            // 
            this.fullmapPictureBox.Image = global::NewerTanooki.Properties.Resources.Fullmap;
            this.fullmapPictureBox.Location = new System.Drawing.Point(3, 3);
            this.fullmapPictureBox.Name = "fullmapPictureBox";
            this.fullmapPictureBox.Size = new System.Drawing.Size(3727, 4753);
            this.fullmapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fullmapPictureBox.TabIndex = 0;
            this.fullmapPictureBox.TabStop = false;
            // 
            // sewerTabPage
            // 
            this.sewerTabPage.Controls.Add(this.sewerPanel);
            this.sewerTabPage.Location = new System.Drawing.Point(4, 22);
            this.sewerTabPage.Name = "sewerTabPage";
            this.sewerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.sewerTabPage.Size = new System.Drawing.Size(994, 576);
            this.sewerTabPage.TabIndex = 2;
            this.sewerTabPage.Text = "Sewer";
            this.sewerTabPage.UseVisualStyleBackColor = true;
            // 
            // sewerPanel
            // 
            this.sewerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sewerPanel.AutoScroll = true;
            this.sewerPanel.Controls.Add(this.button2oP3);
            this.sewerPanel.Controls.Add(this.button2o33);
            this.sewerPanel.Controls.Add(this.button2o15);
            this.sewerPanel.Controls.Add(this.button2o4);
            this.sewerPanel.Controls.Add(this.button2o3);
            this.sewerPanel.Controls.Add(this.button2o2);
            this.sewerPanel.Controls.Add(this.sewerPictureBox);
            this.sewerPanel.Location = new System.Drawing.Point(3, 3);
            this.sewerPanel.Name = "sewerPanel";
            this.sewerPanel.Size = new System.Drawing.Size(988, 570);
            this.sewerPanel.TabIndex = 0;
            // 
            // button2oP3
            // 
            this.button2oP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button2oP3.Image = ((System.Drawing.Image)(resources.GetObject("button2oP3.Image")));
            this.button2oP3.Location = new System.Drawing.Point(1713, 1425);
            this.button2oP3.Name = "button2oP3";
            this.button2oP3.Size = new System.Drawing.Size(38, 38);
            this.button2oP3.TabIndex = 39;
            this.button2oP3.Text = "8";
            this.button2oP3.UseVisualStyleBackColor = true;
            this.button2oP3.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button2o33
            // 
            this.button2o33.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button2o33.Image = ((System.Drawing.Image)(resources.GetObject("button2o33.Image")));
            this.button2o33.Location = new System.Drawing.Point(3874, 2361);
            this.button2o33.Name = "button2o33";
            this.button2o33.Size = new System.Drawing.Size(38, 38);
            this.button2o33.TabIndex = 38;
            this.button2o33.Text = "32";
            this.button2o33.UseVisualStyleBackColor = true;
            this.button2o33.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button2o15
            // 
            this.button2o15.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button2o15.Image = ((System.Drawing.Image)(resources.GetObject("button2o15.Image")));
            this.button2o15.Location = new System.Drawing.Point(1594, 1065);
            this.button2o15.Name = "button2o15";
            this.button2o15.Size = new System.Drawing.Size(38, 38);
            this.button2o15.TabIndex = 37;
            this.button2o15.Text = "23";
            this.button2o15.UseVisualStyleBackColor = true;
            this.button2o15.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button2o4
            // 
            this.button2o4.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button2o4.Image = ((System.Drawing.Image)(resources.GetObject("button2o4.Image")));
            this.button2o4.Location = new System.Drawing.Point(1858, 1569);
            this.button2o4.Name = "button2o4";
            this.button2o4.Size = new System.Drawing.Size(38, 38);
            this.button2o4.TabIndex = 36;
            this.button2o4.Text = "4";
            this.button2o4.UseVisualStyleBackColor = true;
            this.button2o4.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button2o3
            // 
            this.button2o3.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button2o3.Image = ((System.Drawing.Image)(resources.GetObject("button2o3.Image")));
            this.button2o3.Location = new System.Drawing.Point(1594, 1569);
            this.button2o3.Name = "button2o3";
            this.button2o3.Size = new System.Drawing.Size(38, 38);
            this.button2o3.TabIndex = 35;
            this.button2o3.Text = "5";
            this.button2o3.UseVisualStyleBackColor = true;
            this.button2o3.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // button2o2
            // 
            this.button2o2.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.01F);
            this.button2o2.Image = ((System.Drawing.Image)(resources.GetObject("button2o2.Image")));
            this.button2o2.Location = new System.Drawing.Point(1714, 1713);
            this.button2o2.Name = "button2o2";
            this.button2o2.Size = new System.Drawing.Size(38, 38);
            this.button2o2.TabIndex = 34;
            this.button2o2.Text = "1";
            this.button2o2.UseVisualStyleBackColor = true;
            this.button2o2.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // sewerPictureBox
            // 
            this.sewerPictureBox.Image = global::NewerTanooki.Properties.Resources.Sewer;
            this.sewerPictureBox.Location = new System.Drawing.Point(3, 3);
            this.sewerPictureBox.Name = "sewerPictureBox";
            this.sewerPictureBox.Size = new System.Drawing.Size(5140, 3028);
            this.sewerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sewerPictureBox.TabIndex = 0;
            this.sewerPictureBox.TabStop = false;
            // 
            // NodeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1026, 641);
            this.Controls.Add(this.nodeTabControl);
            this.Controls.Add(this.nodeMenuStrip);
            this.MainMenuStrip = this.nodeMenuStrip;
            this.MinimizeBox = false;
            this.Name = "NodeSelector";
            this.ShowIcon = false;
            this.Text = "Node Selector";
            this.Load += new System.EventHandler(this.NodeSelector_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NodeSelector_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.yoshiPictureBox)).EndInit();
            this.yoshiPanel.ResumeLayout(false);
            this.yoshiPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marioPictureBox)).EndInit();
            this.nodeMenuStrip.ResumeLayout(false);
            this.nodeMenuStrip.PerformLayout();
            this.nodeTabControl.ResumeLayout(false);
            this.yoshiTabPage.ResumeLayout(false);
            this.fullmapTabPage.ResumeLayout(false);
            this.fullmapPanel.ResumeLayout(false);
            this.fullmapPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullmapPictureBox)).EndInit();
            this.sewerTabPage.ResumeLayout(false);
            this.sewerPanel.ResumeLayout(false);
            this.sewerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sewerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Panel yoshiPanel;
        private System.Windows.Forms.PictureBox yoshiPictureBox;
        public Button button1o41;
        private Button button1oStart;
        private Button button1o38;
        private Button button1o25;
        private Button button1o33;
        private Button button1o31;
        private Button button1oP5;
        private Button button1o7;
        private Button button1oP4;
        private Button button1o8;
        private Button button1oP3;
        private Button button1o6;
        private Button button1o5;
        private Button button1oP2;
        private Button button1o15;
        private Button button1o3;
        private Button button1oP1;
        private Button button1o4;
        private Button button1o99;
        private Button button1o2;
        private Button button1o1;
        private PictureBox marioPictureBox;
        private MenuStrip nodeMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem doneToolStripMenuItem;
        private TabControl nodeTabControl;
        private TabPage yoshiTabPage;
        private TabPage fullmapTabPage;
        private Panel fullmapPanel;
        private PictureBox fullmapPictureBox;
        private Button button3o1;
        private Button button2o38;
        private Button button2oP2;
        private Button button2oP1;
        private Button button2o34;
        private Button button2o25;
        private Button button2o9;
        private Button button2o7;
        private Button button2o6;
        private Button button2o8;
        private Button button2o10;
        private Button button2o5;
        private Button button2o99;
        private Button button2o1;
        private Button button3o2;
        private Button button3o3;
        private Button button3o15;
        private Button button3o4;
        private Button button3o7;
        private Button button3oP3;
        private Button button3o5;
        private Button button3oP2;
        private Button button3o33;
        private Button button3oP1;
        private Button button3o99;
        private Button button3o6;
        private Button button3o34;
        private Button button3o38;
        private Button button3o25;
        private Button button6o1;
        private Button button6o34;
        private Button button6o9;
        private Button button6o38;
        private Button button6o8;
        private Button button6o25;
        private Button button6o6;
        private Button button6o5;
        private Button button6o4;
        private Button button6o15;
        private Button button6o99;
        private Button button6o33;
        private Button button6oP1;
        private Button button6o7;
        private Button button6o3;
        private Button button6o2;
        private Button button7o3;
        private Button button7o2;
        private Button button7o1;
        private Button button10o18;
        private Button button10o17;
        private Button button10o16;
        private TabPage sewerTabPage;
        private Panel sewerPanel;
        private PictureBox sewerPictureBox;
        private Button button2o33;
        private Button button2o15;
        private Button button2o4;
        private Button button2o3;
        private Button button2o2;
        private Button button2oP3;
    }
}