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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.DataPointsLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MinForceLabel = new System.Windows.Forms.Label();
            this.MaxForceLabel = new System.Windows.Forms.Label();
            this.averageForceLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.startTestButton = new System.Windows.Forms.Button();
            this.tareButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.availablePorts = new System.Windows.Forms.ListBox();
            this.timeInputControl = new System.Windows.Forms.TextBox();
            this.ForceReadingLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.exportLocationBox = new System.Windows.Forms.TextBox();
            this.TestNotesBox = new System.Windows.Forms.TextBox();
            this.exportDataButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.TestNameLabel = new System.Windows.Forms.Label();
            this.TestNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TestTypeBox = new System.Windows.Forms.TextBox();
            this.ItemBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TesterBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            datapoints = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.ForceGraph)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            this.ClearGraphButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ClearGraphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearGraphButton.Location = new System.Drawing.Point(828, 18);
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
            this.ForceGraph.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.IsDockedInsideChartArea = false;
            legend1.Name = "Legend1";
            this.ForceGraph.Legends.Add(legend1);
            this.ForceGraph.Location = new System.Drawing.Point(473, 0);
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
            this.ForceGraph.Size = new System.Drawing.Size(433, 348);
            this.ForceGraph.TabIndex = 14;
            this.ForceGraph.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Force vs Time";
            this.ForceGraph.Titles.Add(title1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 350);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test Set-Up";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(3, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 195);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test Results";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.DataPointsLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.MinForceLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.MaxForceLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.averageForceLabel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(82, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(382, 174);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.label7.Size = new System.Drawing.Size(103, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Data Points";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataPointsLabel
            // 
            this.DataPointsLabel.AutoSize = true;
            this.DataPointsLabel.Location = new System.Drawing.Point(195, 132);
            this.DataPointsLabel.Margin = new System.Windows.Forms.Padding(3);
            this.DataPointsLabel.Name = "DataPointsLabel";
            this.DataPointsLabel.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.DataPointsLabel.Size = new System.Drawing.Size(31, 21);
            this.DataPointsLabel.TabIndex = 4;
            this.DataPointsLabel.Text = "0";
            this.DataPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 90);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.label8.Size = new System.Drawing.Size(91, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Min Force";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.label5.Size = new System.Drawing.Size(126, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Average Force";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Max Force";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinForceLabel
            // 
            this.MinForceLabel.AutoSize = true;
            this.MinForceLabel.Location = new System.Drawing.Point(195, 90);
            this.MinForceLabel.Margin = new System.Windows.Forms.Padding(3);
            this.MinForceLabel.Name = "MinForceLabel";
            this.MinForceLabel.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.MinForceLabel.Size = new System.Drawing.Size(43, 21);
            this.MinForceLabel.TabIndex = 2;
            this.MinForceLabel.Text = "0.0";
            this.MinForceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaxForceLabel
            // 
            this.MaxForceLabel.AutoSize = true;
            this.MaxForceLabel.Location = new System.Drawing.Point(195, 48);
            this.MaxForceLabel.Margin = new System.Windows.Forms.Padding(3);
            this.MaxForceLabel.Name = "MaxForceLabel";
            this.MaxForceLabel.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.MaxForceLabel.Size = new System.Drawing.Size(43, 21);
            this.MaxForceLabel.TabIndex = 2;
            this.MaxForceLabel.Text = "0.0";
            this.MaxForceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averageForceLabel
            // 
            this.averageForceLabel.AutoSize = true;
            this.averageForceLabel.Location = new System.Drawing.Point(195, 6);
            this.averageForceLabel.Margin = new System.Windows.Forms.Padding(3);
            this.averageForceLabel.Name = "averageForceLabel";
            this.averageForceLabel.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.averageForceLabel.Size = new System.Drawing.Size(47, 21);
            this.averageForceLabel.TabIndex = 2;
            this.averageForceLabel.Text = "0.0 ";
            this.averageForceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(79, 164);
            this.listBox1.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.35616F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.94521F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.startTestButton, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.tareButton, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.ConnectButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.availablePorts, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.timeInputControl, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.ForceReadingLabel, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(467, 134);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Test Interval (s)";
            // 
            // startTestButton
            // 
            this.startTestButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTestButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.startTestButton.Location = new System.Drawing.Point(319, 98);
            this.startTestButton.Margin = new System.Windows.Forms.Padding(10);
            this.startTestButton.Name = "startTestButton";
            this.startTestButton.Size = new System.Drawing.Size(138, 26);
            this.startTestButton.TabIndex = 0;
            this.startTestButton.Text = "Start Test";
            this.startTestButton.UseVisualStyleBackColor = true;
            this.startTestButton.Click += new System.EventHandler(this.startTestButton_Click);
            // 
            // tareButton
            // 
            this.tareButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tareButton.Location = new System.Drawing.Point(319, 54);
            this.tareButton.Margin = new System.Windows.Forms.Padding(10);
            this.tareButton.Name = "tareButton";
            this.tareButton.Size = new System.Drawing.Size(138, 24);
            this.tareButton.TabIndex = 9;
            this.tareButton.Text = "TARE";
            this.tareButton.UseVisualStyleBackColor = true;
            this.tareButton.Click += new System.EventHandler(this.TareButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButton.Location = new System.Drawing.Point(319, 10);
            this.ConnectButton.Margin = new System.Windows.Forms.Padding(10);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(138, 24);
            this.ConnectButton.TabIndex = 6;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Force Reading:";
            // 
            // availablePorts
            // 
            this.availablePorts.BackColor = System.Drawing.SystemColors.Control;
            this.availablePorts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.availablePorts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.availablePorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availablePorts.FormattingEnabled = true;
            this.availablePorts.ItemHeight = 18;
            this.availablePorts.Location = new System.Drawing.Point(189, 10);
            this.availablePorts.Margin = new System.Windows.Forms.Padding(10);
            this.availablePorts.Name = "availablePorts";
            this.availablePorts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.availablePorts.Size = new System.Drawing.Size(110, 24);
            this.availablePorts.TabIndex = 12;
            // 
            // timeInputControl
            // 
            this.timeInputControl.BackColor = System.Drawing.SystemColors.Control;
            this.timeInputControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeInputControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeInputControl.Location = new System.Drawing.Point(189, 98);
            this.timeInputControl.Margin = new System.Windows.Forms.Padding(10);
            this.timeInputControl.Multiline = true;
            this.timeInputControl.Name = "timeInputControl";
            this.timeInputControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.timeInputControl.Size = new System.Drawing.Size(110, 26);
            this.timeInputControl.TabIndex = 7;
            this.timeInputControl.Text = "10";
            // 
            // ForceReadingLabel
            // 
            this.ForceReadingLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ForceReadingLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ForceReadingLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ForceReadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForceReadingLabel.Location = new System.Drawing.Point(189, 54);
            this.ForceReadingLabel.Margin = new System.Windows.Forms.Padding(10);
            this.ForceReadingLabel.Name = "ForceReadingLabel";
            this.ForceReadingLabel.Size = new System.Drawing.Size(110, 24);
            this.ForceReadingLabel.TabIndex = 2;
            this.ForceReadingLabel.Text = "0.0 lbf.";
            this.ForceReadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ForceGraph);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 350);
            this.panel1.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.exportLocationBox);
            this.groupBox3.Controls.Add(this.exportDataButton);
            this.groupBox3.Controls.Add(this.TestNotesBox);
            this.groupBox3.Controls.Add(this.tableLayoutPanel3);
            this.groupBox3.Controls.Add(this.ClearGraphButton);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(906, 114);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Test Information";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(639, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exportLocationBox
            // 
            this.exportLocationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportLocationBox.Location = new System.Drawing.Point(558, 88);
            this.exportLocationBox.Name = "exportLocationBox";
            this.exportLocationBox.Size = new System.Drawing.Size(342, 20);
            this.exportLocationBox.TabIndex = 19;
            this.exportLocationBox.Text = "My Documents";
            // 
            // TestNotesBox
            // 
            this.TestNotesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestNotesBox.Location = new System.Drawing.Point(275, 50);
            this.TestNotesBox.Multiline = true;
            this.TestNotesBox.Name = "TestNotesBox";
            this.TestNotesBox.Size = new System.Drawing.Size(265, 60);
            this.TestNotesBox.TabIndex = 18;
            this.TestNotesBox.Text = "Test Notes";
            // 
            // exportDataButton
            // 
            this.exportDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportDataButton.Location = new System.Drawing.Point(558, 59);
            this.exportDataButton.Name = "exportDataButton";
            this.exportDataButton.Size = new System.Drawing.Size(75, 25);
            this.exportDataButton.TabIndex = 17;
            this.exportDataButton.Text = "Export Data";
            this.exportDataButton.UseVisualStyleBackColor = true;
            this.exportDataButton.Click += new System.EventHandler(this.exportData_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.TestNameLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.TestNameBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.TestTypeBox, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.ItemBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.TesterBox, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(537, 93);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 65);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Test Type";
            // 
            // TestNameLabel
            // 
            this.TestNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TestNameLabel.AutoSize = true;
            this.TestNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestNameLabel.Location = new System.Drawing.Point(3, 3);
            this.TestNameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.TestNameLabel.Name = "TestNameLabel";
            this.TestNameLabel.Size = new System.Drawing.Size(128, 25);
            this.TestNameLabel.TabIndex = 1;
            this.TestNameLabel.Text = "Test Name";
            // 
            // TestNameBox
            // 
            this.TestNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestNameBox.Location = new System.Drawing.Point(137, 3);
            this.TestNameBox.Name = "TestNameBox";
            this.TestNameBox.Size = new System.Drawing.Size(100, 20);
            this.TestNameBox.TabIndex = 5;
            this.TestNameBox.Text = "Test1";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Shower Head ";
            // 
            // TestTypeBox
            // 
            this.TestTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestTypeBox.Location = new System.Drawing.Point(137, 65);
            this.TestTypeBox.Name = "TestTypeBox";
            this.TestTypeBox.Size = new System.Drawing.Size(100, 20);
            this.TestTypeBox.TabIndex = 6;
            this.TestTypeBox.Text = "Program Test";
            // 
            // ItemBox
            // 
            this.ItemBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemBox.Location = new System.Drawing.Point(137, 34);
            this.ItemBox.Name = "ItemBox";
            this.ItemBox.Size = new System.Drawing.Size(100, 20);
            this.ItemBox.TabIndex = 11;
            this.ItemBox.Text = "None";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(271, 3);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Test Conducted By";
            // 
            // TesterBox
            // 
            this.TesterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TesterBox.Location = new System.Drawing.Point(405, 3);
            this.TesterBox.Name = "TesterBox";
            this.TesterBox.Size = new System.Drawing.Size(100, 20);
            this.TesterBox.TabIndex = 13;
            this.TesterBox.Text = "Rob";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(906, 464);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Spray Force Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ForceGraph)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
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
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label7;
        private Label DataPointsLabel;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label MinForceLabel;
        private Label MaxForceLabel;
        private Label averageForceLabel;
        private ListBox listBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Button startTestButton;
        internal Button tareButton;
        private Button ConnectButton;
        private Label label4;
        private Label label1;
        private ListBox availablePorts;
        private TextBox timeInputControl;
        private Label ForceReadingLabel;
        private Panel panel1;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel3;
        private Label TestNameLabel;
        private Label label9;
        private TextBox TestNameBox;
        private TextBox TestTypeBox;
        private Button exportDataButton;
        private TextBox TestNotesBox;
        private TextBox ItemBox;
        private Label label3;
        private Label label10;
        private TextBox TesterBox;
        private Timer timer1;
        private TextBox exportLocationBox;
        private Button button1;
    }
}

