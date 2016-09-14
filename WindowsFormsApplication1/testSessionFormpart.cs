using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class testSessionFormPart
    {

        TestSession test;
        public TableLayoutPanel testDetailsLayoutBox;
        public TextBox textBox1 = new TextBox();
        public ComboBox testNameComboBox = new ComboBox();
        public Label detailLabel3 = new Label();
        public Label detailLabel1 = new Label();
        public TextBox TestNotesBox = new TextBox();
        public Label detailLabel2 = new Label();
        public TextBox MeasureFlowBox = new TextBox();
        public TextBox ItemBox = new TextBox();
        public Label detailLabel6 = new Label();
        public TextBox TesterBox = new TextBox();
        public TextBox MeasuredPressureBox = new TextBox();
        public Label detailLabel5 = new Label();
        public Label detailLabel4 = new Label();

        public testSessionFormPart()
        {

            this.testDetailsLayoutBox = new System.Windows.Forms.TableLayoutPanel();
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

            // test = new TestSession(new List<double> { 1, 2 }, "Default Test Name", "an item", "a flow rate", "a flow rate", "ameasureflow", "a measurepressure", "a rob", "a notes");
            test = new TestSession();

            detailLabel1.Text = "Test Name";
            testNameComboBox.Text = "test.testName";
            textBox1.Text =
            detailLabel3.Text = "Sample";
            detailLabel1.Text = "Measured Flow";
            TestNotesBox.Text = "test.testNotes";
            detailLabel2.Text = "Test Notes";
            MeasureFlowBox.Text = "test.measuredFlow";
            ItemBox.Text = "test.item";
            detailLabel6.Text = "item";
            TesterBox.Text = "test.tester";
            MeasuredPressureBox.Text = test.measuredFlow;
            detailLabel5.Text = "Temperature";
            detailLabel4.Text = "test notes";

    }
    }
}
