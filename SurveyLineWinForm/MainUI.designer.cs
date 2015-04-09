/*
 * Created by SharpDevelop.
 * User: SamsungNC108
 * Date: 2/13/2014
 * Time: 10:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System.Windows.Forms;

namespace SurveyLineWinForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.cmNumButton = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmPasteXY = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
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
            this.label17 = new System.Windows.Forms.Label();
            this.cboxMode = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.numMultiLineCount = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numMultiLineSpacing = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dropDownDirection = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnNamingSetup = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePlot = new System.Windows.Forms.TabPage();
            this.zgcSurveyPlot = new ZedGraph.ZedGraphControl();
            this.tabPageTable = new System.Windows.Forms.TabPage();
            this.dgvCoordinates = new System.Windows.Forms.DataGridView();
            this.colStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXPos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYPos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmDatagrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCopyAll = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutDesignProp = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutLabelProperty1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.flowLayoutProperty1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblBearing = new System.Windows.Forms.Label();
            this.flowLayoutLabelProperty2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblDistanceName = new System.Windows.Forms.Label();
            this.flowLayoutProperty2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblStations = new System.Windows.Forms.Label();
            this.lblSpacing = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.nupLineWidth = new System.Windows.Forms.NumericUpDown();
            this.nupMarkerSize = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonLineColor = new System.Windows.Forms.Button();
            this.buttonMarkerColor = new System.Windows.Forms.Button();
            this.checkboxShowLine = new System.Windows.Forms.CheckBox();
            this.checkboxShowMarker = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openDesignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDesignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToSurferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToTextFilestxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.latLongToUTMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shortcutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ExportDialog = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lineColorDialog = new System.Windows.Forms.ColorDialog();
            this.markerColorDialog = new System.Windows.Forms.ColorDialog();
            this.statusStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEasting)).BeginInit();
            this.cmNumButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNorthing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBearing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStation)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMultiLineCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMultiLineSpacing)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPagePlot.SuspendLayout();
            this.tabPageTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoordinates)).BeginInit();
            this.cmDatagrid.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutDesignProp.SuspendLayout();
            this.flowLayoutLabelProperty1.SuspendLayout();
            this.flowLayoutProperty1.SuspendLayout();
            this.flowLayoutLabelProperty2.SuspendLayout();
            this.flowLayoutProperty2.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupLineWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMarkerSize)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabelAuthor});
            this.statusStrip1.Location = new System.Drawing.Point(0, 458);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1260, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.AutoSize = false;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
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
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(1019, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabelAuthor
            // 
            this.toolStripStatusLabelAuthor.Enabled = false;
            this.toolStripStatusLabelAuthor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelAuthor.IsLink = true;
            this.toolStripStatusLabelAuthor.Name = "toolStripStatusLabelAuthor";
            this.toolStripStatusLabelAuthor.Size = new System.Drawing.Size(141, 17);
            this.toolStripStatusLabelAuthor.Text = "Survey Line - Adien Akhmad";
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
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(1260, 434);
            this.splitContainer1.SplitterDistance = 229;
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(225, 430);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.groupBox1.Size = new System.Drawing.Size(201, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Survey Design";
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
            this.flowLayoutPanel2.Controls.Add(this.label17);
            this.flowLayoutPanel2.Controls.Add(this.cboxMode);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(5, 19);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(191, 194);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Name";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLineName
            // 
            this.txtLineName.Location = new System.Drawing.Point(74, 5);
            this.txtLineName.Name = "txtLineName";
            this.txtLineName.Size = new System.Drawing.Size(114, 21);
            this.txtLineName.TabIndex = 6;
            this.txtLineName.Enter += new System.EventHandler(this.txtLineName_Enter);
            this.txtLineName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLineName_KeyDown);
            this.txtLineName.Leave += new System.EventHandler(this.txtLineName_Leave);
            this.txtLineName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtLineName_MouseUp);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Easting";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numEasting
            // 
            this.numEasting.ContextMenuStrip = this.cmNumButton;
            this.numEasting.DecimalPlaces = 1;
            this.numEasting.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numEasting.Location = new System.Drawing.Point(74, 32);
            this.numEasting.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numEasting.Name = "numEasting";
            this.numEasting.Size = new System.Drawing.Size(114, 21);
            this.numEasting.TabIndex = 7;
            this.numEasting.Enter += new System.EventHandler(this.NumOnFocus);
            this.numEasting.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLineName_KeyDown);
            // 
            // cmNumButton
            // 
            this.cmNumButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmNumButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPasteXY,
            this.toolStripSeparator1,
            this.tsmCopy,
            this.tsmCut,
            this.tsmPaste,
            this.tsmDelete});
            this.cmNumButton.Name = "cmNumButton";
            this.cmNumButton.Size = new System.Drawing.Size(134, 120);
            this.cmNumButton.Opening += new System.ComponentModel.CancelEventHandler(this.cmNumButton_Opening);
            // 
            // tsmPasteXY
            // 
            this.tsmPasteXY.Name = "tsmPasteXY";
            this.tsmPasteXY.Size = new System.Drawing.Size(133, 22);
            this.tsmPasteXY.Text = "Paste (X, Y)";
            this.tsmPasteXY.Click += new System.EventHandler(this.tsmPasteXY_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // tsmCopy
            // 
            this.tsmCopy.Name = "tsmCopy";
            this.tsmCopy.Size = new System.Drawing.Size(133, 22);
            this.tsmCopy.Text = "&Copy";
            this.tsmCopy.Click += new System.EventHandler(this.tsmCopy_Click);
            // 
            // tsmCut
            // 
            this.tsmCut.Name = "tsmCut";
            this.tsmCut.Size = new System.Drawing.Size(133, 22);
            this.tsmCut.Text = "Cut";
            this.tsmCut.Click += new System.EventHandler(this.tsmCut_Click);
            // 
            // tsmPaste
            // 
            this.tsmPaste.Name = "tsmPaste";
            this.tsmPaste.Size = new System.Drawing.Size(133, 22);
            this.tsmPaste.Text = "&Paste";
            this.tsmPaste.Click += new System.EventHandler(this.tsmPaste_Click);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(133, 22);
            this.tsmDelete.Text = "&Delete";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Northing";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numNorthing
            // 
            this.numNorthing.ContextMenuStrip = this.cmNumButton;
            this.numNorthing.DecimalPlaces = 1;
            this.numNorthing.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numNorthing.Location = new System.Drawing.Point(74, 59);
            this.numNorthing.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numNorthing.Name = "numNorthing";
            this.numNorthing.Size = new System.Drawing.Size(114, 21);
            this.numNorthing.TabIndex = 8;
            this.numNorthing.Enter += new System.EventHandler(this.NumOnFocus);
            this.numNorthing.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLineName_KeyDown);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
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
            this.numBearing.Location = new System.Drawing.Point(74, 86);
            this.numBearing.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numBearing.Name = "numBearing";
            this.numBearing.Size = new System.Drawing.Size(60, 21);
            this.numBearing.TabIndex = 9;
            this.numBearing.Enter += new System.EventHandler(this.NumOnFocus);
            this.numBearing.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLineName_KeyDown);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(140, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "NE";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Spacing";
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
            this.numInterval.Location = new System.Drawing.Point(74, 113);
            this.numInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(60, 21);
            this.numInterval.TabIndex = 10;
            this.numInterval.Enter += new System.EventHandler(this.NumOnFocus);
            this.numInterval.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLineName_KeyDown);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(140, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "m";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Station";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numStation
            // 
            this.numStation.Location = new System.Drawing.Point(74, 140);
            this.numStation.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numStation.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numStation.Name = "numStation";
            this.numStation.Size = new System.Drawing.Size(60, 21);
            this.numStation.TabIndex = 11;
            this.numStation.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numStation.Enter += new System.EventHandler(this.NumOnFocus);
            this.numStation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLineName_KeyDown);
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(3, 164);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 23);
            this.label17.TabIndex = 16;
            this.label17.Text = "Mode";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboxMode
            // 
            this.cboxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMode.FormattingEnabled = true;
            this.cboxMode.Items.AddRange(new object[] {
            "Single Line",
            "Multiple Line",
            "Rectangular Grid",
            "Square Grid"});
            this.cboxMode.Location = new System.Drawing.Point(74, 167);
            this.cboxMode.Name = "cboxMode";
            this.cboxMode.Size = new System.Drawing.Size(114, 21);
            this.cboxMode.TabIndex = 17;
            this.cboxMode.SelectedIndexChanged += new System.EventHandler(this.cboxMode_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel3);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(201, 121);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Multi Line/ Grid Design";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label10);
            this.flowLayoutPanel3.Controls.Add(this.numMultiLineCount);
            this.flowLayoutPanel3.Controls.Add(this.label12);
            this.flowLayoutPanel3.Controls.Add(this.numMultiLineSpacing);
            this.flowLayoutPanel3.Controls.Add(this.label16);
            this.flowLayoutPanel3.Controls.Add(this.label11);
            this.flowLayoutPanel3.Controls.Add(this.dropDownDirection);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(5, 19);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(191, 97);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(3, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "x N";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numMultiLineCount
            // 
            this.numMultiLineCount.Location = new System.Drawing.Point(74, 8);
            this.numMultiLineCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numMultiLineCount.Name = "numMultiLineCount";
            this.numMultiLineCount.Size = new System.Drawing.Size(60, 21);
            this.numMultiLineCount.TabIndex = 4;
            this.numMultiLineCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.label12.Location = new System.Drawing.Point(3, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 23);
            this.label12.TabIndex = 2;
            this.label12.Text = "Spacing";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numMultiLineSpacing
            // 
            this.numMultiLineSpacing.DecimalPlaces = 1;
            this.numMultiLineSpacing.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numMultiLineSpacing.Location = new System.Drawing.Point(74, 35);
            this.numMultiLineSpacing.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMultiLineSpacing.Name = "numMultiLineSpacing";
            this.numMultiLineSpacing.Size = new System.Drawing.Size(60, 21);
            this.numMultiLineSpacing.TabIndex = 5;
            this.numMultiLineSpacing.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numMultiLineSpacing.Enter += new System.EventHandler(this.NumOnFocus);
            this.numMultiLineSpacing.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLineName_KeyDown);
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(140, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 23);
            this.label16.TabIndex = 14;
            this.label16.Text = "m";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(3, 59);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label11.Size = new System.Drawing.Size(65, 23);
            this.label11.TabIndex = 3;
            this.label11.Text = "Orientation";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dropDownDirection
            // 
            this.dropDownDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownDirection.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.dropDownDirection.FormattingEnabled = true;
            this.dropDownDirection.Items.AddRange(new object[] {
            "Clockwise",
            "Counter CW"});
            this.dropDownDirection.Location = new System.Drawing.Point(74, 62);
            this.dropDownDirection.Name = "dropDownDirection";
            this.dropDownDirection.Size = new System.Drawing.Size(114, 21);
            this.dropDownDirection.TabIndex = 6;
            this.dropDownDirection.TabStop = false;
            this.dropDownDirection.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLineName_KeyDown);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.btnCreate);
            this.flowLayoutPanel4.Controls.Add(this.btnNamingSetup);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(13, 369);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.flowLayoutPanel4.Size = new System.Drawing.Size(201, 45);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(8, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 31);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnNamingSetup
            // 
            this.btnNamingSetup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNamingSetup.Location = new System.Drawing.Point(89, 3);
            this.btnNamingSetup.Name = "btnNamingSetup";
            this.btnNamingSetup.Size = new System.Drawing.Size(92, 31);
            this.btnNamingSetup.TabIndex = 1;
            this.btnNamingSetup.Text = "Name Settings";
            this.btnNamingSetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNamingSetup.UseVisualStyleBackColor = true;
            this.btnNamingSetup.Click += new System.EventHandler(this.btnMoreSetup_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPagePlot);
            this.tabControl1.Controls.Add(this.tabPageTable);
            this.tabControl1.Location = new System.Drawing.Point(7, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1009, 336);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPagePlot
            // 
            this.tabPagePlot.Controls.Add(this.zgcSurveyPlot);
            this.tabPagePlot.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlot.Name = "tabPagePlot";
            this.tabPagePlot.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlot.Size = new System.Drawing.Size(1001, 310);
            this.tabPagePlot.TabIndex = 1;
            this.tabPagePlot.Text = "Survey Plot";
            this.tabPagePlot.UseVisualStyleBackColor = true;
            // 
            // zgcSurveyPlot
            // 
            this.zgcSurveyPlot.AutoSize = true;
            this.zgcSurveyPlot.BackColor = System.Drawing.SystemColors.Control;
            this.zgcSurveyPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zgcSurveyPlot.EditButtons = System.Windows.Forms.MouseButtons.Left;
            this.zgcSurveyPlot.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zgcSurveyPlot.IsEnableHEdit = true;
            this.zgcSurveyPlot.IsEnableHZoom = false;
            this.zgcSurveyPlot.IsEnableVEdit = true;
            this.zgcSurveyPlot.IsEnableVZoom = false;
            this.zgcSurveyPlot.IsEnableWheelZoom = false;
            this.zgcSurveyPlot.LinkButtons = System.Windows.Forms.MouseButtons.Middle;
            this.zgcSurveyPlot.Location = new System.Drawing.Point(3, 3);
            this.zgcSurveyPlot.Name = "zgcSurveyPlot";
            this.zgcSurveyPlot.PanButtons2 = System.Windows.Forms.MouseButtons.None;
            this.zgcSurveyPlot.PanModifierKeys = System.Windows.Forms.Keys.None;
            this.zgcSurveyPlot.ScrollGrace = 0D;
            this.zgcSurveyPlot.ScrollMaxX = 0D;
            this.zgcSurveyPlot.ScrollMaxY = 0D;
            this.zgcSurveyPlot.ScrollMaxY2 = 0D;
            this.zgcSurveyPlot.ScrollMinX = 0D;
            this.zgcSurveyPlot.ScrollMinY = 0D;
            this.zgcSurveyPlot.ScrollMinY2 = 0D;
            this.zgcSurveyPlot.Size = new System.Drawing.Size(995, 304);
            this.zgcSurveyPlot.TabIndex = 1;
            this.zgcSurveyPlot.ZoomModifierKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.None)));
            this.zgcSurveyPlot.Resize += new System.EventHandler(this.zgcSurveyPlot_Resize);
            // 
            // tabPageTable
            // 
            this.tabPageTable.Controls.Add(this.dgvCoordinates);
            this.tabPageTable.Location = new System.Drawing.Point(4, 22);
            this.tabPageTable.Name = "tabPageTable";
            this.tabPageTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTable.Size = new System.Drawing.Size(1001, 310);
            this.tabPageTable.TabIndex = 0;
            this.tabPageTable.Text = "Table";
            this.tabPageTable.UseVisualStyleBackColor = true;
            // 
            // dgvCoordinates
            // 
            this.dgvCoordinates.AllowUserToAddRows = false;
            this.dgvCoordinates.AllowUserToDeleteRows = false;
            this.dgvCoordinates.AllowUserToResizeColumns = false;
            this.dgvCoordinates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCoordinates.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCoordinates.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCoordinates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoordinates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStation,
            this.colXPos,
            this.colYPos});
            this.dgvCoordinates.ContextMenuStrip = this.cmDatagrid;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCoordinates.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCoordinates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCoordinates.Location = new System.Drawing.Point(3, 3);
            this.dgvCoordinates.Name = "dgvCoordinates";
            this.dgvCoordinates.ReadOnly = true;
            this.dgvCoordinates.Size = new System.Drawing.Size(995, 304);
            this.dgvCoordinates.TabIndex = 3;
            this.dgvCoordinates.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCoordinates_CellMouseDown);
            // 
            // colStation
            // 
            this.colStation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStation.DataPropertyName = "Name";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colStation.DefaultCellStyle = dataGridViewCellStyle1;
            this.colStation.HeaderText = "Station";
            this.colStation.Name = "colStation";
            this.colStation.ReadOnly = true;
            // 
            // colXPos
            // 
            this.colXPos.DataPropertyName = "X";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Format = "F3";
            dataGridViewCellStyle2.NullValue = null;
            this.colXPos.DefaultCellStyle = dataGridViewCellStyle2;
            this.colXPos.HeaderText = "X-Position";
            this.colXPos.Name = "colXPos";
            this.colXPos.ReadOnly = true;
            // 
            // colYPos
            // 
            this.colYPos.DataPropertyName = "Y";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "F3";
            this.colYPos.DefaultCellStyle = dataGridViewCellStyle3;
            this.colYPos.HeaderText = "Y-Position";
            this.colYPos.Name = "colYPos";
            this.colYPos.ReadOnly = true;
            // 
            // cmDatagrid
            // 
            this.cmDatagrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCopy,
            this.toolStripMenuItemCopyAll});
            this.cmDatagrid.Name = "contextMenuStrip1";
            this.cmDatagrid.Size = new System.Drawing.Size(120, 48);
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
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.flowLayoutDesignProp);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(8, 345);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1004, 82);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Design Properties";
            // 
            // flowLayoutDesignProp
            // 
            this.flowLayoutDesignProp.Controls.Add(this.flowLayoutLabelProperty1);
            this.flowLayoutDesignProp.Controls.Add(this.flowLayoutProperty1);
            this.flowLayoutDesignProp.Controls.Add(this.flowLayoutLabelProperty2);
            this.flowLayoutDesignProp.Controls.Add(this.flowLayoutProperty2);
            this.flowLayoutDesignProp.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutDesignProp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutDesignProp.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutDesignProp.Name = "flowLayoutDesignProp";
            this.flowLayoutDesignProp.Size = new System.Drawing.Size(998, 62);
            this.flowLayoutDesignProp.TabIndex = 0;
            this.flowLayoutDesignProp.WrapContents = false;
            // 
            // flowLayoutLabelProperty1
            // 
            this.flowLayoutLabelProperty1.AutoSize = true;
            this.flowLayoutLabelProperty1.Controls.Add(this.label14);
            this.flowLayoutLabelProperty1.Controls.Add(this.label13);
            this.flowLayoutLabelProperty1.Controls.Add(this.label15);
            this.flowLayoutLabelProperty1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutLabelProperty1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutLabelProperty1.Name = "flowLayoutLabelProperty1";
            this.flowLayoutLabelProperty1.Size = new System.Drawing.Size(47, 51);
            this.flowLayoutLabelProperty1.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(2, 2);
            this.label14.Margin = new System.Windows.Forms.Padding(2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2, 19);
            this.label13.Margin = new System.Windows.Forms.Padding(2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Type";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(2, 36);
            this.label15.Margin = new System.Windows.Forms.Padding(2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Bearing";
            // 
            // flowLayoutProperty1
            // 
            this.flowLayoutProperty1.AutoSize = true;
            this.flowLayoutProperty1.Controls.Add(this.lblName);
            this.flowLayoutProperty1.Controls.Add(this.lblType);
            this.flowLayoutProperty1.Controls.Add(this.lblBearing);
            this.flowLayoutProperty1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutProperty1.Location = new System.Drawing.Point(56, 3);
            this.flowLayoutProperty1.Name = "flowLayoutProperty1";
            this.flowLayoutProperty1.Size = new System.Drawing.Size(107, 51);
            this.flowLayoutProperty1.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblName.Location = new System.Drawing.Point(2, 2);
            this.lblName.Margin = new System.Windows.Forms.Padding(2);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "value";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblType
            // 
            this.lblType.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblType.Location = new System.Drawing.Point(2, 19);
            this.lblType.Margin = new System.Windows.Forms.Padding(2);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(103, 13);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "value";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBearing
            // 
            this.lblBearing.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBearing.Location = new System.Drawing.Point(2, 36);
            this.lblBearing.Margin = new System.Windows.Forms.Padding(2);
            this.lblBearing.Name = "lblBearing";
            this.lblBearing.Size = new System.Drawing.Size(103, 13);
            this.lblBearing.TabIndex = 2;
            this.lblBearing.Text = "value";
            this.lblBearing.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutLabelProperty2
            // 
            this.flowLayoutLabelProperty2.AutoSize = true;
            this.flowLayoutLabelProperty2.Controls.Add(this.label20);
            this.flowLayoutLabelProperty2.Controls.Add(this.label19);
            this.flowLayoutLabelProperty2.Controls.Add(this.lblDistanceName);
            this.flowLayoutLabelProperty2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutLabelProperty2.Location = new System.Drawing.Point(169, 3);
            this.flowLayoutLabelProperty2.Name = "flowLayoutLabelProperty2";
            this.flowLayoutLabelProperty2.Size = new System.Drawing.Size(52, 51);
            this.flowLayoutLabelProperty2.TabIndex = 6;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(2, 2);
            this.label20.Margin = new System.Windows.Forms.Padding(2);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Stations";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(2, 19);
            this.label19.Margin = new System.Windows.Forms.Padding(2);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Spacing";
            // 
            // lblDistanceName
            // 
            this.lblDistanceName.AutoSize = true;
            this.lblDistanceName.Location = new System.Drawing.Point(2, 36);
            this.lblDistanceName.Margin = new System.Windows.Forms.Padding(2);
            this.lblDistanceName.Name = "lblDistanceName";
            this.lblDistanceName.Size = new System.Drawing.Size(48, 13);
            this.lblDistanceName.TabIndex = 2;
            this.lblDistanceName.Text = "Distance";
            // 
            // flowLayoutProperty2
            // 
            this.flowLayoutProperty2.AutoSize = true;
            this.flowLayoutProperty2.Controls.Add(this.lblStations);
            this.flowLayoutProperty2.Controls.Add(this.lblSpacing);
            this.flowLayoutProperty2.Controls.Add(this.lblDistance);
            this.flowLayoutProperty2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutProperty2.Location = new System.Drawing.Point(227, 3);
            this.flowLayoutProperty2.Margin = new System.Windows.Forms.Padding(3, 3, 25, 3);
            this.flowLayoutProperty2.Name = "flowLayoutProperty2";
            this.flowLayoutProperty2.Size = new System.Drawing.Size(125, 51);
            this.flowLayoutProperty2.TabIndex = 7;
            // 
            // lblStations
            // 
            this.lblStations.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblStations.Location = new System.Drawing.Point(2, 2);
            this.lblStations.Margin = new System.Windows.Forms.Padding(2);
            this.lblStations.Name = "lblStations";
            this.lblStations.Size = new System.Drawing.Size(121, 13);
            this.lblStations.TabIndex = 3;
            this.lblStations.Text = "value";
            this.lblStations.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSpacing
            // 
            this.lblSpacing.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSpacing.Location = new System.Drawing.Point(2, 19);
            this.lblSpacing.Margin = new System.Windows.Forms.Padding(2);
            this.lblSpacing.Name = "lblSpacing";
            this.lblSpacing.Size = new System.Drawing.Size(121, 13);
            this.lblSpacing.TabIndex = 4;
            this.lblSpacing.Text = "value";
            this.lblSpacing.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDistance
            // 
            this.lblDistance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDistance.Location = new System.Drawing.Point(2, 36);
            this.lblDistance.Margin = new System.Windows.Forms.Padding(2);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(121, 13);
            this.lblDistance.TabIndex = 5;
            this.lblDistance.Text = "value";
            this.lblDistance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.Controls.Add(this.label21);
            this.flowLayoutPanel6.Controls.Add(this.label22);
            this.flowLayoutPanel6.Controls.Add(this.nupLineWidth);
            this.flowLayoutPanel6.Controls.Add(this.nupMarkerSize);
            this.flowLayoutPanel6.Controls.Add(this.label7);
            this.flowLayoutPanel6.Controls.Add(this.label18);
            this.flowLayoutPanel6.Controls.Add(this.buttonLineColor);
            this.flowLayoutPanel6.Controls.Add(this.buttonMarkerColor);
            this.flowLayoutPanel6.Controls.Add(this.checkboxShowLine);
            this.flowLayoutPanel6.Controls.Add(this.checkboxShowMarker);
            this.flowLayoutPanel6.Controls.Add(this.checkBox3);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(402, 3);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(470, 54);
            this.flowLayoutPanel6.TabIndex = 8;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 6);
            this.label21.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 13);
            this.label21.TabIndex = 8;
            this.label21.Text = "Line Width";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.flowLayoutPanel6.SetFlowBreak(this.label22, true);
            this.label22.Location = new System.Drawing.Point(3, 31);
            this.label22.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(62, 13);
            this.label22.TabIndex = 9;
            this.label22.Text = "Marker Size";
            // 
            // nupLineWidth
            // 
            this.nupLineWidth.DecimalPlaces = 1;
            this.nupLineWidth.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nupLineWidth.Location = new System.Drawing.Point(71, 3);
            this.nupLineWidth.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nupLineWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupLineWidth.Name = "nupLineWidth";
            this.nupLineWidth.Size = new System.Drawing.Size(48, 21);
            this.nupLineWidth.TabIndex = 10;
            this.nupLineWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupLineWidth.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.nupLineWidth.ValueChanged += new System.EventHandler(this.PlottingStyleChanged);
            // 
            // nupMarkerSize
            // 
            this.nupMarkerSize.DecimalPlaces = 1;
            this.nupMarkerSize.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nupMarkerSize.Location = new System.Drawing.Point(71, 30);
            this.nupMarkerSize.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nupMarkerSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupMarkerSize.Name = "nupMarkerSize";
            this.nupMarkerSize.Size = new System.Drawing.Size(48, 21);
            this.nupMarkerSize.TabIndex = 12;
            this.nupMarkerSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupMarkerSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupMarkerSize.ValueChanged += new System.EventHandler(this.PlottingStyleChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Line Color";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.flowLayoutPanel6.SetFlowBreak(this.label18, true);
            this.label18.Location = new System.Drawing.Point(125, 31);
            this.label18.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Marker Fill";
            // 
            // buttonLineColor
            // 
            this.buttonLineColor.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonLineColor.FlatAppearance.BorderSize = 0;
            this.buttonLineColor.Location = new System.Drawing.Point(186, 3);
            this.buttonLineColor.Name = "buttonLineColor";
            this.buttonLineColor.Size = new System.Drawing.Size(101, 20);
            this.buttonLineColor.TabIndex = 1;
            this.buttonLineColor.UseVisualStyleBackColor = false;
            this.buttonLineColor.Click += new System.EventHandler(this.buttonLineColor_Click);
            // 
            // buttonMarkerColor
            // 
            this.buttonMarkerColor.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonMarkerColor.Location = new System.Drawing.Point(186, 29);
            this.buttonMarkerColor.Name = "buttonMarkerColor";
            this.buttonMarkerColor.Size = new System.Drawing.Size(101, 20);
            this.buttonMarkerColor.TabIndex = 5;
            this.buttonMarkerColor.UseVisualStyleBackColor = false;
            this.buttonMarkerColor.Click += new System.EventHandler(this.buttonMarkerColor_Click);
            // 
            // checkboxShowLine
            // 
            this.checkboxShowLine.AutoSize = true;
            this.checkboxShowLine.Checked = true;
            this.checkboxShowLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxShowLine.Location = new System.Drawing.Point(293, 6);
            this.checkboxShowLine.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.checkboxShowLine.Name = "checkboxShowLine";
            this.checkboxShowLine.Size = new System.Drawing.Size(74, 17);
            this.checkboxShowLine.TabIndex = 2;
            this.checkboxShowLine.Text = "Show Line";
            this.checkboxShowLine.UseVisualStyleBackColor = true;
            this.checkboxShowLine.CheckedChanged += new System.EventHandler(this.PlottingStyleChanged);
            // 
            // checkboxShowMarker
            // 
            this.checkboxShowMarker.AutoSize = true;
            this.checkboxShowMarker.Checked = true;
            this.checkboxShowMarker.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxShowMarker.Location = new System.Drawing.Point(293, 31);
            this.checkboxShowMarker.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.checkboxShowMarker.Name = "checkboxShowMarker";
            this.checkboxShowMarker.Size = new System.Drawing.Size(88, 17);
            this.checkboxShowMarker.TabIndex = 3;
            this.checkboxShowMarker.Text = "Show Marker";
            this.checkboxShowMarker.UseVisualStyleBackColor = true;
            this.checkboxShowMarker.CheckedChanged += new System.EventHandler(this.PlottingStyleChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(387, 6);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Show Label";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.toolStripSeparator2,
            this.openDesignToolStripMenuItem,
            this.exportDesignToolStripMenuItem,
            this.toolStripSeparator3,
            this.exportToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newWindowToolStripMenuItem.Text = "New Window";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.newWindowToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.openToolStripMenuItem.Text = "Open...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.saveToolStripMenuItem1.Text = "Save As";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(155, 6);
            // 
            // openDesignToolStripMenuItem
            // 
            this.openDesignToolStripMenuItem.Name = "openDesignToolStripMenuItem";
            this.openDesignToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.openDesignToolStripMenuItem.Text = "Import Design...";
            // 
            // exportDesignToolStripMenuItem
            // 
            this.exportDesignToolStripMenuItem.Name = "exportDesignToolStripMenuItem";
            this.exportDesignToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.exportDesignToolStripMenuItem.Text = "Export Design...";
            this.exportDesignToolStripMenuItem.Click += new System.EventHandler(this.exportDesignToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(155, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToSurferToolStripMenuItem,
            this.exportToTextFilestxtToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // exportToSurferToolStripMenuItem
            // 
            this.exportToSurferToolStripMenuItem.Name = "exportToSurferToolStripMenuItem";
            this.exportToSurferToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.exportToSurferToolStripMenuItem.Text = "Surfer Spreadsheet (*.bln)";
            // 
            // exportToTextFilestxtToolStripMenuItem
            // 
            this.exportToTextFilestxtToolStripMenuItem.Name = "exportToTextFilestxtToolStripMenuItem";
            this.exportToTextFilestxtToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.exportToTextFilestxtToolStripMenuItem.Text = "Text Files (*.txt)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(155, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.latLongToUTMToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // latLongToUTMToolStripMenuItem
            // 
            this.latLongToUTMToolStripMenuItem.Name = "latLongToUTMToolStripMenuItem";
            this.latLongToUTMToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.latLongToUTMToolStripMenuItem.Text = "Export to Geographic Coordinate";
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
            this.shortcutsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.shortcutsToolStripMenuItem.Text = "Help...";
            this.shortcutsToolStripMenuItem.Click += new System.EventHandler(this.shortcutsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.menuStrip1.Size = new System.Drawing.Size(1260, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ExportDialog
            // 
            this.ExportDialog.Filter = "Text files (*.txt)|*.txt|DAT Files (*.dat)|*.dat|All files (*.*)|*.*";
            this.ExportDialog.RestoreDirectory = true;
            this.ExportDialog.Title = "Save Coordinates Table As";
            this.ExportDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lineColorDialog
            // 
            this.lineColorDialog.AnyColor = true;
            this.lineColorDialog.Color = System.Drawing.Color.Gainsboro;
            this.lineColorDialog.FullOpen = true;
            // 
            // markerColorDialog
            // 
            this.markerColorDialog.AnyColor = true;
            this.markerColorDialog.Color = System.Drawing.Color.OrangeRed;
            this.markerColorDialog.FullOpen = true;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 480);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainUI";
            this.Text = "Survey Line";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEasting)).EndInit();
            this.cmNumButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numNorthing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBearing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStation)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numMultiLineCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMultiLineSpacing)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPagePlot.ResumeLayout(false);
            this.tabPagePlot.PerformLayout();
            this.tabPageTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoordinates)).EndInit();
            this.cmDatagrid.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.flowLayoutDesignProp.ResumeLayout(false);
            this.flowLayoutDesignProp.PerformLayout();
            this.flowLayoutLabelProperty1.ResumeLayout(false);
            this.flowLayoutLabelProperty1.PerformLayout();
            this.flowLayoutProperty1.ResumeLayout(false);
            this.flowLayoutLabelProperty2.ResumeLayout(false);
            this.flowLayoutLabelProperty2.PerformLayout();
            this.flowLayoutProperty2.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupLineWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMarkerSize)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        private System.Windows.Forms.NumericUpDown numEasting;
        private System.Windows.Forms.ToolStripMenuItem latLongToUTMToolStripMenuItem;
		private System.Windows.Forms.Button btnNamingSetup;
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
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtLineName;
        private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private NumericUpDown numStation;
		private System.Windows.Forms.Label label5;
        private NumericUpDown numInterval;
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
        private SaveFileDialog ExportDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label16;
        private ToolStripMenuItem shortcutsToolStripMenuItem;
        private ContextMenuStrip cmDatagrid;
        private ToolStripMenuItem toolStripMenuItemCopy;
        private ToolStripMenuItem toolStripMenuItemCopyAll;
        private TabControl tabControl1;
        private TabPage tabPageTable;
        private DataGridView dgvCoordinates;
        private TabPage tabPagePlot;
        private Label label17;
        private ComboBox cboxMode;
        private Label label4;
        private DataGridViewTextBoxColumn colStation;
        private DataGridViewTextBoxColumn colXPos;
        private DataGridViewTextBoxColumn colYPos;
        private ZedGraph.ZedGraphControl zgcSurveyPlot;
        private GroupBox groupBox3;
        private FlowLayoutPanel flowLayoutDesignProp;
        private FlowLayoutPanel flowLayoutLabelProperty2;
        private Label label20;
        private Label label19;
        private Label lblDistanceName;
        private FlowLayoutPanel flowLayoutProperty1;
        private Label lblName;
        private Label lblType;
        private Label lblBearing;
        private FlowLayoutPanel flowLayoutLabelProperty1;
        private Label label14;
        private Label label13;
        private Label label15;
        private FlowLayoutPanel flowLayoutProperty2;
        private Label lblStations;
        private Label lblSpacing;
        private Label lblDistance;
        private FlowLayoutPanel flowLayoutPanel6;
        private Button buttonLineColor;
        private CheckBox checkboxShowLine;
        private CheckBox checkboxShowMarker;
        private CheckBox checkBox3;
        private ColorDialog lineColorDialog;
        private Button buttonMarkerColor;
        private Label label7;
        private Label label18;
        private ColorDialog markerColorDialog;
        private Label label21;
        private Label label22;
        private NumericUpDown nupLineWidth;
        private NumericUpDown nupMarkerSize;
        private ContextMenuStrip cmNumButton;
        private ToolStripMenuItem tsmCopy;
        private ToolStripMenuItem tsmCut;
        private ToolStripMenuItem tsmPaste;
        private ToolStripMenuItem tsmPasteXY;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tsmDelete;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem newWindowToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem1;
        private ToolStripMenuItem openDesignToolStripMenuItem;
        private ToolStripMenuItem exportDesignToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem exportToTextFilestxtToolStripMenuItem;
        private ToolStripMenuItem exportToSurferToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
	}
}
