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
            this.label1 = new System.Windows.Forms.Label();
            this.ForceReadingLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.tareButton = new System.Windows.Forms.Button();
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.force = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startTestButton = new System.Windows.Forms.Button();
            this.timeInputControl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.availablePorts = new System.Windows.Forms.ListBox();
            this.graphCheckBox = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.ForceGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ClearGraphButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            datapoints = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ForceGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // datapoints
            // 
            datapoints.Text = "DataPoint";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Force Reading:";
            // 
            // ForceReadingLabel
            // 
            this.ForceReadingLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ForceReadingLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ForceReadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForceReadingLabel.Location = new System.Drawing.Point(157, 63);
            this.ForceReadingLabel.Name = "ForceReadingLabel";
            this.ForceReadingLabel.Size = new System.Drawing.Size(75, 22);
            this.ForceReadingLabel.TabIndex = 2;
            this.ForceReadingLabel.Text = "0.0 lbf.";
            this.ForceReadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select Port";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButton.Location = new System.Drawing.Point(261, 26);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(83, 23);
            this.ConnectButton.TabIndex = 6;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // tareButton
            // 
            this.tareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tareButton.Location = new System.Drawing.Point(261, 62);
            this.tareButton.Name = "tareButton";
            this.tareButton.Size = new System.Drawing.Size(83, 23);
            this.tareButton.TabIndex = 9;
            this.tareButton.Text = "TARE";
            this.tareButton.UseVisualStyleBackColor = true;
            this.tareButton.Click += new System.EventHandler(this.TareButton_Click);
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
            // force
            // 
            this.force.Text = "Force";
            // 
            // startTestButton
            // 
            this.startTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTestButton.Location = new System.Drawing.Point(261, 98);
            this.startTestButton.Name = "startTestButton";
            this.startTestButton.Size = new System.Drawing.Size(83, 23);
            this.startTestButton.TabIndex = 0;
            this.startTestButton.Text = "Start Test";
            this.startTestButton.UseVisualStyleBackColor = true;
            this.startTestButton.Click += new System.EventHandler(this.startTestButton_Click);
            // 
            // timeInputControl
            // 
            this.timeInputControl.BackColor = System.Drawing.SystemColors.Control;
            this.timeInputControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeInputControl.Location = new System.Drawing.Point(157, 99);
            this.timeInputControl.Name = "timeInputControl";
            this.timeInputControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.timeInputControl.Size = new System.Drawing.Size(75, 22);
            this.timeInputControl.TabIndex = 7;
            this.timeInputControl.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Test Length (seconds)";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            // 
            // availablePorts
            // 
            this.availablePorts.BackColor = System.Drawing.SystemColors.Control;
            this.availablePorts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.availablePorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availablePorts.FormattingEnabled = true;
            this.availablePorts.ItemHeight = 18;
            this.availablePorts.Location = new System.Drawing.Point(157, 26);
            this.availablePorts.Name = "availablePorts";
            this.availablePorts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.availablePorts.Size = new System.Drawing.Size(75, 20);
            this.availablePorts.TabIndex = 12;
            // 
            // graphCheckBox
            // 
            this.graphCheckBox.AutoSize = true;
            this.graphCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphCheckBox.Location = new System.Drawing.Point(261, 144);
            this.graphCheckBox.Name = "graphCheckBox";
            this.graphCheckBox.Size = new System.Drawing.Size(88, 17);
            this.graphCheckBox.TabIndex = 13;
            this.graphCheckBox.Text = "Graph Result";
            this.graphCheckBox.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(79, 175);
            this.listBox1.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 196);
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(82, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 175);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 135);
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
            this.DataPointsLabel.Location = new System.Drawing.Point(144, 135);
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
            this.label8.Location = new System.Drawing.Point(6, 92);
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
            this.label6.Location = new System.Drawing.Point(6, 49);
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
            this.MinForceLabel.Location = new System.Drawing.Point(144, 92);
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
            this.MaxForceLabel.Location = new System.Drawing.Point(144, 49);
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
            this.averageForceLabel.Location = new System.Drawing.Point(144, 6);
            this.averageForceLabel.Margin = new System.Windows.Forms.Padding(3);
            this.averageForceLabel.Name = "averageForceLabel";
            this.averageForceLabel.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.averageForceLabel.Size = new System.Drawing.Size(47, 21);
            this.averageForceLabel.TabIndex = 2;
            this.averageForceLabel.Text = "0.0 ";
            this.averageForceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.graphCheckBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ConnectButton);
            this.groupBox1.Controls.Add(this.tareButton);
            this.groupBox1.Controls.Add(this.availablePorts);
            this.groupBox1.Controls.Add(this.timeInputControl);
            this.groupBox1.Controls.Add(this.ForceReadingLabel);
            this.groupBox1.Controls.Add(this.startTestButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 382);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(30, 138);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Test Interval (s)";
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
            this.ForceGraph.Location = new System.Drawing.Point(371, 0);
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
            this.ForceGraph.Size = new System.Drawing.Size(535, 382);
            this.ForceGraph.TabIndex = 14;
            this.ForceGraph.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Force vs Time";
            this.ForceGraph.Titles.Add(title1);
            // 
            // ClearGraphButton
            // 
            this.ClearGraphButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearGraphButton.Location = new System.Drawing.Point(831, 359);
            this.ClearGraphButton.MaximumSize = new System.Drawing.Size(75, 25);
            this.ClearGraphButton.Name = "ClearGraphButton";
            this.ClearGraphButton.Size = new System.Drawing.Size(75, 25);
            this.ClearGraphButton.TabIndex = 15;
            this.ClearGraphButton.Text = "Clear Graph";
            this.ClearGraphButton.UseVisualStyleBackColor = true;
            this.ClearGraphButton.Click += new System.EventHandler(this.ClearGraphButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(906, 382);
            this.Controls.Add(this.ClearGraphButton);
            this.Controls.Add(this.ForceGraph);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Spray Force Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ForceGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;      
        private System.Windows.Forms.Label ForceReadingLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.ColumnHeader force;
        private System.Windows.Forms.Button startTestButton;
        private System.Windows.Forms.TextBox timeInputControl;
        private System.Windows.Forms.Label label3;
        private ImageList imageListLarge;
        private ImageList imageListSmall;
        private System.IO.Ports.SerialPort serialPort1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        internal Button tareButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListBox availablePorts;
        private CheckBox graphCheckBox;
        private ListBox listBox1;
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
        private GroupBox groupBox1;
        private Label label2;
        private Button ClearGraphButton;
        protected System.Windows.Forms.DataVisualization.Charting.Chart ForceGraph;
        private ProgressBar progressBar1;
        private Timer timer1;
    }
}

