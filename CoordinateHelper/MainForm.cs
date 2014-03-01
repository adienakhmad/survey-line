/*
 * Created by SharpDevelop.
 * User: SamsungNC108
 * Date: 2/13/2014
 * Time: 10:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CoordinateHelper.Properties;
using DotNetPerls;
using RavSoft;


namespace CoordinateHelper
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
        Linemaker line1 = new Linemaker();
        DataTable dTable = new DataTable();
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

	    private void GrabAllInputs(Linemaker line)
	    {
	        line.Xstart = (double) numEasting.Value;
	        line.Ystart = (double) numNorthing.Value;
	        line.Bearing = (double) numBearing.Value;
	        line.Station = (int) numStation.Value;
	        line.Interval = (double) numInterval.Value;
	        line.Type = cboxMultiMode.Checked ? "Multi" : "Single line";

            if (!string.IsNullOrEmpty(txtLineName.Text))
            {
                line1.Name = txtLineName.Text;
            }
	        
	        line.LineSpacing = (double) numMultiLineSpacing.Value;
	        line.Linecount = (int) numMultiLineCount.Value;
	        line.PlusBearing = dropDownDirection.SelectedIndex == 0 ? 90 : -90;

	    }

        private void SetMultiLineControlState(bool isCboxChecked)
        {

            numMultiLineCount.Enabled = isCboxChecked;
            numMultiLineSpacing.Enabled = isCboxChecked;
            dropDownDirection.Enabled = isCboxChecked;

        }

	    private void SetLineStatus(Linemaker line, bool multimode)
	    {
	        if (multimode)
	        {
                lblName.Text = line.Name;
                lblType.Text = string.Format("{0} ({1} lines)",line.Type,line.Linecount);
                lblBearing.Text = string.Format("N {0}° E", line.Bearing);
                lblSpacing.Text = string.Format("{0} m / {1} m", line.Interval,line.LineSpacing);
	            lblStations.Text = string.Format("{0} points ({1} x {2})", line.Station*line.Linecount, line.Station,line.Linecount);
	            
                
                lblDistanceName.Text = "Area";

                var length = ((line.Station - 1) * line.Interval);
	            var height = ((line.Linecount - 1)*line.LineSpacing);
                var lengthunit = length > 999 ? "Km" : "m";
	            var heightunit = height > 999 ? "Km" : "m";
	            length = lengthunit == "Km" ? length/1000 : length;
	            height = heightunit == "Km" ? height/1000 : height;

	            lblDistance.Text = string.Format("{0} {1} x {2} {3}", length, lengthunit, height, heightunit);
	        }

	        else
	        {
	            lblName.Text = line.Name;
	            lblType.Text = line.Type;
	            lblBearing.Text = string.Format("N {0}° E", line.Bearing);
	            lblSpacing.Text = string.Format("{0} m", line.Interval);
	            lblStations.Text = string.Format("{0} points", line.Station);
                
                lblDistanceName.Text = "Distance";
	            var distance = ((line.Station - 1)*line.Interval);
	            var unit = distance > 999 ? "Km" : "m";
                distance = distance > 999 ? distance / 1000 : distance;
	            lblDistance.Text = string.Format("{0} {1}", distance, unit);
	        }

	        

	    }

	    private void SetLineStatus(string str)
	    {
	        lblName.Text = str;
	        lblType.Text = str;
	        lblBearing.Text = str;
	        lblSpacing.Text = str;
	        lblStations.Text = str;
	        lblDistance.Text = str;
	    }

	    private void SetStatusBarText(string message)
	    {
	        toolStripStatusLabel1.Text = message;
            statusStrip1.Refresh();
	    }

	    private void DisableButtonOnWork(bool disable)
	    {
	        btnCreate.Enabled = !disable;
	        btnMoreSetup.Enabled = !disable;
	        saveToolStripMenuItem.Enabled = !disable;
	    }

	    private void DisableButtonOnLoad(bool disable)
	    {
	        saveToolStripMenuItem.Enabled = !disable;
	        plotCurrentTableToolStripMenuItem.Enabled = !disable;
	    }

	    private void StartMainMethod()
	    {
            GrabAllInputs(line1);
            SetStatusBarText("Working.. Please wait..");
            toolStripProgressBar1.Visible = true;
            DisableButtonOnWork(true);

            backgroundWorker1.RunWorkerAsync();
	    }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (numInterval.Value == 0)
            {
                MessageBox.Show("Interval cannot be zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            StartMainMethod();
            
        }
	   
        private void dgvCoordinates_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvCoordinates.Columns[1].DefaultCellStyle.Format = "f2";
            dgvCoordinates.Columns[2].DefaultCellStyle.Format = "f2";
        }

        private void cboxMultiMode_CheckedChanged(object sender, EventArgs e)
        {
            SetMultiLineControlState(cboxMultiMode.Checked);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CueProvider.SetCue(txtLineName,"Enter a name here..");
            DisableButtonOnLoad(true);
            SetMultiLineControlState(cboxMultiMode.Checked);
            dropDownDirection.SelectedIndex = 0;
            SetLineStatus("-");
            SetStatusBarText("Ready.");
        }

        private void btnMoreSetup_Click(object sender, EventArgs e)
        {
            var settings1 = new SettingsForm();

            if (!string.IsNullOrEmpty(txtLineName.Text))
            {
                line1.Name = txtLineName.Text;
            }

            settings1.ReadSettings(line1,cboxMultiMode.Checked);

            settings1.ShowDialog();

            if (!settings1.ButtonSavePressed) return;

            var somethingChanged = settings1.IsSomethingChanged(line1);
            settings1.SaveSettings(line1);

            if (dgvCoordinates.DataSource != null && somethingChanged)
            {
                StartMainMethod();
            }
                
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            using (var writer = new StreamWriter(saveFileDialog1.FileName))
            {
                
                Utilities.WriteDataTable(dTable,writer,true,line1.Delimiter,line1.NumericFormat);

                //myline.WriteDataTable(myline.CoordTable, writer, true, dlm);
            }

            saveFileDialog1.FileName = string.Empty;
            SetStatusBarText("\tFile saved successfully.");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = line1.GenerateTable(cboxMultiMode.Checked);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dTable = (DataTable) e.Result;
            dgvCoordinates.DataSource = dTable;

            DisableButtonOnLoad(false);
            DisableButtonOnWork(false);
            SetStatusBarText("Progress completed.");
            toolStripProgressBar1.Visible = false;
            SetLineStatus(line1, cboxMultiMode.Checked);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void latLongToUTMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilities.FeatureUnavailable();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BetterDialog.ShowDialog("About SurveyLine", "SurveyLine v1.0 BETA 2",
                "This simple tool was developed in purpose to help designing a survey for Geophysical measurement or any other field measurement which requires a set of coordinates.\n\n" +
                "© 2014 Adien Akhmad. All rights reserved.", null, "Close",
                (Image) Resources.ResourceManager.GetObject("aboutIco"));
        }

        bool _alreadyFocused;
        private void txtLineName_Enter(object sender, EventArgs e)
        {
            if (MouseButtons != MouseButtons.None) return;
            txtLineName.SelectAll();
            _alreadyFocused = true;
        }

        private void txtLineName_MouseUp(object sender, MouseEventArgs e)
        {
            if (_alreadyFocused || txtLineName.SelectionLength != 0) return;
            _alreadyFocused = true;
            txtLineName.SelectAll();
        }

        private void txtLineName_Leave(object sender, EventArgs e)
        {
            _alreadyFocused = false;
        }

        private void txtLineName_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                SelectNextControl((Control)sender, true, true, true, true);
            }
           
        }

        
        private void NumOnFocus(object sender, EventArgs e)
        {
            var numControl = (NumericUpDown)sender;
            numControl.Select(0, numControl.Text.Length);
        }

        private void txtLineName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Shift && e.KeyCode == Keys.Up)
            {
                SelectNextControl((Control)sender, false, true, true, true);
            }
            else if (e.KeyCode == Keys.Shift && e.KeyCode == Keys.Down)
            {
                SelectNextControl((Control)sender, true, true, true, true);
            }

            e.SuppressKeyPress = true;
        }

        private void plotCurrentTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var plot1 = new LinePlot();
            var xMin = dTable.AsEnumerable().Min(r => r.Field<Double>(dTable.Columns[1])) - line1.Interval;
            var xMax = dTable.AsEnumerable().Max(r => r.Field<Double>(dTable.Columns[1])) + line1.Interval;
            var yMin = dTable.AsEnumerable().Min(r => r.Field<Double>(dTable.Columns[2])) - line1.Interval;
            var yMax = dTable.AsEnumerable().Max(r => r.Field<Double>(dTable.Columns[2])) + line1.Interval;

            if (line1.Type == "Multi")
            {
                plot1.CreateMultiChart(line1.Name, line1.Station, dTable, xMin, xMax, yMin, yMax);
            }
                
            else
            {
                plot1.CreateSingleChart(line1.Name, dTable, xMin, xMax, yMin, yMax);
            }
            
            
            plot1.Show();
        }

        
		
	}
}
