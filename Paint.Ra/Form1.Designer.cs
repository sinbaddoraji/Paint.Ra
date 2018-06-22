using System.ComponentModel;
using System.Windows.Forms;

namespace Paint.Ra
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.usualSizes = new System.Windows.Forms.ColorDialog();
            this.b = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.sizes = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bookmarkPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarkXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarkYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearXBookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearYBookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.canvas1 = new Paint.Ra.Canvas();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(890, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(49, 28);
            this.panel1.TabIndex = 4;
            this.panel1.BackColorChanged += new System.EventHandler(this.panel1_BackColorChanged);
            this.panel1.Click += new System.EventHandler(this.ColourBPick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 28);
            this.panel2.TabIndex = 0;
            this.panel2.BackColorChanged += new System.EventHandler(this.panel2_BackColorChanged);
            this.panel2.Click += new System.EventHandler(this.ColourAPick);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(78, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(76, 46);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(699, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Size:";
            // 
            // sizes
            // 
            this.sizes.FormattingEnabled = true;
            this.sizes.Location = new System.Drawing.Point(748, 7);
            this.sizes.Name = "sizes";
            this.sizes.Size = new System.Drawing.Size(57, 21);
            this.sizes.TabIndex = 13;
            this.sizes.Text = "4";
            this.sizes.TextChanged += new System.EventHandler(this.sizes_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.radioButton2);
            this.flowLayoutPanel1.Controls.Add(this.radioButton3);
            this.flowLayoutPanel1.Controls.Add(this.radioButton7);
            this.flowLayoutPanel1.Controls.Add(this.radioButton1);
            this.flowLayoutPanel1.Controls.Add(this.radioButton4);
            this.flowLayoutPanel1.Controls.Add(this.radioButton8);
            this.flowLayoutPanel1.Controls.Add(this.radioButton5);
            this.flowLayoutPanel1.Controls.Add(this.radioButton6);
            this.flowLayoutPanel1.Controls.Add(this.radioButton9);
            this.flowLayoutPanel1.Controls.Add(this.radioButton10);
            this.flowLayoutPanel1.Controls.Add(this.radioButton11);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(53, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(208, 27);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.White;
            this.radioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Image = global::Paint.Ra.Properties.Resources.Brush;
            this.radioButton2.Location = new System.Drawing.Point(3, 3);
            this.radioButton2.MaximumSize = new System.Drawing.Size(24, 24);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(24, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Tag = "Brush Line";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.BrushModeSelect);
            // 
            // radioButton3
            // 
            this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.White;
            this.radioButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Image = global::Paint.Ra.Properties.Resources.Pen;
            this.radioButton3.Location = new System.Drawing.Point(33, 3);
            this.radioButton3.MaximumSize = new System.Drawing.Size(24, 24);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(24, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Tag = "Pen";
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.PenModeSelect);
            // 
            // radioButton7
            // 
            this.radioButton7.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton7.AutoSize = true;
            this.radioButton7.BackColor = System.Drawing.Color.White;
            this.radioButton7.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton7.Image = global::Paint.Ra.Properties.Resources.JL;
            this.radioButton7.Location = new System.Drawing.Point(63, 3);
            this.radioButton7.MaximumSize = new System.Drawing.Size(24, 24);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(24, 24);
            this.radioButton7.TabIndex = 7;
            this.radioButton7.Tag = "Click Line";
            this.radioButton7.UseVisualStyleBackColor = false;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.ClickLineModeSelect);
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.White;
            this.radioButton1.Checked = true;
            this.radioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Image = global::Paint.Ra.Properties.Resources.substract;
            this.radioButton1.Location = new System.Drawing.Point(93, 3);
            this.radioButton1.MaximumSize = new System.Drawing.Size(24, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(24, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "Line";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.LineModeSelect);
            // 
            // radioButton4
            // 
            this.radioButton4.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.Color.White;
            this.radioButton4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton4.Image = global::Paint.Ra.Properties.Resources.Wrap;
            this.radioButton4.Location = new System.Drawing.Point(123, 3);
            this.radioButton4.MaximumSize = new System.Drawing.Size(24, 24);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(24, 24);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Tag = "Wrap";
            this.radioButton4.UseVisualStyleBackColor = false;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.WrapModeSelect);
            // 
            // radioButton8
            // 
            this.radioButton8.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton8.AutoSize = true;
            this.radioButton8.BackColor = System.Drawing.Color.White;
            this.radioButton8.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton8.Image = global::Paint.Ra.Properties.Resources.RAT;
            this.radioButton8.Location = new System.Drawing.Point(153, 3);
            this.radioButton8.MaximumSize = new System.Drawing.Size(24, 24);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(24, 24);
            this.radioButton8.TabIndex = 8;
            this.radioButton8.Tag = "Right Angled Triangle";
            this.radioButton8.UseVisualStyleBackColor = false;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.RightAngledTriangleModeSelect);
            // 
            // radioButton5
            // 
            this.radioButton5.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton5.AutoSize = true;
            this.radioButton5.BackColor = System.Drawing.Color.White;
            this.radioButton5.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton5.Image = global::Paint.Ra.Properties.Resources.rect;
            this.radioButton5.Location = new System.Drawing.Point(3, 33);
            this.radioButton5.MaximumSize = new System.Drawing.Size(24, 24);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(24, 24);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.Tag = "Rectangle";
            this.radioButton5.UseVisualStyleBackColor = false;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.RectangleModeSelect);
            // 
            // radioButton6
            // 
            this.radioButton6.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton6.AutoSize = true;
            this.radioButton6.BackColor = System.Drawing.Color.White;
            this.radioButton6.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton6.Image = global::Paint.Ra.Properties.Resources.circ;
            this.radioButton6.Location = new System.Drawing.Point(33, 33);
            this.radioButton6.MaximumSize = new System.Drawing.Size(24, 24);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(24, 24);
            this.radioButton6.TabIndex = 6;
            this.radioButton6.UseVisualStyleBackColor = false;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.ElipseModeSelect);
            // 
            // radioButton9
            // 
            this.radioButton9.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton9.AutoSize = true;
            this.radioButton9.BackColor = System.Drawing.Color.White;
            this.radioButton9.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton9.Image = global::Paint.Ra.Properties.Resources.T;
            this.radioButton9.Location = new System.Drawing.Point(63, 33);
            this.radioButton9.MaximumSize = new System.Drawing.Size(24, 24);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(24, 24);
            this.radioButton9.TabIndex = 9;
            this.radioButton9.Tag = "Triangle";
            this.radioButton9.UseVisualStyleBackColor = false;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.TriangleModeSelect);
            // 
            // radioButton10
            // 
            this.radioButton10.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton10.AutoSize = true;
            this.radioButton10.BackColor = System.Drawing.Color.White;
            this.radioButton10.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton10.Image = global::Paint.Ra.Properties.Resources.Diamond;
            this.radioButton10.Location = new System.Drawing.Point(93, 33);
            this.radioButton10.MaximumSize = new System.Drawing.Size(24, 24);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(24, 24);
            this.radioButton10.TabIndex = 10;
            this.radioButton10.Tag = "Triangle";
            this.radioButton10.UseVisualStyleBackColor = false;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // radioButton11
            // 
            this.radioButton11.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton11.AutoSize = true;
            this.radioButton11.BackColor = System.Drawing.Color.White;
            this.radioButton11.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton11.Image = global::Paint.Ra.Properties.Resources.Font_Name_icon;
            this.radioButton11.Location = new System.Drawing.Point(123, 33);
            this.radioButton11.MaximumSize = new System.Drawing.Size(24, 24);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(24, 24);
            this.radioButton11.TabIndex = 11;
            this.radioButton11.Tag = "Triangle";
            this.radioButton11.UseVisualStyleBackColor = false;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AnchorMask",
            "ArrowAnchor",
            "DiamondAnchor",
            "Flat",
            "NoAnchor",
            "Round",
            "RoundAnchor",
            "Square",
            "SquareAnchor",
            "Triangle"});
            this.comboBox1.Location = new System.Drawing.Point(59, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "Flat";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Line Start:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Line End:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "AnchorMask",
            "ArrowAnchor",
            "DiamondAnchor",
            "Flat",
            "NoAnchor",
            "Round",
            "RoundAnchor",
            "Square",
            "SquareAnchor",
            "Triangle"});
            this.comboBox2.Location = new System.Drawing.Point(232, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(109, 21);
            this.comboBox2.TabIndex = 18;
            this.comboBox2.Text = "Flat";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(-2, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(52, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.saveAsToolStripMenuItem.Text = "SaveAs";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Text";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 586);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(951, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(22, 17);
            this.toolStripStatusLabel1.Text = "0,0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(19, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(913, 18);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::Paint.Ra.Properties.Resources.Font_Name_icon;
            this.button5.Location = new System.Drawing.Point(297, 7);
            this.button5.MaximumSize = new System.Drawing.Size(24, 24);
            this.button5.MinimumSize = new System.Drawing.Size(24, 24);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(24, 24);
            this.button5.TabIndex = 23;
            this.button5.Tag = "Set Font";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::Paint.Ra.Properties.Resources.Minus;
            this.button4.Location = new System.Drawing.Point(733, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(13, 15);
            this.button4.TabIndex = 21;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Paint.Ra.Properties.Resources.Pls;
            this.button3.Location = new System.Drawing.Point(807, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(13, 15);
            this.button3.TabIndex = 20;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Image = global::Paint.Ra.Properties.Resources.Fill;
            this.checkBox1.Location = new System.Drawing.Point(267, 7);
            this.checkBox1.MaximumSize = new System.Drawing.Size(24, 24);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(24, 24);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Tag = "Fill";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Paint.Ra.Properties.Resources.Redo;
            this.button2.Location = new System.Drawing.Point(849, 4);
            this.button2.MaximumSize = new System.Drawing.Size(24, 24);
            this.button2.MinimumSize = new System.Drawing.Size(24, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 24);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Redo);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Paint.Ra.Properties.Resources.Undo;
            this.button1.Location = new System.Drawing.Point(825, 4);
            this.button1.MaximumSize = new System.Drawing.Size(24, 24);
            this.button1.MinimumSize = new System.Drawing.Size(24, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Undo);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookmarkPointToolStripMenuItem,
            this.bookmarkXToolStripMenuItem,
            this.bookmarkYToolStripMenuItem,
            this.clearXBookmarksToolStripMenuItem,
            this.clearYBookmarksToolStripMenuItem,
            this.clearAllPointsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 136);
            // 
            // bookmarkPointToolStripMenuItem
            // 
            this.bookmarkPointToolStripMenuItem.Name = "bookmarkPointToolStripMenuItem";
            this.bookmarkPointToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.bookmarkPointToolStripMenuItem.Text = "Bookmark Point";
            this.bookmarkPointToolStripMenuItem.Click += new System.EventHandler(this.bookmarkPointToolStripMenuItem_Click);
            // 
            // bookmarkXToolStripMenuItem
            // 
            this.bookmarkXToolStripMenuItem.Name = "bookmarkXToolStripMenuItem";
            this.bookmarkXToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.bookmarkXToolStripMenuItem.Text = "Bookmark X";
            this.bookmarkXToolStripMenuItem.Click += new System.EventHandler(this.bookmarkXToolStripMenuItem_Click);
            // 
            // bookmarkYToolStripMenuItem
            // 
            this.bookmarkYToolStripMenuItem.Name = "bookmarkYToolStripMenuItem";
            this.bookmarkYToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.bookmarkYToolStripMenuItem.Text = "Bookmark Y";
            this.bookmarkYToolStripMenuItem.Click += new System.EventHandler(this.bookmarkYToolStripMenuItem_Click);
            // 
            // clearXBookmarksToolStripMenuItem
            // 
            this.clearXBookmarksToolStripMenuItem.Name = "clearXBookmarksToolStripMenuItem";
            this.clearXBookmarksToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.clearXBookmarksToolStripMenuItem.Text = "Clear X Bookmarks";
            this.clearXBookmarksToolStripMenuItem.Click += new System.EventHandler(this.clearXBookmarksToolStripMenuItem_Click);
            // 
            // clearYBookmarksToolStripMenuItem
            // 
            this.clearYBookmarksToolStripMenuItem.Name = "clearYBookmarksToolStripMenuItem";
            this.clearYBookmarksToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.clearYBookmarksToolStripMenuItem.Text = "Clear Y Bookmarks";
            this.clearYBookmarksToolStripMenuItem.Click += new System.EventHandler(this.clearYBookmarksToolStripMenuItem_Click);
            // 
            // clearAllPointsToolStripMenuItem
            // 
            this.clearAllPointsToolStripMenuItem.Name = "clearAllPointsToolStripMenuItem";
            this.clearAllPointsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.clearAllPointsToolStripMenuItem.Text = "Clear All Point";
            this.clearAllPointsToolStripMenuItem.Click += new System.EventHandler(this.clearAllPointsToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(0, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 508);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(19, 565);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(913, 18);
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox3_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(933, 55);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(18, 508);
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox4_Paint);
            // 
            // canvas1
            // 
            this.canvas1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvas1.BackColor = System.Drawing.Color.White;
            this.canvas1.ContextMenuStrip = this.contextMenuStrip1;
            this.canvas1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.canvas1.Image = ((System.Drawing.Image)(resources.GetObject("canvas1.Image")));
            this.canvas1.Location = new System.Drawing.Point(19, 55);
            this.canvas1.Name = "canvas1";
            this.canvas1.Size = new System.Drawing.Size(913, 508);
            this.canvas1.TabIndex = 0;
            this.canvas1.TabStop = false;
            this.canvas1.SizeModeChanged += new Paint.Ra.Canvas.Smc(this.canvas1_SizeModeChanged_1);
            this.canvas1.Click += new System.EventHandler(this.canvas1_Click);
            this.canvas1.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas1_Paint);
            this.canvas1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas1_MouseDown);
            this.canvas1.MouseLeave += new System.EventHandler(this.canvas1_MouseLeave);
            this.canvas1.MouseHover += new System.EventHandler(this.canvas1_MouseHover);
            this.canvas1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas1_MouseMove);
            this.canvas1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas1_MouseUp);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Location = new System.Drawing.Point(321, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(361, 28);
            this.panel4.TabIndex = 32;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.comboBox2);
            this.panel5.Controls.Add(this.comboBox1);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(323, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(360, 27);
            this.panel5.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 608);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.canvas1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.sizes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(967, 647);
            this.MinimumSize = new System.Drawing.Size(967, 647);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Canvas canvas1;
        private Button button1;
        private Timer timer1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton4;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ColorDialog usualSizes;
        private ColorDialog b;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private Label label2;
        private ComboBox sizes;
        private CheckBox checkBox1;
        private RadioButton radioButton8;
        private RadioButton radioButton9;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton radioButton10;
        private ComboBox comboBox1;
        private Label label1;
        private Label label3;
        private ComboBox comboBox2;
        private Button button3;
        private Button button4;
        private RadioButton radioButton3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private RadioButton radioButton11;
        private Button button5;
        private TextBox textBox1;
        private FontDialog fontDialog1;
        private Label label4;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem bookmarkXToolStripMenuItem;
        private ToolStripMenuItem bookmarkYToolStripMenuItem;
        private ToolStripMenuItem clearXBookmarksToolStripMenuItem;
        private ToolStripMenuItem clearYBookmarksToolStripMenuItem;
        private PictureBox pictureBox2;
        private ToolStripMenuItem bookmarkPointToolStripMenuItem;
        private ToolStripMenuItem clearAllPointsToolStripMenuItem;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel panel4;
        private Panel panel5;
    }
}

