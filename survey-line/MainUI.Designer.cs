/*
 * Created by SharpDevelop.
 * User: SamsungNC108
 * Date: 2/13/2014
 * Time: 10:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System.Windows.Forms;

namespace SurveyLine
{
	partial class MainUI
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLineName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numEasting = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numNorthing = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numBearing = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numStation = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.cboxMultiMode = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numMultiLineCount = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numMultiLineSpacing = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dropDownDirection = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnMoreSetup = new System.Windows.Forms.Button();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvCoordinates = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCopyAll = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblDistanceName = new System.Windows.Forms.Label();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblBearing = new System.Windows.Forms.Label();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblStations = new System.Windows.Forms.Label();
            this.lblSpacing = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plotCurrentTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.latLongToUTMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shortcutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEasting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNorthing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBearing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStation)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMultiLineCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMultiLineSpacing)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoordinates)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabelAuthor});
            this.statusStrip1.Location = new System.Drawing.Point(0, 447);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(611, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.AutoSize = false;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.toolStripProgressBar1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(85, 17);
            this.toolStripStatusLabel1.Text = "Nothing to do.";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(373, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabelAuthor
            // 
            this.toolStripStatusLabelAuthor.Enabled = false;
            this.toolStripStatusLabelAuthor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelAuthor.IsLink = true;
            this.toolStripStatusLabelAuthor.Name = "toolStripStatusLabelAuthor";
            this.toolStripStatusLabelAuthor.Size = new System.Drawing.Size(138, 17);
            this.toolStripStatusLabelAuthor.Text = "SurveyLine - Adien Akhmad";
            this.toolStripStatusLabelAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel5);
            this.splitContainer1.Size = new System.Drawing.Size(611, 423);
            this.splitContainer1.SplitterDistance = 219;
            this.splitContainer1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(215, 419);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(191, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Line Setup";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label9);
            this.flowLayoutPanel2.Controls.Add(this.txtLineName);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.numEasting);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.numNorthing);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.numBearing);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.numInterval);
            this.flowLayoutPanel2.Controls.Add(this.label8);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.numStation);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(10, 19);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(176, 171);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Name";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLineName
            // 
            this.txtLineName.Location = new System.Drawing.Point(67, 3);
            this.txtLineName.Name = "txtLineName";
            this.txtLineName.Size = new System.Drawing.Size(102, 21);
            this.txtLineName.TabIndex = 6;
            this.txtLineName.Enter += new System.EventHandler(this.txtLineName_Enter);
            this.txtLineName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLineName_KeyDown);
            this.txtLineName.Leave += new System.EventHandler(this.txtLineName_Leave);
            this.txtLineName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtLineName_MouseUp);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Easting";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numEasting
            // 
            this.numEasting.DecimalPlaces = 1;
            this.numEasting.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numEasting.Location = new System.Drawing.Point(67, 30);
            this.numEasting.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numEasting.Name = "numEasting";
            this.numEasting.Size = new System.Drawing.Size(102, 21);
            this.numEasting.TabIndex = 7;
            this.numEasting.Enter += new System.EventHandler(this.NumOnFocus);
            this.numEasting.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLineName_KeyDown);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Northing";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numNorthing
            // 
            this.numNorthing.DecimalPlaces = 1;
            this.numNorthing.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numNorthing.Location = new System.Drawing.Point(67, 57);
            this.numNorthing.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numNorthing.Name = "numNorthing";
            this.numNorthing.Size = new System.Drawing.Size(102, 21);
            this.numNorthing.TabIndex = 8;
            this.numNorthing.Enter += new System.EventHandler(this.NumOnFocus);
            this.numNorthing.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLineName_KeyDown);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bearing";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numBearing
            // 
            this.numBearing.DecimalPlaces = 2;
            this.numBearing.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numBearing.Location = new System.Drawing.Point(67, 84);
            this.numBearing.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numBearing.Name = "numBearing";
            this.numBearing.Size = new System.Drawing.Size(66, 21);
            this.numBearing.TabIndex = 9;
            this.numBearing.Enter += new System.EventHandler(this.NumOnFocus);
            this.numBearing.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLineName_KeyDown);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(139, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "NE";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Interval";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numInterval
            // 
            this.numInterval.DecimalPlaces = 1;
            this.numInterval.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numInterval.Location = new System.Drawing.Point(67, 111);
            this.numInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(66, 21);
            this.numInterval.TabIndex = 10;
            this.numInterval.Enter += new System.EventHandler(this.NumOnFocus);
            this.numInterval.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLineName_KeyDown);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(139, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "m";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Station";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numStation
            // 
            this.numStation.Location = new System.Drawing.Point(67, 138);
            this.numStation.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numStation.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStation.Name = "numStation";
            this.numStation.Size = new System.Drawing.Size(66, 21);
            this.numStation.TabIndex = 11;
            this.numStation.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStation.Enter += new System.EventHandler(this.NumOnFocus);
            this.numStation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLineName_KeyDown);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 23);
            this.label7.TabIndex = 14;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel3);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.groupBox2.Size = new System.Drawing.Size(191, 148);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Multi Line Setup";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.cboxMultiMode);
            this.flowLayoutPanel3.Controls.Add(this.label10);
            this.flowLayoutPanel3.Controls.Add(this.numMultiLineCount);
            this.flowLayoutPanel3.Controls.Add(this.label12);
            this.flowLayoutPanel3.Controls.Add(this.numMultiLineSpacing);
            this.flowLayoutPanel3.Controls.Add(this.label16);
            this.flowLayoutPanel3.Controls.Add(this.label11);
            this.flowLayoutPanel3.Controls.Add(this.dropDownDirection);
            this.flowLayoutPanel3.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(10, 19);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(176, 124);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // cboxMultiMode
            // 
            this.cboxMultiMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboxMultiMode.Location = new System.Drawing.Point(3, 3);
            this.cboxMultiMode.Name = "cboxMultiMode";
            this.cboxMultiMode.Size = new System.Drawing.Size(130, 24);
            this.cboxMultiMode.TabIndex = 0;
            this.cboxMultiMode.TabStop = false;
            this.cboxMultiMode.Text = "Multi Line Mode";
            this.cboxMultiMode.UseVisualStyleBackColor = true;
            this.cboxMultiMode.CheckedChanged += new System.EventHandler(this.cboxMultiMode_CheckedChanged);
            this.cboxMultiMode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLineName_KeyDown);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(3, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "Lines";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numMultiLineCount
            // 
            this.numMultiLineCount.Location = new System.Drawing.Point(67, 33);
            this.numMultiLineCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numMultiLineCount.Name = "numMultiLineCount";
            this.numMultiLineCount.Size = new System.Drawing.Size(66, 21);
            this.numMultiLineCount.TabIndex = 4;
            this.numMultiLineCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numMultiLineCount.Enter += new System.EventHandler(this.NumOnFocus);
            this.numMultiLineCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLineName_KeyDown);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(3, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 23);
            this.label12.TabIndex = 2;
            this.label12.Text = "Spacing";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numMultiLineSpacing
            // 
            this.numMultiLineSpacing.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numMultiLineSpacing.Location = new System.Drawing.Point(67, 60);
            this.numMultiLineSpacing.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMultiLineSpacing.Name = "numMultiLineSpacing";
            this.numMultiLineSpacing.Size = new System.Drawing.Size(66, 21);
            this.numMultiLineSpacing.TabIndex = 5;
            this.numMultiLineSpacing.Enter += new System.EventHandler(this.NumOnFocus);
            this.numMultiLineSpacing.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLineName_KeyDown);
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(139, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 23);
            this.label16.TabIndex = 14;
            this.label16.Text = "m";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(3, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 23);
            this.label11.TabIndex = 3;
            this.label11.Text = "Direction";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dropDownDirection
            // 
            this.dropDownDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownDirection.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.dropDownDirection.FormattingEnabled = true;
            this.dropDownDirection.Items.AddRange(new object[] {
            "to Right",
            "to Left"});
            this.dropDownDirection.Location = new System.Drawing.Point(67, 87);
            this.dropDownDirection.Name = "dropDownDirection";
            this.dropDownDirection.Size = new System.Drawing.Size(66, 21);
            this.dropDownDirection.TabIndex = 6;
            this.dropDownDirection.TabStop = false;
            this.dropDownDirection.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLineName_KeyDown);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.btnCreate);
            this.flowLayoutPanel4.Controls.Add(this.btnMoreSetup);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(13, 368);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(201, 45);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Image = global::SurveyLine.Properties.Resources.CreateTableIco;
            this.btnCreate.Location = new System.Drawing.Point(3, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 31);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnMoreSetup
            // 
            this.btnMoreSetup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoreSetup.Image = global::SurveyLine.Properties.Resources.MoreSetupIco;
            this.btnMoreSetup.Location = new System.Drawing.Point(84, 3);
            this.btnMoreSetup.Name = "btnMoreSetup";
            this.btnMoreSetup.Size = new System.Drawing.Size(92, 31);
            this.btnMoreSetup.TabIndex = 1;
            this.btnMoreSetup.Text = "More Setup";
            this.btnMoreSetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMoreSetup.UseVisualStyleBackColor = true;
            this.btnMoreSetup.Click += new System.EventHandler(this.btnMoreSetup_Click);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.dgvCoordinates);
            this.flowLayoutPanel5.Controls.Add(this.groupBox3);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.flowLayoutPanel5.Size = new System.Drawing.Size(384, 419);
            this.flowLayoutPanel5.TabIndex = 0;
            // 
            // dgvCoordinates
            // 
            this.dgvCoordinates.AllowUserToAddRows = false;
            this.dgvCoordinates.AllowUserToDeleteRows = false;
            this.dgvCoordinates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCoordinates.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCoordinates.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCoordinates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoordinates.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCoordinates.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCoordinates.Location = new System.Drawing.Point(13, 13);
            this.dgvCoordinates.Name = "dgvCoordinates";
            this.dgvCoordinates.ReadOnly = true;
            this.dgvCoordinates.Size = new System.Drawing.Size(361, 327);
            this.dgvCoordinates.TabIndex = 1;
            this.dgvCoordinates.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCoordinates_CellMouseDown);
            this.dgvCoordinates.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCoordinates_DataBindingComplete);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCopy,
            this.toolStripMenuItemCopyAll});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 48);
            // 
            // toolStripMenuItemCopy
            // 
            this.toolStripMenuItemCopy.Name = "toolStripMenuItemCopy";
            this.toolStripMenuItemCopy.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItemCopy.Text = "Copy";
            this.toolStripMenuItemCopy.Click += new System.EventHandler(this.toolStripMenuItemCopy_Click);
            // 
            // toolStripMenuItemCopyAll
            // 
            this.toolStripMenuItemCopyAll.Name = "toolStripMenuItemCopyAll";
            this.toolStripMenuItemCopyAll.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItemCopyAll.Text = "Copy All";
            this.toolStripMenuItemCopyAll.Click += new System.EventHandler(this.toolStripMenuItemCopyAll_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flowLayoutPanel8);
            this.groupBox3.Controls.Add(this.flowLayoutPanel7);
            this.groupBox3.Controls.Add(this.flowLayoutPanel6);
            this.groupBox3.Controls.Add(this.flowLayoutPanel9);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(361, 67);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Properties";
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(this.label20);
            this.flowLayoutPanel8.Controls.Add(this.label19);
            this.flowLayoutPanel8.Controls.Add(this.lblDistanceName);
            this.flowLayoutPanel8.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel8.Location = new System.Drawing.Point(165, 19);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(60, 42);
            this.flowLayoutPanel8.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Stations";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Spacing";
            // 
            // lblDistanceName
            // 
            this.lblDistanceName.AutoSize = true;
            this.lblDistanceName.Location = new System.Drawing.Point(3, 26);
            this.lblDistanceName.Name = "lblDistanceName";
            this.lblDistanceName.Size = new System.Drawing.Size(48, 13);
            this.lblDistanceName.TabIndex = 2;
            this.lblDistanceName.Text = "Distance";
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.lblName);
            this.flowLayoutPanel7.Controls.Add(this.lblType);
            this.flowLayoutPanel7.Controls.Add(this.lblBearing);
            this.flowLayoutPanel7.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(72, 19);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(90, 42);
            this.flowLayoutPanel7.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "value";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblType
            // 
            this.lblType.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblType.Location = new System.Drawing.Point(3, 13);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(84, 13);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "value";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBearing
            // 
            this.lblBearing.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBearing.Location = new System.Drawing.Point(3, 26);
            this.lblBearing.Name = "lblBearing";
            this.lblBearing.Size = new System.Drawing.Size(84, 13);
            this.lblBearing.TabIndex = 2;
            this.lblBearing.Text = "value";
            this.lblBearing.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label14);
            this.flowLayoutPanel6.Controls.Add(this.label13);
            this.flowLayoutPanel6.Controls.Add(this.label15);
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(6, 19);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(60, 42);
            this.flowLayoutPanel6.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Type";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Bearing";
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Controls.Add(this.lblStations);
            this.flowLayoutPanel9.Controls.Add(this.lblSpacing);
            this.flowLayoutPanel9.Controls.Add(this.lblDistance);
            this.flowLayoutPanel9.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel9.Location = new System.Drawing.Point(218, 19);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(137, 42);
            this.flowLayoutPanel9.TabIndex = 3;
            // 
            // lblStations
            // 
            this.lblStations.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblStations.Location = new System.Drawing.Point(3, 0);
            this.lblStations.Name = "lblStations";
            this.lblStations.Size = new System.Drawing.Size(134, 13);
            this.lblStations.TabIndex = 0;
            this.lblStations.Text = "value";
            this.lblStations.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSpacing
            // 
            this.lblSpacing.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSpacing.Location = new System.Drawing.Point(3, 13);
            this.lblSpacing.Name = "lblSpacing";
            this.lblSpacing.Size = new System.Drawing.Size(134, 13);
            this.lblSpacing.TabIndex = 1;
            this.lblSpacing.Text = "value";
            this.lblSpacing.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDistance
            // 
            this.lblDistance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDistance.Location = new System.Drawing.Point(3, 26);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(134, 13);
            this.lblDistance.TabIndex = 2;
            this.lblDistance.Text = "value";
            this.lblDistance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::SurveyLine.Properties.Resources.saveIco;
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.saveToolStripMenuItem.Text = "&Save As";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(151, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plotCurrentTableToolStripMenuItem,
            this.latLongToUTMToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // plotCurrentTableToolStripMenuItem
            // 
            this.plotCurrentTableToolStripMenuItem.Name = "plotCurrentTableToolStripMenuItem";
            this.plotCurrentTableToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.plotCurrentTableToolStripMenuItem.Text = "Plot Current Table";
            this.plotCurrentTableToolStripMenuItem.Click += new System.EventHandler(this.plotCurrentTableToolStripMenuItem_Click);
            // 
            // latLongToUTMToolStripMenuItem
            // 
            this.latLongToUTMToolStripMenuItem.Name = "latLongToUTMToolStripMenuItem";
            this.latLongToUTMToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.latLongToUTMToolStripMenuItem.Text = "Lat/Long to UTM";
            this.latLongToUTMToolStripMenuItem.Click += new System.EventHandler(this.latLongToUTMToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shortcutsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // shortcutsToolStripMenuItem
            // 
            this.shortcutsToolStripMenuItem.Name = "shortcutsToolStripMenuItem";
            this.shortcutsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.shortcutsToolStripMenuItem.Text = "Help...";
            this.shortcutsToolStripMenuItem.Click += new System.EventHandler(this.shortcutsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(611, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt|DAT Files (*.dat)|*.dat|All files (*.*)|*.*";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Save Coordinates Table As";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(139, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(27, 21);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 469);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SurveyLine";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEasting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNorthing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBearing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStation)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numMultiLineCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMultiLineSpacing)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoordinates)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.NumericUpDown numEasting;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
		private System.Windows.Forms.DataGridView dgvCoordinates;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem latLongToUTMToolStripMenuItem;
		private System.Windows.Forms.Button btnMoreSetup;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelAuthor;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ComboBox dropDownDirection;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.NumericUpDown numMultiLineCount;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.CheckBox cboxMultiMode;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtLineName;
        private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private NumericUpDown numStation;
		private System.Windows.Forms.Label label5;
		private NumericUpDown numInterval;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numBearing;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numNorthing;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label12;
        private NumericUpDown numMultiLineSpacing;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label label13;
        private Label label14;
        private Label label15;
        private FlowLayoutPanel flowLayoutPanel8;
        private Label label19;
        private Label label20;
        private Label lblDistanceName;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label lblName;
        private Label lblType;
        private Label lblBearing;
        private FlowLayoutPanel flowLayoutPanel9;
        private Label lblSpacing;
        private Label lblStations;
        private Label lblDistance;
        private SaveFileDialog saveFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripMenuItem plotCurrentTableToolStripMenuItem;
        private Label label16;
        private ToolStripMenuItem shortcutsToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItemCopy;
        private ToolStripMenuItem toolStripMenuItemCopyAll;
        private PictureBox pictureBox1;
	}
}
