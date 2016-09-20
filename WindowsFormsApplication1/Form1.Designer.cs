using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ColumnHeader datapoints;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(-1D, -1D);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.forceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ClearGraphButton = new System.Windows.Forms.Button();
            this.ForceGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.d = new WindowsFormsApplication1.UserControl1();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.availablePorts = new System.Windows.Forms.ComboBox();
            this.ForceReadingLabel = new System.Windows.Forms.Label();
            this.timeInputControl = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.tarebutton = new System.Windows.Forms.Button();
            this.startTestButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.exportDataButton = new System.Windows.Forms.Button();
            this.exportLocationBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            datapoints = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.ForceGraph)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // datapoints
            // 
            datapoints.Text = "DataPoint";
            // 
            // imageListLarge
            // 
            this.imageListLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListLarge.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageListSmall
            // 
            this.imageListSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListSmall.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // forceHeader
            // 
            this.forceHeader.Text = "Force";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            // 
            // ClearGraphButton
            // 
            this.ClearGraphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearGraphButton.Location = new System.Drawing.Point(104, 12);
            this.ClearGraphButton.MaximumSize = new System.Drawing.Size(75, 25);
            this.ClearGraphButton.Name = "ClearGraphButton";
            this.ClearGraphButton.Size = new System.Drawing.Size(75, 25);
            this.ClearGraphButton.TabIndex = 15;
            this.ClearGraphButton.Text = "Clear Graph";
            this.ClearGraphButton.UseVisualStyleBackColor = true;
            this.ClearGraphButton.Click += new System.EventHandler(this.ClearGraphButton_Click);
            // 
            // ForceGraph
            // 
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.MajorGrid.Interval = 10D;
            chartArea1.AxisX.Maximum = 10D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Time (s)";
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.MajorGrid.Interval = 1D;
            chartArea1.AxisY.Maximum = 10D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.Title = "Force";
            chartArea1.Name = "ChartArea1";
            this.ForceGraph.ChartAreas.Add(chartArea1);
            this.ForceGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.IsDockedInsideChartArea = false;
            legend1.Name = "Legend1";
            this.ForceGraph.Legends.Add(legend1);
            this.ForceGraph.Location = new System.Drawing.Point(0, 0);
            this.ForceGraph.Name = "ForceGraph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.White;
            series1.Name = "Test Runs";
            series1.Points.Add(dataPoint1);
            this.ForceGraph.Series.Add(series1);
            this.ForceGraph.Size = new System.Drawing.Size(1050, 250);
            this.ForceGraph.TabIndex = 14;
            this.ForceGraph.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Force vs Time";
            this.ForceGraph.Titles.Add(title1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.d);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(0, 250);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(1050, 233);
            this.panel1.TabIndex = 16;
            // 
            // d
            // 
            this.d.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d.Location = new System.Drawing.Point(319, 2);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(729, 185);
            this.d.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 185);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Set-Up";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.availablePorts, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ForceReadingLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.timeInputControl, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.ConnectButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tarebutton, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.startTestButton, 2, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(311, 165);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Ports";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Force Reading";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Test Interval (s)";
            // 
            // availablePorts
            // 
            this.availablePorts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.availablePorts.FormattingEnabled = true;
            this.availablePorts.Location = new System.Drawing.Point(109, 24);
            this.availablePorts.Margin = new System.Windows.Forms.Padding(0);
            this.availablePorts.Name = "availablePorts";
            this.availablePorts.Size = new System.Drawing.Size(93, 23);
            this.availablePorts.TabIndex = 3;
            // 
            // ForceReadingLabel
            // 
            this.ForceReadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ForceReadingLabel.AutoSize = true;
            this.ForceReadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForceReadingLabel.Location = new System.Drawing.Point(112, 74);
            this.ForceReadingLabel.Name = "ForceReadingLabel";
            this.ForceReadingLabel.Size = new System.Drawing.Size(87, 16);
            this.ForceReadingLabel.TabIndex = 4;
            this.ForceReadingLabel.Text = "0.0 lbs";
            // 
            // timeInputControl
            // 
            this.timeInputControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.timeInputControl.Location = new System.Drawing.Point(112, 119);
            this.timeInputControl.Name = "timeInputControl";
            this.timeInputControl.Size = new System.Drawing.Size(87, 21);
            this.timeInputControl.TabIndex = 5;
            this.timeInputControl.Text = "10";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectButton.Location = new System.Drawing.Point(208, 23);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(87, 23);
            this.ConnectButton.TabIndex = 6;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // tarebutton
            // 
            this.tarebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tarebutton.Location = new System.Drawing.Point(208, 70);
            this.tarebutton.Name = "tarebutton";
            this.tarebutton.Size = new System.Drawing.Size(87, 23);
            this.tarebutton.TabIndex = 7;
            this.tarebutton.Text = "Tare";
            this.tarebutton.UseVisualStyleBackColor = true;
            this.tarebutton.Click += new System.EventHandler(this.TareButton_Click);
            // 
            // startTestButton
            // 
            this.startTestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.startTestButton.Location = new System.Drawing.Point(208, 118);
            this.startTestButton.Name = "startTestButton";
            this.startTestButton.Size = new System.Drawing.Size(87, 23);
            this.startTestButton.TabIndex = 8;
            this.startTestButton.Text = "Start Test";
            this.startTestButton.UseVisualStyleBackColor = true;
            this.startTestButton.Click += new System.EventHandler(this.startTestButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.exportDataButton);
            this.groupBox1.Controls.Add(this.exportLocationBox);
            this.groupBox1.Controls.Add(this.browseButton);
            this.groupBox1.Controls.Add(this.ClearGraphButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1046, 44);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Options";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(331, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Export Location";
            // 
            // exportDataButton
            // 
            this.exportDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportDataButton.Location = new System.Drawing.Point(867, 10);
            this.exportDataButton.Name = "exportDataButton";
            this.exportDataButton.Size = new System.Drawing.Size(75, 25);
            this.exportDataButton.TabIndex = 17;
            this.exportDataButton.Text = "Export Data";
            this.exportDataButton.UseVisualStyleBackColor = true;
            this.exportDataButton.Click += new System.EventHandler(this.exportData_Click);
            // 
            // exportLocationBox
            // 
            this.exportLocationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportLocationBox.Location = new System.Drawing.Point(433, 14);
            this.exportLocationBox.Name = "exportLocationBox";
            this.exportLocationBox.Size = new System.Drawing.Size(342, 20);
            this.exportLocationBox.TabIndex = 19;
            this.exportLocationBox.Text = "My Documents";
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(781, 12);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 20;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ForceGraph);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 250);
            this.panel2.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1050, 483);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spray Force Interface";            
            ((System.ComponentModel.ISupportInitialize)(this.ForceGraph)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader forceHeader;
        private ImageList imageListLarge;
        private ImageList imageListSmall;
        private System.IO.Ports.SerialPort serialPort1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button ClearGraphButton;
        protected System.Windows.Forms.DataVisualization.Charting.Chart ForceGraph;
        private Panel panel1;
        private Button exportDataButton;
        private Timer timer1;
        private TextBox exportLocationBox;
        private Button browseButton;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox availablePorts;
        private Label ForceReadingLabel;
        private TextBox timeInputControl;
        private Button ConnectButton;
        private Button tarebutton;
        private Button startTestButton;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label4;
        private Panel panel2;
        private UserControl1 d;
    }
}

