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
            this.browseButton = new System.Windows.Forms.Button();
            this.exportLocationBox = new System.Windows.Forms.TextBox();
            this.testDetailsLayoutBox = new System.Windows.Forms.TableLayoutPanel();
            this.testNameComboBox = new System.Windows.Forms.ComboBox();
            this.detailLabel3 = new System.Windows.Forms.Label();
            this.detailLabel1 = new System.Windows.Forms.Label();
            this.TestNotesBox = new System.Windows.Forms.TextBox();
            this.detailLabel2 = new System.Windows.Forms.Label();
            this.MeasureFlowBox = new System.Windows.Forms.TextBox();
            this.ItemBox = new System.Windows.Forms.TextBox();
            this.detailLabel6 = new System.Windows.Forms.Label();
            this.TesterBox = new System.Windows.Forms.TextBox();
            this.MeasuredPressureBox = new System.Windows.Forms.TextBox();
            this.detailLabel5 = new System.Windows.Forms.Label();
            this.detailLabel4 = new System.Windows.Forms.Label();
            this.exportDataButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.DataPointsLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MinForceLabel = new System.Windows.Forms.Label();
            this.MaxForceLabel = new System.Windows.Forms.Label();
            this.averageForceLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            datapoints = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.ForceGraph)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.testDetailsLayoutBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.ClearGraphButton.Location = new System.Drawing.Point(879, 2);
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
            this.ForceGraph.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.IsDockedInsideChartArea = false;
            legend1.Name = "Legend1";
            this.ForceGraph.Legends.Add(legend1);
            this.ForceGraph.Location = new System.Drawing.Point(0, 233);
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
            this.ForceGraph.Size = new System.Drawing.Size(956, 250);
            this.ForceGraph.TabIndex = 14;
            this.ForceGraph.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Force vs Time";
            this.ForceGraph.Titles.Add(title1);
            this.ForceGraph.Click += new System.EventHandler(this.ForceGraph_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.browseButton);
            this.panel1.Controls.Add(this.exportLocationBox);
            this.panel1.Controls.Add(this.testDetailsLayoutBox);
            this.panel1.Controls.Add(this.exportDataButton);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.ClearGraphButton);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(956, 233);
            this.panel1.TabIndex = 16;
            // 
            // tableLayoutPanel2
            // 
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 12);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(201, 162);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Ports";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Force Reading";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Test Interval (s)";
            // 
            // availablePorts
            // 
            this.availablePorts.FormattingEnabled = true;
            this.availablePorts.Location = new System.Drawing.Point(73, 13);
            this.availablePorts.Name = "availablePorts";
            this.availablePorts.Size = new System.Drawing.Size(54, 21);
            this.availablePorts.TabIndex = 3;
            // 
            // ForceReadingLabel
            // 
            this.ForceReadingLabel.AutoSize = true;
            this.ForceReadingLabel.Location = new System.Drawing.Point(73, 57);
            this.ForceReadingLabel.Name = "ForceReadingLabel";
            this.ForceReadingLabel.Size = new System.Drawing.Size(35, 13);
            this.ForceReadingLabel.TabIndex = 4;
            this.ForceReadingLabel.Text = "label4";
            // 
            // timeInputControl
            // 
            this.timeInputControl.Location = new System.Drawing.Point(73, 107);
            this.timeInputControl.Name = "timeInputControl";
            this.timeInputControl.Size = new System.Drawing.Size(54, 20);
            this.timeInputControl.TabIndex = 5;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(133, 13);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(55, 23);
            this.ConnectButton.TabIndex = 6;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // tarebutton
            // 
            this.tarebutton.Location = new System.Drawing.Point(133, 60);
            this.tarebutton.Name = "tarebutton";
            this.tarebutton.Size = new System.Drawing.Size(55, 23);
            this.tarebutton.TabIndex = 7;
            this.tarebutton.Text = "tare";
            this.tarebutton.UseVisualStyleBackColor = true;
            this.tarebutton.Click += new System.EventHandler(this.TareButton_Click);
            // 
            // startTestButton
            // 
            this.startTestButton.Location = new System.Drawing.Point(133, 107);
            this.startTestButton.Name = "startTestButton";
            this.startTestButton.Size = new System.Drawing.Size(55, 23);
            this.startTestButton.TabIndex = 8;
            this.startTestButton.Text = "Start Test";
            this.startTestButton.UseVisualStyleBackColor = true;
            this.startTestButton.Click += new System.EventHandler(this.startTestButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(517, 262);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 20;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // exportLocationBox
            // 
            this.exportLocationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportLocationBox.Location = new System.Drawing.Point(602, 262);
            this.exportLocationBox.Name = "exportLocationBox";
            this.exportLocationBox.Size = new System.Drawing.Size(342, 20);
            this.exportLocationBox.TabIndex = 19;
            this.exportLocationBox.Text = "My Documents";
            // 
            // testDetailsLayoutBox
            // 
            this.testDetailsLayoutBox.ColumnCount = 4;
            this.testDetailsLayoutBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99999F));
            this.testDetailsLayoutBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.testDetailsLayoutBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.testDetailsLayoutBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.testDetailsLayoutBox.Controls.Add(this.testNameComboBox, 1, 0);
            this.testDetailsLayoutBox.Controls.Add(this.detailLabel3, 0, 2);
            this.testDetailsLayoutBox.Controls.Add(this.detailLabel1, 0, 0);
            this.testDetailsLayoutBox.Controls.Add(this.TestNotesBox, 2, 2);
            this.testDetailsLayoutBox.Controls.Add(this.detailLabel2, 0, 1);
            this.testDetailsLayoutBox.Controls.Add(this.MeasureFlowBox, 1, 2);
            this.testDetailsLayoutBox.Controls.Add(this.ItemBox, 1, 1);
            this.testDetailsLayoutBox.Controls.Add(this.detailLabel6, 2, 1);
            this.testDetailsLayoutBox.Controls.Add(this.TesterBox, 3, 1);
            this.testDetailsLayoutBox.Controls.Add(this.MeasuredPressureBox, 3, 0);
            this.testDetailsLayoutBox.Controls.Add(this.detailLabel5, 2, 0);
            this.testDetailsLayoutBox.Controls.Add(this.detailLabel4, 0, 3);
            this.testDetailsLayoutBox.Location = new System.Drawing.Point(206, 12);
            this.testDetailsLayoutBox.Name = "testDetailsLayoutBox";
            this.testDetailsLayoutBox.RowCount = 3;
            this.testDetailsLayoutBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.testDetailsLayoutBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.testDetailsLayoutBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.testDetailsLayoutBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.testDetailsLayoutBox.Size = new System.Drawing.Size(519, 161);
            this.testDetailsLayoutBox.TabIndex = 16;
            // 
            // testNameComboBox
            // 
            this.testNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.testNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.testNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testNameComboBox.FormattingEnabled = true;
            this.testNameComboBox.Location = new System.Drawing.Point(132, 3);
            this.testNameComboBox.Name = "testNameComboBox";
            this.testNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.testNameComboBox.TabIndex = 21;
            this.testNameComboBox.Text = "S-2272";
            // 
            // detailLabel3
            // 
            this.detailLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailLabel3.AutoSize = true;
            this.detailLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailLabel3.Location = new System.Drawing.Point(3, 83);
            this.detailLabel3.Margin = new System.Windows.Forms.Padding(3);
            this.detailLabel3.Name = "detailLabel3";
            this.detailLabel3.Size = new System.Drawing.Size(123, 34);
            this.detailLabel3.TabIndex = 12;
            this.detailLabel3.Text = "Measured Flow";
            // 
            // detailLabel1
            // 
            this.detailLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailLabel1.AutoSize = true;
            this.detailLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailLabel1.Location = new System.Drawing.Point(3, 3);
            this.detailLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.detailLabel1.Name = "detailLabel1";
            this.detailLabel1.Size = new System.Drawing.Size(123, 34);
            this.detailLabel1.TabIndex = 1;
            this.detailLabel1.Text = "Test Name";
            // 
            // TestNotesBox
            // 
            this.testDetailsLayoutBox.SetColumnSpan(this.TestNotesBox, 2);
            this.TestNotesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestNotesBox.Location = new System.Drawing.Point(261, 83);
            this.TestNotesBox.Multiline = true;
            this.TestNotesBox.Name = "TestNotesBox";
            this.testDetailsLayoutBox.SetRowSpan(this.TestNotesBox, 2);
            this.TestNotesBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TestNotesBox.Size = new System.Drawing.Size(255, 75);
            this.TestNotesBox.TabIndex = 18;
            this.TestNotesBox.Text = "Test Fixture:   No Flow Control. Temp 100 F direct connection no seal ";
            // 
            // detailLabel2
            // 
            this.detailLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailLabel2.AutoSize = true;
            this.detailLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailLabel2.Location = new System.Drawing.Point(3, 43);
            this.detailLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.detailLabel2.Name = "detailLabel2";
            this.detailLabel2.Size = new System.Drawing.Size(123, 34);
            this.detailLabel2.TabIndex = 10;
            this.detailLabel2.Text = "Sample";
            // 
            // MeasureFlowBox
            // 
            this.MeasureFlowBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeasureFlowBox.Location = new System.Drawing.Point(132, 83);
            this.MeasureFlowBox.Name = "MeasureFlowBox";
            this.MeasureFlowBox.Size = new System.Drawing.Size(100, 20);
            this.MeasureFlowBox.TabIndex = 6;
            this.MeasureFlowBox.Text = "2.0";
            // 
            // ItemBox
            // 
            this.ItemBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemBox.Location = new System.Drawing.Point(132, 43);
            this.ItemBox.Name = "ItemBox";
            this.ItemBox.Size = new System.Drawing.Size(100, 20);
            this.ItemBox.TabIndex = 11;
            this.ItemBox.Text = "2";
            // 
            // detailLabel6
            // 
            this.detailLabel6.AutoSize = true;
            this.detailLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailLabel6.Location = new System.Drawing.Point(261, 43);
            this.detailLabel6.Margin = new System.Windows.Forms.Padding(3);
            this.detailLabel6.Name = "detailLabel6";
            this.detailLabel6.Size = new System.Drawing.Size(108, 15);
            this.detailLabel6.TabIndex = 3;
            this.detailLabel6.Text = "Test Conducted By";
            // 
            // TesterBox
            // 
            this.TesterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TesterBox.Location = new System.Drawing.Point(390, 43);
            this.TesterBox.Name = "TesterBox";
            this.TesterBox.Size = new System.Drawing.Size(100, 20);
            this.TesterBox.TabIndex = 13;
            this.TesterBox.Text = "Rob";
            // 
            // MeasuredPressureBox
            // 
            this.MeasuredPressureBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeasuredPressureBox.Location = new System.Drawing.Point(390, 3);
            this.MeasuredPressureBox.Name = "MeasuredPressureBox";
            this.MeasuredPressureBox.Size = new System.Drawing.Size(100, 20);
            this.MeasuredPressureBox.TabIndex = 13;
            this.MeasuredPressureBox.Text = "3.0";
            // 
            // detailLabel5
            // 
            this.detailLabel5.AutoSize = true;
            this.detailLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailLabel5.Location = new System.Drawing.Point(261, 3);
            this.detailLabel5.Margin = new System.Windows.Forms.Padding(3);
            this.detailLabel5.Name = "detailLabel5";
            this.detailLabel5.Size = new System.Drawing.Size(115, 15);
            this.detailLabel5.TabIndex = 3;
            this.detailLabel5.Text = "Measured Pressure";
            // 
            // detailLabel4
            // 
            this.detailLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailLabel4.AutoSize = true;
            this.detailLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailLabel4.Location = new System.Drawing.Point(3, 123);
            this.detailLabel4.Margin = new System.Windows.Forms.Padding(3);
            this.detailLabel4.Name = "detailLabel4";
            this.detailLabel4.Size = new System.Drawing.Size(123, 35);
            this.detailLabel4.TabIndex = 22;
            this.detailLabel4.Text = "Temperature";
            // 
            // exportDataButton
            // 
            this.exportDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportDataButton.Location = new System.Drawing.Point(425, 260);
            this.exportDataButton.Name = "exportDataButton";
            this.exportDataButton.Size = new System.Drawing.Size(75, 25);
            this.exportDataButton.TabIndex = 17;
            this.exportDataButton.Text = "Export Data";
            this.exportDataButton.UseVisualStyleBackColor = true;
            this.exportDataButton.Click += new System.EventHandler(this.exportData_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(731, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(75, 164);
            this.listBox1.TabIndex = 10;
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
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.MinForceLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.MaxForceLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.averageForceLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(821, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(148, 164);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 126);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.label7.Size = new System.Drawing.Size(51, 31);
            this.label7.TabIndex = 5;
            this.label7.Text = "Data Points";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataPointsLabel
            // 
            this.DataPointsLabel.AutoSize = true;
            this.DataPointsLabel.Location = new System.Drawing.Point(78, 126);
            this.DataPointsLabel.Margin = new System.Windows.Forms.Padding(3);
            this.DataPointsLabel.Name = "DataPointsLabel";
            this.DataPointsLabel.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.DataPointsLabel.Size = new System.Drawing.Size(28, 18);
            this.DataPointsLabel.TabIndex = 4;
            this.DataPointsLabel.Text = "0";
            this.DataPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 86);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.label8.Size = new System.Drawing.Size(49, 31);
            this.label8.TabIndex = 3;
            this.label8.Text = "Min Force";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.label6.Size = new System.Drawing.Size(49, 31);
            this.label6.TabIndex = 1;
            this.label6.Text = "Max Force";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinForceLabel
            // 
            this.MinForceLabel.AutoSize = true;
            this.MinForceLabel.Location = new System.Drawing.Point(78, 86);
            this.MinForceLabel.Margin = new System.Windows.Forms.Padding(3);
            this.MinForceLabel.Name = "MinForceLabel";
            this.MinForceLabel.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.MinForceLabel.Size = new System.Drawing.Size(37, 18);
            this.MinForceLabel.TabIndex = 2;
            this.MinForceLabel.Text = "0.0";
            this.MinForceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaxForceLabel
            // 
            this.MaxForceLabel.AutoSize = true;
            this.MaxForceLabel.Location = new System.Drawing.Point(78, 46);
            this.MaxForceLabel.Margin = new System.Windows.Forms.Padding(3);
            this.MaxForceLabel.Name = "MaxForceLabel";
            this.MaxForceLabel.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.MaxForceLabel.Size = new System.Drawing.Size(37, 18);
            this.MaxForceLabel.TabIndex = 2;
            this.MaxForceLabel.Text = "0.0";
            this.MaxForceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averageForceLabel
            // 
            this.averageForceLabel.AutoSize = true;
            this.averageForceLabel.Location = new System.Drawing.Point(78, 6);
            this.averageForceLabel.Margin = new System.Windows.Forms.Padding(3);
            this.averageForceLabel.Name = "averageForceLabel";
            this.averageForceLabel.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.averageForceLabel.Size = new System.Drawing.Size(40, 18);
            this.averageForceLabel.TabIndex = 2;
            this.averageForceLabel.Text = "0.0 ";
            this.averageForceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.label5.Size = new System.Drawing.Size(62, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Average Force";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ClientSize = new System.Drawing.Size(956, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ForceGraph);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spray Force Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ForceGraph)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.testDetailsLayoutBox.ResumeLayout(false);
            this.testDetailsLayoutBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private TableLayoutPanel testDetailsLayoutBox;
        private Label detailLabel1;
        private TextBox MeasureFlowBox;
        private Button exportDataButton;
        private TextBox TestNotesBox;
        private TextBox ItemBox;
        private Label detailLabel2;
        private Label detailLabel3;
        private TextBox TesterBox;
        private Timer timer1;
        private TextBox exportLocationBox;
        private Button browseButton;
        private Label detailLabel6;
        private TextBox MeasuredPressureBox;
        private Label detailLabel5;
        private ComboBox testNameComboBox;
        private Label detailLabel4;
        private ListBox listBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label7;
        private Label DataPointsLabel;
        private Label label8;
        private Label label6;
        private Label MinForceLabel;
        private Label MaxForceLabel;
        private Label averageForceLabel;
        private Label label5;
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
    }
}

