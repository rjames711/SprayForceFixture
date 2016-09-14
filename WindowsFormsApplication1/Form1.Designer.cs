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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            datapoints = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.ForceGraph)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.testDetailsLayoutBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.ForceGraph.Size = new System.Drawing.Size(1041, 250);
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
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(0, 250);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(1041, 233);
            this.panel1.TabIndex = 16;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(293, 165);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 20);
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
            this.label2.Location = new System.Drawing.Point(26, 67);
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
            this.label3.Location = new System.Drawing.Point(19, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Test Interval (s)";
            // 
            // availablePorts
            // 
            this.availablePorts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.availablePorts.FormattingEnabled = true;
            this.availablePorts.Location = new System.Drawing.Point(103, 23);
            this.availablePorts.Margin = new System.Windows.Forms.Padding(0);
            this.availablePorts.Name = "availablePorts";
            this.availablePorts.Size = new System.Drawing.Size(87, 23);
            this.availablePorts.TabIndex = 3;
            // 
            // ForceReadingLabel
            // 
            this.ForceReadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ForceReadingLabel.AutoSize = true;
            this.ForceReadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForceReadingLabel.Location = new System.Drawing.Point(106, 74);
            this.ForceReadingLabel.Name = "ForceReadingLabel";
            this.ForceReadingLabel.Size = new System.Drawing.Size(81, 16);
            this.ForceReadingLabel.TabIndex = 4;
            this.ForceReadingLabel.Text = "0.0 lbs";
            // 
            // timeInputControl
            // 
            this.timeInputControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.timeInputControl.Location = new System.Drawing.Point(106, 119);
            this.timeInputControl.Name = "timeInputControl";
            this.timeInputControl.Size = new System.Drawing.Size(81, 21);
            this.timeInputControl.TabIndex = 5;
            this.timeInputControl.Text = "10";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectButton.Location = new System.Drawing.Point(196, 23);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(81, 23);
            this.ConnectButton.TabIndex = 6;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // tarebutton
            // 
            this.tarebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tarebutton.Location = new System.Drawing.Point(196, 70);
            this.tarebutton.Name = "tarebutton";
            this.tarebutton.Size = new System.Drawing.Size(81, 23);
            this.tarebutton.TabIndex = 7;
            this.tarebutton.Text = "Tare";
            this.tarebutton.UseVisualStyleBackColor = true;
            this.tarebutton.Click += new System.EventHandler(this.TareButton_Click);
            // 
            // startTestButton
            // 
            this.startTestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.startTestButton.Location = new System.Drawing.Point(196, 118);
            this.startTestButton.Name = "startTestButton";
            this.startTestButton.Size = new System.Drawing.Size(81, 23);
            this.startTestButton.TabIndex = 8;
            this.startTestButton.Text = "Start Test";
            this.startTestButton.UseVisualStyleBackColor = true;
            this.startTestButton.Click += new System.EventHandler(this.startTestButton_Click);
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
            // exportLocationBox
            // 
            this.exportLocationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportLocationBox.Location = new System.Drawing.Point(433, 14);
            this.exportLocationBox.Name = "exportLocationBox";
            this.exportLocationBox.Size = new System.Drawing.Size(342, 20);
            this.exportLocationBox.TabIndex = 19;
            this.exportLocationBox.Text = "My Documents";
            // 
            // testDetailsLayoutBox
            // 
            this.testDetailsLayoutBox.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.testDetailsLayoutBox.ColumnCount = 4;
            this.testDetailsLayoutBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99999F));
            this.testDetailsLayoutBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.testDetailsLayoutBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.testDetailsLayoutBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.testDetailsLayoutBox.Controls.Add(this.textBox1, 0, 3);
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
            this.testDetailsLayoutBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testDetailsLayoutBox.Location = new System.Drawing.Point(3, 17);
            this.testDetailsLayoutBox.Name = "testDetailsLayoutBox";
            this.testDetailsLayoutBox.RowCount = 4;
            this.testDetailsLayoutBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.testDetailsLayoutBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.testDetailsLayoutBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.testDetailsLayoutBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.testDetailsLayoutBox.Size = new System.Drawing.Size(432, 165);
            this.testDetailsLayoutBox.TabIndex = 16;
            // 
            // testNameComboBox
            // 
            this.testNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.testNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.testNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testNameComboBox.FormattingEnabled = true;
            this.testNameComboBox.Location = new System.Drawing.Point(113, 6);
            this.testNameComboBox.Name = "testNameComboBox";
            this.testNameComboBox.Size = new System.Drawing.Size(98, 21);
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
            this.detailLabel3.Location = new System.Drawing.Point(6, 86);
            this.detailLabel3.Margin = new System.Windows.Forms.Padding(3);
            this.detailLabel3.Name = "detailLabel3";
            this.detailLabel3.Size = new System.Drawing.Size(98, 31);
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
            this.detailLabel1.Location = new System.Drawing.Point(6, 6);
            this.detailLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.detailLabel1.Name = "detailLabel1";
            this.detailLabel1.Size = new System.Drawing.Size(98, 31);
            this.detailLabel1.TabIndex = 1;
            this.detailLabel1.Text = "Test Name";
            // 
            // TestNotesBox
            // 
            this.testDetailsLayoutBox.SetColumnSpan(this.TestNotesBox, 2);
            this.TestNotesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestNotesBox.Location = new System.Drawing.Point(220, 86);
            this.TestNotesBox.Multiline = true;
            this.TestNotesBox.Name = "TestNotesBox";
            this.testDetailsLayoutBox.SetRowSpan(this.TestNotesBox, 2);
            this.TestNotesBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TestNotesBox.Size = new System.Drawing.Size(206, 73);
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
            this.detailLabel2.Location = new System.Drawing.Point(6, 46);
            this.detailLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.detailLabel2.Name = "detailLabel2";
            this.detailLabel2.Size = new System.Drawing.Size(98, 31);
            this.detailLabel2.TabIndex = 10;
            this.detailLabel2.Text = "Sample";
            // 
            // MeasureFlowBox
            // 
            this.MeasureFlowBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeasureFlowBox.Location = new System.Drawing.Point(113, 86);
            this.MeasureFlowBox.Name = "MeasureFlowBox";
            this.MeasureFlowBox.Size = new System.Drawing.Size(98, 20);
            this.MeasureFlowBox.TabIndex = 6;
            this.MeasureFlowBox.Text = "2.0";
            // 
            // ItemBox
            // 
            this.ItemBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemBox.Location = new System.Drawing.Point(113, 46);
            this.ItemBox.Name = "ItemBox";
            this.ItemBox.Size = new System.Drawing.Size(98, 20);
            this.ItemBox.TabIndex = 11;
            this.ItemBox.Text = "2";
            // 
            // detailLabel6
            // 
            this.detailLabel6.AutoSize = true;
            this.detailLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailLabel6.Location = new System.Drawing.Point(220, 46);
            this.detailLabel6.Margin = new System.Windows.Forms.Padding(3);
            this.detailLabel6.Name = "detailLabel6";
            this.detailLabel6.Size = new System.Drawing.Size(95, 30);
            this.detailLabel6.TabIndex = 3;
            this.detailLabel6.Text = "Test Conducted By";
            // 
            // TesterBox
            // 
            this.TesterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TesterBox.Location = new System.Drawing.Point(327, 46);
            this.TesterBox.Name = "TesterBox";
            this.TesterBox.Size = new System.Drawing.Size(99, 20);
            this.TesterBox.TabIndex = 13;
            this.TesterBox.Text = "Rob";
            // 
            // MeasuredPressureBox
            // 
            this.MeasuredPressureBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeasuredPressureBox.Location = new System.Drawing.Point(327, 6);
            this.MeasuredPressureBox.Name = "MeasuredPressureBox";
            this.MeasuredPressureBox.Size = new System.Drawing.Size(99, 20);
            this.MeasuredPressureBox.TabIndex = 13;
            this.MeasuredPressureBox.Text = "45";
            // 
            // detailLabel5
            // 
            this.detailLabel5.AutoSize = true;
            this.detailLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailLabel5.Location = new System.Drawing.Point(220, 6);
            this.detailLabel5.Margin = new System.Windows.Forms.Padding(3);
            this.detailLabel5.Name = "detailLabel5";
            this.detailLabel5.Size = new System.Drawing.Size(66, 30);
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
            this.detailLabel4.Location = new System.Drawing.Point(6, 126);
            this.detailLabel4.Margin = new System.Windows.Forms.Padding(3);
            this.detailLabel4.Name = "detailLabel4";
            this.detailLabel4.Size = new System.Drawing.Size(98, 33);
            this.detailLabel4.TabIndex = 22;
            this.detailLabel4.Text = "Temperature";
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
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(229, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(75, 165);
            this.listBox1.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.17182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.82818F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.DataPointsLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.MinForceLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.MaxForceLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.averageForceLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(226, 165);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 136);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Data Points";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataPointsLabel
            // 
            this.DataPointsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataPointsLabel.AutoSize = true;
            this.DataPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataPointsLabel.Location = new System.Drawing.Point(161, 136);
            this.DataPointsLabel.Margin = new System.Windows.Forms.Padding(3);
            this.DataPointsLabel.Name = "DataPointsLabel";
            this.DataPointsLabel.Size = new System.Drawing.Size(14, 13);
            this.DataPointsLabel.TabIndex = 4;
            this.DataPointsLabel.Text = "0";
            this.DataPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 95);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Min Force";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Max Force";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinForceLabel
            // 
            this.MinForceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MinForceLabel.AutoSize = true;
            this.MinForceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinForceLabel.Location = new System.Drawing.Point(156, 95);
            this.MinForceLabel.Margin = new System.Windows.Forms.Padding(3);
            this.MinForceLabel.Name = "MinForceLabel";
            this.MinForceLabel.Size = new System.Drawing.Size(25, 13);
            this.MinForceLabel.TabIndex = 2;
            this.MinForceLabel.Text = "0.0";
            this.MinForceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaxForceLabel
            // 
            this.MaxForceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MaxForceLabel.AutoSize = true;
            this.MaxForceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxForceLabel.Location = new System.Drawing.Point(156, 55);
            this.MaxForceLabel.Margin = new System.Windows.Forms.Padding(3);
            this.MaxForceLabel.Name = "MaxForceLabel";
            this.MaxForceLabel.Size = new System.Drawing.Size(25, 13);
            this.MaxForceLabel.TabIndex = 2;
            this.MaxForceLabel.Text = "0.0";
            this.MaxForceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averageForceLabel
            // 
            this.averageForceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.averageForceLabel.AutoSize = true;
            this.averageForceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageForceLabel.Location = new System.Drawing.Point(154, 15);
            this.averageForceLabel.Margin = new System.Windows.Forms.Padding(3);
            this.averageForceLabel.Name = "averageForceLabel";
            this.averageForceLabel.Size = new System.Drawing.Size(29, 13);
            this.averageForceLabel.TabIndex = 2;
            this.averageForceLabel.Text = "0.0 ";
            this.averageForceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Average Force";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.groupBox1.Size = new System.Drawing.Size(1037, 44);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Options";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 185);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Set-Up";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.testDetailsLayoutBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(301, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 185);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Test Details";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Controls.Add(this.tableLayoutPanel1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(739, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(300, 185);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Results Summary";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(113, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 20);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = "100";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.ForceGraph);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1041, 250);
            this.panel2.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1041, 483);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spray Force Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ForceGraph)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.testDetailsLayoutBox.ResumeLayout(false);
            this.testDetailsLayoutBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
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
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label4;
        private Panel panel2;
    }
}

