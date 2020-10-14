namespace Gen3TIDSIDFrameFinder
{
	partial class FrameFinder
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
			if(disposing && (components != null))
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
            this.findFrameButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._DataGridView1 = new Gen3TIDSIDFrameFinder.Controls._DataGridView(this.components);
            this.Frame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.frameOffsetTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.adjustedFrameTextBox = new System.Windows.Forms.TextBox();
            this.attemptedFrameTextBox = new Gen3TIDSIDFrameFinder.Controls._MaskedTextBox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.acquiredSidTextBox = new Gen3TIDSIDFrameFinder.Controls._MaskedTextBox(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.adjustFrameButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tidTextBox = new Gen3TIDSIDFrameFinder.Controls._MaskedTextBox(this.components);
            this.prngTextBox = new Gen3TIDSIDFrameFinder.Controls._MaskedTextBox(this.components);
            this.maxFrameTextBox = new Gen3TIDSIDFrameFinder.Controls._MaskedTextBox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.minFrameTextBox = new Gen3TIDSIDFrameFinder.Controls._MaskedTextBox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pidTextBox = new Gen3TIDSIDFrameFinder.Controls._MaskedTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Frlg_e_tab = new System.Windows.Forms.TabPage();
            this.Xd_colo_tab = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.maxResultsTextBox = new Gen3TIDSIDFrameFinder.Controls._MaskedTextBox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.pidCheckBox = new System.Windows.Forms.CheckBox();
            this.sidCheckBox = new System.Windows.Forms.CheckBox();
            this.pidTextBox2 = new Gen3TIDSIDFrameFinder.Controls._MaskedTextBox(this.components);
            this.sidTextBox = new Gen3TIDSIDFrameFinder.Controls._MaskedTextBox(this.components);
            this.tidTextBox2 = new Gen3TIDSIDFrameFinder.Controls._MaskedTextBox(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this._DataGridView2 = new Gen3TIDSIDFrameFinder.Controls._DataGridView(this.components);
            this.seedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sidColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findSeedButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._DataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Frlg_e_tab.SuspendLayout();
            this.Xd_colo_tab.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._DataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // findFrameButton
            // 
            this.findFrameButton.Location = new System.Drawing.Point(6, 283);
            this.findFrameButton.Name = "findFrameButton";
            this.findFrameButton.Size = new System.Drawing.Size(140, 23);
            this.findFrameButton.TabIndex = 0;
            this.findFrameButton.Text = "Find Frame To Hit";
            this.findFrameButton.UseVisualStyleBackColor = true;
            this.findFrameButton.Click += new System.EventHandler(this.OnFindFrameClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._DataGridView1);
            this.groupBox1.Controls.Add(this.findFrameButton);
            this.groupBox1.Location = new System.Drawing.Point(223, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 311);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frame Finder";
            // 
            // _DataGridView1
            // 
            this._DataGridView1.AllowUserToAddRows = false;
            this._DataGridView1.AllowUserToDeleteRows = false;
            this._DataGridView1.AllowUserToResizeColumns = false;
            this._DataGridView1.AllowUserToResizeRows = false;
            this._DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Frame,
            this.SID});
            this._DataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this._DataGridView1.Location = new System.Drawing.Point(6, 20);
            this._DataGridView1.MultiSelect = false;
            this._DataGridView1.Name = "_DataGridView1";
            this._DataGridView1.ReadOnly = true;
            this._DataGridView1.RowHeadersVisible = false;
            this._DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._DataGridView1.Size = new System.Drawing.Size(140, 257);
            this._DataGridView1.TabIndex = 10;
            this._DataGridView1.TabStop = false;
            // 
            // Frame
            // 
            this.Frame.HeaderText = "Frame";
            this.Frame.Name = "Frame";
            this.Frame.ReadOnly = true;
            this.Frame.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SID
            // 
            this.SID.HeaderText = "SID";
            this.SID.Name = "SID";
            this.SID.ReadOnly = true;
            this.SID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 26);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.frameOffsetTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.adjustedFrameTextBox);
            this.groupBox2.Controls.Add(this.attemptedFrameTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.acquiredSidTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.adjustFrameButton);
            this.groupBox2.Location = new System.Drawing.Point(6, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 157);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Frame Correction";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Frame Offset";
            // 
            // frameOffsetTextBox
            // 
            this.frameOffsetTextBox.Location = new System.Drawing.Point(98, 103);
            this.frameOffsetTextBox.Name = "frameOffsetTextBox";
            this.frameOffsetTextBox.ReadOnly = true;
            this.frameOffsetTextBox.Size = new System.Drawing.Size(100, 20);
            this.frameOffsetTextBox.TabIndex = 38;
            this.frameOffsetTextBox.TabStop = false;
            this.frameOffsetTextBox.DoubleClick += new System.EventHandler(this.adjustedFrameTextBox_DoubleClick);
            this.frameOffsetTextBox.Enter += new System.EventHandler(this.frameOffsetTextBox_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Use This Instead";
            // 
            // adjustedFrameTextBox
            // 
            this.adjustedFrameTextBox.Location = new System.Drawing.Point(98, 129);
            this.adjustedFrameTextBox.Name = "adjustedFrameTextBox";
            this.adjustedFrameTextBox.ReadOnly = true;
            this.adjustedFrameTextBox.Size = new System.Drawing.Size(100, 20);
            this.adjustedFrameTextBox.TabIndex = 39;
            this.adjustedFrameTextBox.TabStop = false;
            this.adjustedFrameTextBox.DoubleClick += new System.EventHandler(this.adjustedFrameTextBox_DoubleClick);
            this.adjustedFrameTextBox.Enter += new System.EventHandler(this.frameOffsetTextBox_Enter);
            // 
            // attemptedFrameTextBox
            // 
            this.attemptedFrameTextBox.Location = new System.Drawing.Point(98, 18);
            this.attemptedFrameTextBox.Mask = "AAAAAAAA";
            this.attemptedFrameTextBox.Name = "attemptedFrameTextBox";
            this.attemptedFrameTextBox.Size = new System.Drawing.Size(100, 20);
            this.attemptedFrameTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Attempted Frame";
            // 
            // acquiredSidTextBox
            // 
            this.acquiredSidTextBox.Location = new System.Drawing.Point(98, 43);
            this.acquiredSidTextBox.Mask = "AAAAAAAA";
            this.acquiredSidTextBox.Name = "acquiredSidTextBox";
            this.acquiredSidTextBox.Size = new System.Drawing.Size(100, 20);
            this.acquiredSidTextBox.TabIndex = 2;
            this.acquiredSidTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.acquiredSidTextBox_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Acquired SID";
            // 
            // adjustFrameButton
            // 
            this.adjustFrameButton.Location = new System.Drawing.Point(9, 71);
            this.adjustFrameButton.Name = "adjustFrameButton";
            this.adjustFrameButton.Size = new System.Drawing.Size(186, 23);
            this.adjustFrameButton.TabIndex = 3;
            this.adjustFrameButton.Text = "Adjust Frame";
            this.adjustFrameButton.UseVisualStyleBackColor = true;
            this.adjustFrameButton.Click += new System.EventHandler(this.AdjustFrame_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tidTextBox);
            this.groupBox3.Controls.Add(this.prngTextBox);
            this.groupBox3.Controls.Add(this.maxFrameTextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.minFrameTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.pidTextBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 148);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Config";
            // 
            // tidTextBox
            // 
            this.tidTextBox.Location = new System.Drawing.Point(98, 17);
            this.tidTextBox.Mask = "99999";
            this.tidTextBox.Name = "tidTextBox";
            this.tidTextBox.Size = new System.Drawing.Size(100, 20);
            this.tidTextBox.TabIndex = 1;
            // 
            // prngTextBox
            // 
            this.prngTextBox.Location = new System.Drawing.Point(98, 69);
            this.prngTextBox.Mask = "AAAAAAAA";
            this.prngTextBox.Name = "prngTextBox";
            this.prngTextBox.Size = new System.Drawing.Size(100, 20);
            this.prngTextBox.TabIndex = 3;
            // 
            // maxFrameTextBox
            // 
            this.maxFrameTextBox.Location = new System.Drawing.Point(98, 121);
            this.maxFrameTextBox.Mask = "999999";
            this.maxFrameTextBox.Name = "maxFrameTextBox";
            this.maxFrameTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxFrameTextBox.TabIndex = 5;
            this.maxFrameTextBox.Tag = "";
            this.maxFrameTextBox.Text = "100000";
            this.maxFrameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maxFrameTextBox_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 80;
            this.label6.Text = "Desired PID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // minFrameTextBox
            // 
            this.minFrameTextBox.Location = new System.Drawing.Point(98, 95);
            this.minFrameTextBox.Mask = "999999";
            this.minFrameTextBox.Name = "minFrameTextBox";
            this.minFrameTextBox.Size = new System.Drawing.Size(100, 20);
            this.minFrameTextBox.TabIndex = 4;
            this.minFrameTextBox.Tag = "";
            this.minFrameTextBox.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "TID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Max Results";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "PRNG State";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pidTextBox
            // 
            this.pidTextBox.Location = new System.Drawing.Point(98, 43);
            this.pidTextBox.Mask = "AAAAAAAA";
            this.pidTextBox.Name = "pidTextBox";
            this.pidTextBox.Size = new System.Drawing.Size(100, 20);
            this.pidTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Starting Frame";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Frlg_e_tab);
            this.tabControl1.Controls.Add(this.Xd_colo_tab);
            this.tabControl1.Location = new System.Drawing.Point(5, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(390, 346);
            this.tabControl1.TabIndex = 3;
            // 
            // Frlg_e_tab
            // 
            this.Frlg_e_tab.Controls.Add(this.groupBox3);
            this.Frlg_e_tab.Controls.Add(this.groupBox1);
            this.Frlg_e_tab.Controls.Add(this.groupBox2);
            this.Frlg_e_tab.Location = new System.Drawing.Point(4, 22);
            this.Frlg_e_tab.Name = "Frlg_e_tab";
            this.Frlg_e_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Frlg_e_tab.Size = new System.Drawing.Size(382, 320);
            this.Frlg_e_tab.TabIndex = 0;
            this.Frlg_e_tab.Text = "FRLG/E";
            this.Frlg_e_tab.UseVisualStyleBackColor = true;
            // 
            // Xd_colo_tab
            // 
            this.Xd_colo_tab.Controls.Add(this.groupBox4);
            this.Xd_colo_tab.Controls.Add(this.groupBox5);
            this.Xd_colo_tab.Location = new System.Drawing.Point(4, 22);
            this.Xd_colo_tab.Name = "Xd_colo_tab";
            this.Xd_colo_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Xd_colo_tab.Size = new System.Drawing.Size(382, 320);
            this.Xd_colo_tab.TabIndex = 1;
            this.Xd_colo_tab.Text = "XD/Colo";
            this.Xd_colo_tab.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.maxResultsTextBox);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.pidCheckBox);
            this.groupBox4.Controls.Add(this.sidCheckBox);
            this.groupBox4.Controls.Add(this.pidTextBox2);
            this.groupBox4.Controls.Add(this.sidTextBox);
            this.groupBox4.Controls.Add(this.tidTextBox2);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(211, 131);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Config";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 89;
            this.label11.Text = "Max Results";
            // 
            // maxResultsTextBox
            // 
            this.maxResultsTextBox.Location = new System.Drawing.Point(98, 95);
            this.maxResultsTextBox.Mask = "9999";
            this.maxResultsTextBox.Name = "maxResultsTextBox";
            this.maxResultsTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxResultsTextBox.TabIndex = 88;
            this.maxResultsTextBox.Text = "5";
            this.maxResultsTextBox.TextChanged += new System.EventHandler(this.maxResultsTextBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 87;
            this.label10.Text = "TID";
            // 
            // pidCheckBox
            // 
            this.pidCheckBox.AutoSize = true;
            this.pidCheckBox.Location = new System.Drawing.Point(6, 71);
            this.pidCheckBox.Name = "pidCheckBox";
            this.pidCheckBox.Size = new System.Drawing.Size(44, 17);
            this.pidCheckBox.TabIndex = 86;
            this.pidCheckBox.Text = "PID";
            this.pidCheckBox.UseVisualStyleBackColor = true;
            this.pidCheckBox.CheckedChanged += new System.EventHandler(this.pidCheckBox_CheckedChanged);
            // 
            // sidCheckBox
            // 
            this.sidCheckBox.AutoSize = true;
            this.sidCheckBox.Location = new System.Drawing.Point(6, 45);
            this.sidCheckBox.Name = "sidCheckBox";
            this.sidCheckBox.Size = new System.Drawing.Size(44, 17);
            this.sidCheckBox.TabIndex = 85;
            this.sidCheckBox.Text = "SID";
            this.sidCheckBox.UseVisualStyleBackColor = true;
            this.sidCheckBox.CheckedChanged += new System.EventHandler(this.sidCheckBox_CheckedChanged);
            // 
            // pidTextBox2
            // 
            this.pidTextBox2.Enabled = false;
            this.pidTextBox2.Location = new System.Drawing.Point(98, 69);
            this.pidTextBox2.Mask = "AAAAAAAA";
            this.pidTextBox2.Name = "pidTextBox2";
            this.pidTextBox2.Size = new System.Drawing.Size(100, 20);
            this.pidTextBox2.TabIndex = 83;
            // 
            // sidTextBox
            // 
            this.sidTextBox.Enabled = false;
            this.sidTextBox.Location = new System.Drawing.Point(98, 43);
            this.sidTextBox.Mask = "99999";
            this.sidTextBox.Name = "sidTextBox";
            this.sidTextBox.Size = new System.Drawing.Size(100, 20);
            this.sidTextBox.TabIndex = 81;
            // 
            // tidTextBox2
            // 
            this.tidTextBox2.Location = new System.Drawing.Point(98, 17);
            this.tidTextBox2.Mask = "99999";
            this.tidTextBox2.Name = "tidTextBox2";
            this.tidTextBox2.Size = new System.Drawing.Size(100, 20);
            this.tidTextBox2.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this._DataGridView2);
            this.groupBox5.Controls.Add(this.findSeedButton);
            this.groupBox5.Location = new System.Drawing.Point(223, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(156, 311);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Seed Finder";
            // 
            // _DataGridView2
            // 
            this._DataGridView2.AllowUserToAddRows = false;
            this._DataGridView2.AllowUserToDeleteRows = false;
            this._DataGridView2.AllowUserToResizeColumns = false;
            this._DataGridView2.AllowUserToResizeRows = false;
            this._DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._DataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seedColumn,
            this.sidColumn});
            this._DataGridView2.ContextMenuStrip = this.contextMenuStrip1;
            this._DataGridView2.Location = new System.Drawing.Point(6, 20);
            this._DataGridView2.MultiSelect = false;
            this._DataGridView2.Name = "_DataGridView2";
            this._DataGridView2.ReadOnly = true;
            this._DataGridView2.RowHeadersVisible = false;
            this._DataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._DataGridView2.Size = new System.Drawing.Size(140, 257);
            this._DataGridView2.TabIndex = 10;
            this._DataGridView2.TabStop = false;
            // 
            // seedColumn
            // 
            this.seedColumn.HeaderText = "Seed";
            this.seedColumn.Name = "seedColumn";
            this.seedColumn.ReadOnly = true;
            this.seedColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // sidColumn
            // 
            this.sidColumn.HeaderText = "SID";
            this.sidColumn.Name = "sidColumn";
            this.sidColumn.ReadOnly = true;
            // 
            // findSeedButton
            // 
            this.findSeedButton.Location = new System.Drawing.Point(6, 283);
            this.findSeedButton.Name = "findSeedButton";
            this.findSeedButton.Size = new System.Drawing.Size(140, 23);
            this.findSeedButton.TabIndex = 0;
            this.findSeedButton.Text = "Find Seed";
            this.findSeedButton.UseVisualStyleBackColor = true;
            this.findSeedButton.Click += new System.EventHandler(this.findSeedButton_Click);
            // 
            // FrameFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 351);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrameFinder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gen 3 TID/SID Frame Finder";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._DataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Frlg_e_tab.ResumeLayout(false);
            this.Xd_colo_tab.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._DataGridView2)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button findFrameButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button adjustFrameButton;
		private System.Windows.Forms.GroupBox groupBox3;
        public Controls._MaskedTextBox prngTextBox;
        public Controls._MaskedTextBox maxFrameTextBox;
        private System.Windows.Forms.Label label6;
        public Controls._MaskedTextBox minFrameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public Controls._MaskedTextBox pidTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private Controls._DataGridView _DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frame;
        private System.Windows.Forms.DataGridViewTextBoxColumn SID;
        public Controls._MaskedTextBox acquiredSidTextBox;
        private System.Windows.Forms.Label label7;
        public Controls._MaskedTextBox attemptedFrameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox frameOffsetTextBox;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox adjustedFrameTextBox;
        private Controls._MaskedTextBox tidTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Frlg_e_tab;
        private System.Windows.Forms.TabPage Xd_colo_tab;
        private System.Windows.Forms.GroupBox groupBox4;
        private Controls._MaskedTextBox sidTextBox;
        private Controls._MaskedTextBox tidTextBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private Controls._DataGridView _DataGridView2;
        private System.Windows.Forms.Button findSeedButton;
        private System.Windows.Forms.CheckBox pidCheckBox;
        private System.Windows.Forms.CheckBox sidCheckBox;
        public Controls._MaskedTextBox pidTextBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Controls._MaskedTextBox maxResultsTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn seedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidColumn;
    }
}

