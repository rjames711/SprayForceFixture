using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.ItemBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MeasuredPressureBox = new System.Windows.Forms.TextBox();
            this.MeasureFlowBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.temperatureBox = new System.Windows.Forms.TextBox();
            this.TesterBox = new System.Windows.Forms.TextBox();
            this.testNameComboBox = new System.Windows.Forms.ComboBox();
            this.TestNotesBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.averageForceLabel = new System.Windows.Forms.Label();
            this.MaxForceLabel = new System.Windows.Forms.Label();
            this.MinForceLabel = new System.Windows.Forms.Label();
            this.DataPointsLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ExportRadioButton = new System.Windows.Forms.RadioButton();
            this.DontExportRadioButton = new System.Windows.Forms.RadioButton();
            this.deleteRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test Details";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ItemBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.MeasuredPressureBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.MeasureFlowBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.temperatureBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.TesterBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.testNameComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TestNotesBox, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(457, 104);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Temperature";
            // 
            // ItemBox
            // 
            this.ItemBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ItemBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApplication1.Properties.Settings.Default, "item", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ItemBox.Location = new System.Drawing.Point(116, 29);
            this.ItemBox.Margin = new System.Windows.Forms.Padding(0);
            this.ItemBox.Name = "ItemBox";
            this.ItemBox.Size = new System.Drawing.Size(100, 20);
            this.ItemBox.TabIndex = 7;
            this.ItemBox.Text = global::WindowsFormsApplication1.Properties.Settings.Default.item;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sample";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Measured Flow";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Measured Pressure";
            // 
            // MeasuredPressureBox
            // 
            this.MeasuredPressureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MeasuredPressureBox.Location = new System.Drawing.Point(116, 79);
            this.MeasuredPressureBox.Margin = new System.Windows.Forms.Padding(0);
            this.MeasuredPressureBox.Name = "MeasuredPressureBox";
            this.MeasuredPressureBox.Size = new System.Drawing.Size(100, 20);
            this.MeasuredPressureBox.TabIndex = 6;
            // 
            // MeasureFlowBox
            // 
            this.MeasureFlowBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MeasureFlowBox.Location = new System.Drawing.Point(116, 54);
            this.MeasureFlowBox.Margin = new System.Windows.Forms.Padding(0);
            this.MeasureFlowBox.Name = "MeasureFlowBox";
            this.MeasureFlowBox.Size = new System.Drawing.Size(100, 20);
            this.MeasureFlowBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Test Conducted by";
            // 
            // temperatureBox
            // 
            this.temperatureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.temperatureBox.Location = new System.Drawing.Point(342, 4);
            this.temperatureBox.Margin = new System.Windows.Forms.Padding(0);
            this.temperatureBox.Name = "temperatureBox";
            this.temperatureBox.Size = new System.Drawing.Size(100, 20);
            this.temperatureBox.TabIndex = 4;
            // 
            // TesterBox
            // 
            this.TesterBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TesterBox.Location = new System.Drawing.Point(342, 29);
            this.TesterBox.Margin = new System.Windows.Forms.Padding(0);
            this.TesterBox.Name = "TesterBox";
            this.TesterBox.Size = new System.Drawing.Size(100, 20);
            this.TesterBox.TabIndex = 4;
            // 
            // testNameComboBox
            // 
            this.testNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.testNameComboBox.FormattingEnabled = true;
            this.testNameComboBox.Location = new System.Drawing.Point(116, 3);
            this.testNameComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.testNameComboBox.Name = "testNameComboBox";
            this.testNameComboBox.Size = new System.Drawing.Size(100, 21);
            this.testNameComboBox.TabIndex = 13;
            this.testNameComboBox.Text = "A Test";
            // 
            // TestNotesBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TestNotesBox, 2);
            this.TestNotesBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestNotesBox.Location = new System.Drawing.Point(229, 53);
            this.TestNotesBox.Margin = new System.Windows.Forms.Padding(0);
            this.TestNotesBox.Multiline = true;
            this.TestNotesBox.Name = "TestNotesBox";
            this.tableLayoutPanel1.SetRowSpan(this.TestNotesBox, 2);
            this.TestNotesBox.Size = new System.Drawing.Size(225, 48);
            this.TestNotesBox.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(463, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 124);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result Summary";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.averageForceLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.MaxForceLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.MinForceLabel, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.DataPointsLabel, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(49, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(128, 105);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "Average Force";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 26);
            this.label10.TabIndex = 0;
            this.label10.Text = "Max Force";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 58);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Min Force";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 78);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 26);
            this.label12.TabIndex = 0;
            this.label12.Text = "Data Points";
            // 
            // averageForceLabel
            // 
            this.averageForceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.averageForceLabel.AutoSize = true;
            this.averageForceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageForceLabel.Location = new System.Drawing.Point(83, 6);
            this.averageForceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.averageForceLabel.Name = "averageForceLabel";
            this.averageForceLabel.Size = new System.Drawing.Size(25, 13);
            this.averageForceLabel.TabIndex = 0;
            this.averageForceLabel.Text = "0.0";
            // 
            // MaxForceLabel
            // 
            this.MaxForceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MaxForceLabel.AutoSize = true;
            this.MaxForceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxForceLabel.Location = new System.Drawing.Point(83, 32);
            this.MaxForceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MaxForceLabel.Name = "MaxForceLabel";
            this.MaxForceLabel.Size = new System.Drawing.Size(25, 13);
            this.MaxForceLabel.TabIndex = 0;
            this.MaxForceLabel.Text = "0.0";
            // 
            // MinForceLabel
            // 
            this.MinForceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MinForceLabel.AutoSize = true;
            this.MinForceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinForceLabel.Location = new System.Drawing.Point(83, 58);
            this.MinForceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MinForceLabel.Name = "MinForceLabel";
            this.MinForceLabel.Size = new System.Drawing.Size(25, 13);
            this.MinForceLabel.TabIndex = 0;
            this.MinForceLabel.Text = "0.0";
            // 
            // DataPointsLabel
            // 
            this.DataPointsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataPointsLabel.AutoSize = true;
            this.DataPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataPointsLabel.Location = new System.Drawing.Point(89, 85);
            this.DataPointsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.DataPointsLabel.Name = "DataPointsLabel";
            this.DataPointsLabel.Size = new System.Drawing.Size(14, 13);
            this.DataPointsLabel.TabIndex = 0;
            this.DataPointsLabel.Text = "0";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(46, 105);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(643, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(129, 124);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Export Options";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.ExportRadioButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.DontExportRadioButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.deleteRadioButton, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(123, 105);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // ExportRadioButton
            // 
            this.ExportRadioButton.AutoSize = true;
            this.ExportRadioButton.Checked = true;
            this.ExportRadioButton.Location = new System.Drawing.Point(16, 7);
            this.ExportRadioButton.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.ExportRadioButton.Name = "ExportRadioButton";
            this.ExportRadioButton.Size = new System.Drawing.Size(85, 17);
            this.ExportRadioButton.TabIndex = 0;
            this.ExportRadioButton.TabStop = true;
            this.ExportRadioButton.Text = "Export";
            this.ExportRadioButton.UseVisualStyleBackColor = true;
            // 
            // DontExportRadioButton
            // 
            this.DontExportRadioButton.AutoSize = true;
            this.DontExportRadioButton.Location = new System.Drawing.Point(16, 40);
            this.DontExportRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.DontExportRadioButton.Name = "DontExportRadioButton";
            this.DontExportRadioButton.Size = new System.Drawing.Size(85, 17);
            this.DontExportRadioButton.TabIndex = 1;
            this.DontExportRadioButton.Text = "Don\'t Export";
            this.DontExportRadioButton.UseVisualStyleBackColor = true;
            // 
            // deleteRadioButton
            // 
            this.deleteRadioButton.AutoSize = true;
            this.deleteRadioButton.Location = new System.Drawing.Point(16, 77);
            this.deleteRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.deleteRadioButton.Name = "deleteRadioButton";
            this.deleteRadioButton.Size = new System.Drawing.Size(85, 17);
            this.deleteRadioButton.TabIndex = 2;
            this.deleteRadioButton.Text = "Delete";
            this.deleteRadioButton.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(772, 124);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        //Made all these fields public since they will inherently be used as a form component which are normally
        //internal to a form and this will be used in forms. Not sure if this is legit or not. May change late if better
        //way.

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ItemBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox temperatureBox;
        private System.Windows.Forms.TextBox TesterBox;
        private System.Windows.Forms.ComboBox testNameComboBox;
        private System.Windows.Forms.TextBox TestNotesBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label averageForceLabel;
        private System.Windows.Forms.Label MaxForceLabel;
        private System.Windows.Forms.Label MinForceLabel;
        private System.Windows.Forms.Label DataPointsLabel;
        private System.Windows.Forms.ListBox listBox1;
        private GroupBox groupBox1;
        private TextBox MeasuredPressureBox;
        private TextBox MeasureFlowBox;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel3;
        public RadioButton ExportRadioButton;
        public RadioButton DontExportRadioButton;
        public RadioButton deleteRadioButton;


        ///// Added getters and setters for all fields in this control.
        ///// Not sure if this is 100% kosher but should be ok since this will
        ///// always just be a component of the form its in and normally the form components
        ///// are accessible.      
        //#region getters and setters

        //public GroupBox GroupBox1
        //{
        //    get
        //    {
        //        return groupBox1;
        //    }

        //    set
        //    {
        //        groupBox1 = value;
        //    }
        //}

        //public TableLayoutPanel TableLayoutPanel1
        //{
        //    get
        //    {
        //        return tableLayoutPanel1;
        //    }

        //    set
        //    {
        //        tableLayoutPanel1 = value;
        //    }
        //}

        //public Label Label5
        //{
        //    get
        //    {
        //        return label5;
        //    }

        //    set
        //    {
        //        label5 = value;
        //    }
        //}

        //public TextBox TextBox4
        //{
        //    get
        //    {
        //        return textBox4;
        //    }

        //    set
        //    {
        //        textBox4 = value;
        //    }
        //}

        //public Label Label1
        //{
        //    get
        //    {
        //        return label1;
        //    }

        //    set
        //    {
        //        label1 = value;
        //    }
        //}

        //public Label Label2
        //{
        //    get
        //    {
        //        return label2;
        //    }

        //    set
        //    {
        //        label2 = value;
        //    }
        //}

        //public Label Label3
        //{
        //    get
        //    {
        //        return label3;
        //    }

        //    set
        //    {
        //        label3 = value;
        //    }
        //}

        //public Label Label4
        //{
        //    get
        //    {
        //        return label4;
        //    }

        //    set
        //    {
        //        label4 = value;
        //    }
        //}

        //public TextBox TextBox3
        //{
        //    get
        //    {
        //        return textBox3;
        //    }

        //    set
        //    {
        //        textBox3 = value;
        //    }
        //}

        //public TextBox TextBox5
        //{
        //    get
        //    {
        //        return textBox5;
        //    }

        //    set
        //    {
        //        textBox5 = value;
        //    }
        //}

        //public Label Label6
        //{
        //    get
        //    {
        //        return label6;
        //    }

        //    set
        //    {
        //        label6 = value;
        //    }
        //}

        //public TextBox TextBox2
        //{
        //    get
        //    {
        //        return textBox2;
        //    }

        //    set
        //    {
        //        textBox2 = value;
        //    }
        //}

        //public TextBox TextBox6
        //{
        //    get
        //    {
        //        return textBox6;
        //    }

        //    set
        //    {
        //        textBox6 = value;
        //    }
        //}

        //public ComboBox ComboBox1
        //{
        //    get
        //    {
        //        return testNameComboBox;
        //    }

        //    set
        //    {
        //        testNameComboBox = value;
        //    }
        //}

        //public TextBox TextBox7
        //{
        //    get
        //    {
        //        return textBox7;
        //    }

        //    set
        //    {
        //        textBox7 = value;
        //    }
        //}

        //public GroupBox GroupBox2
        //{
        //    get
        //    {
        //        return groupBox2;
        //    }

        //    set
        //    {
        //        groupBox2 = value;
        //    }
        //}

        //public TableLayoutPanel TableLayoutPanel2
        //{
        //    get
        //    {
        //        return tableLayoutPanel2;
        //    }

        //    set
        //    {
        //        tableLayoutPanel2 = value;
        //    }
        //}

        //public Label Label9
        //{
        //    get
        //    {
        //        return label9;
        //    }

        //    set
        //    {
        //        label9 = value;
        //    }
        //}

        //public Label Label10
        //{
        //    get
        //    {
        //        return label10;
        //    }

        //    set
        //    {
        //        label10 = value;
        //    }
        //}

        //public Label Label11
        //{
        //    get
        //    {
        //        return label11;
        //    }

        //    set
        //    {
        //        label11 = value;
        //    }
        //}

        //public Label Label12
        //{
        //    get
        //    {
        //        return label12;
        //    }

        //    set
        //    {
        //        label12 = value;
        //    }
        //}

        //public Label Label7
        //{
        //    get
        //    {
        //        return label7;
        //    }

        //    set
        //    {
        //        label7 = value;
        //    }
        //}

        //public Label Label8
        //{
        //    get
        //    {
        //        return label8;
        //    }

        //    set
        //    {
        //        label8 = value;
        //    }
        //}

        //public Label Label13
        //{
        //    get
        //    {
        //        return label13;
        //    }

        //    set
        //    {
        //        label13 = value;
        //    }
        //}

        //public Label Label14
        //{
        //    get
        //    {
        //        return label14;
        //    }

        //    set
        //    {
        //        label14 = value;
        //    }
        //}

        //public ListBox ListBox1
        //{
        //    get
        //    {
        //        return listBox1;
        //    }

        //    set
        //    {
        //        listBox1 = value;
        //    }
        //}
        //#endregion


    }
}
