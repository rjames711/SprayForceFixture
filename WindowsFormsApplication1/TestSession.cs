using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;
namespace WindowsFormsApplication1
{
    /// <summary>
    /// Represents one session of testing. Contains all data points and any entered test data. Also contains methods 
    /// to save data to csv files.
    /// </summary>
    class TestSession
    {
        List<double> values;
        public string item;
        public string flowRate;
        public string measuredFlow;
        public string testNotes;
        public string tester;
        public string testName;
        public string testType;
        public string units;
        double averageForce;
        double maxForce;
        double minForce;
        int dataPoints;
        string timeStamp;
        string[] dateAndTime;
        string measuredPressure;
        string testLength;


        public TestSession(List<double> values, string testName, string item, string units, string flowRate, string measuredFlow, string measuredPressure, string tester, string testNotes)
        {
            this.values = new List<double>(values);// need to clone list so it doesn't maintain object reference.
            this.item = item;
            this.flowRate = flowRate;
            this.measuredFlow = measuredFlow;
            this.testNotes = testNotes;
            this.tester = tester;
            this.testName = testName;
            this.averageForce = values.Average();
            this.maxForce = values.Max();
            this.minForce = values.Min();
            this.dataPoints = values.Count;
            this.testType = measuredPressure;
            this.units = units;
            this.measuredPressure = measuredPressure;
            DateTime time = DateTime.Now;
            timeStamp = time.ToString();
            dateAndTime = timeStamp.Split(' ');
            this.testLength = Convert.ToDouble(dataPoints / 10.0).ToString("N1");

        }

        /// <summary>
        /// Writes test summary without full list of datapoints. 
        /// Creates new file if name does't exist. Appends to file if does exist
        /// </summary>
        public void writeTest(string root)
        {
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(root + "\\" + testName + ".csv", true))
            {
                writedetails(file);
            }
        }
        /// <summary>
        /// Writes test results to subfolder of main export directory (created if 
        /// not existing) including full list of datapoints for graphing etc. 
        /// Creates new file if name does't exist. Appends to file if does exist.
        /// 
        /// </summary>

        public void writeLongTest(string root)
        {
            root = Directory.CreateDirectory(root + "\\Full Results").FullName;
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(root + "\\" + testName + "(full).csv", true))
            {
                writedetails(file);
                int i = 0;
                foreach (double value in values)
                {
                    file.Write(++i + ",");
                    file.WriteLine(value);
                }
            }
        }

        /// <summary>
        /// Writes the details of the test session into the file (minus the full datapoints list)
        /// which is passed into the method.
        /// </summary>
        /// <param name="file"></param>
        public void writedetails(System.IO.StreamWriter file)
        {
            file.WriteLine();
            file.WriteLine("Test Name,Item,Date,Time,Tester,Units,Notes");
            file.Write(testName + ",");
            file.Write(item + ", ");
            file.Write(dateAndTime[0] + ", ");
            file.Write(dateAndTime[1] + " ,");
            file.Write(tester + ",");
            file.Write(units + ",");
            file.Write(testNotes + ",");
            file.WriteLine();
            file.WriteLine("Test Length:,," + testLength + " s" + ",DataPoints:,," + dataPoints);
            file.Write("Measured Flow:,," + measuredFlow);
            file.WriteLine(",Measured Pressure:,," + measuredPressure);
            file.WriteLine("Average Force:,," + averageForce);
            file.WriteLine("Max Force:,," + maxForce);
            file.WriteLine("Min Force:,," + minForce);
        }


        public void writeExcelReport(string root)
        {
            root = Directory.CreateDirectory(root + "\\Excel Reports").FullName;
            var excelApp = new Excel.Application();
            //excelApp.Workbooks.Open(@"C:\Users\rames\Documents\Spray Force Data\Full Results\Test1(full).csv)");
            object[][] sheet1Lines = new object[8][];
            sheet1Lines[0] = new object[0];//Skip first Line
            sheet1Lines[1] = new object[] { "Test Name", "Items", "Date", "Time", "Tester", "Units", "Notes" };
            sheet1Lines[2] = new object[] { testName, item, dateAndTime[0], dateAndTime[1], tester, units, testNotes };
            sheet1Lines[3] = new object[] { "Test Length:", "", testLength, "Data Points:", dataPoints };
            sheet1Lines[4] = new object[] { "Measured Flow:", "", measuredFlow, "Measured Pressure", measuredPressure };
            sheet1Lines[5] = new object[] { "Average Force", "", averageForce };
            sheet1Lines[6] = new object[] { "Max Force", "", maxForce };
            sheet1Lines[7] = new object[] { "Min Force", "", minForce };

            object[][] sheet2Lines = new object[2][];
            sheet2Lines[0] = new object[] { "Average Force", "Flow", "Pressure", "Date Tested", "Time" };
            sheet2Lines[1] = new object[] { averageForce, measuredFlow, measuredPressure, dateAndTime[0], dateAndTime[1] };

            #region test details sheet
            Excel.Workbook workbook;
            Excel._Worksheet workSheet;
            try
            {
             workbook = excelApp.Workbooks.Open(root + "\\" + testName + ".xlsx");
            }
            catch
            {
               workbook= excelApp.Workbooks.Add();
               workbook.SaveAs(root + "\\" + testName + ".xlsx");
            }

            //workSheet = (Excel.Worksheet)excelApp.ActiveSheet;
            workSheet = (Excel.Worksheet)excelApp.Worksheets["Test Details"];
            //workSheet.Name = "Test Details";
            excelApp.Visible = true;

            int startRow = 0;
            int startCol = 0;
            var cell = workSheet.Cells[startRow + 2, 1];
            while (cell.Value2 != null)
            {
                startRow++;
                cell = workSheet.Cells[startRow + 2, 1];
            }
            workSheet.Cells.NumberFormat = "0.00"; //Change sheet to two digit precision format
            workSheet.Rows[startRow + 3].NumberFormat = "@";

            for (int row = 0; row < sheet1Lines.Length; row++)
            {
                for (int col = 0; col < sheet1Lines[row].Length; col++)
                {
                    if (sheet1Lines[row][col] is double)   //if the value is double we'll apply two digit format
                        workSheet.Cells[startRow + row + 1, col + 1].NumberFormat = "0.00";
                    workSheet.Cells[startRow + row + 1, col + 1] = sheet1Lines[row][col];
                }

            }
            #endregion
            #region add data for graph
            Excel._Worksheet workSheet2;
            try
            {
                workSheet2 = excelApp.Sheets[1];
             
            }
            catch
            {
                workSheet2 = excelApp.Sheets.Add();
                workSheet2.Name = "Summary";
                
            }
            workSheet2.Activate();
            workSheet2.Columns[4].NumberFormat="@"; //format date column as text so it doesn't come in hashed
            startRow = 0;

            cell = workSheet2.Cells[startRow + 1, 1];
            while (cell.Value2 != null)
            {
                startRow++;
                cell = workSheet2.Cells[startRow + 1, 1];
            }

            for (int i = 0; i < sheet2Lines[0].Length; i++)
            {
                workSheet2.Cells[1, i + 1] = sheet2Lines[0][i];
                workSheet2.Cells[startRow + 1, i + 1] = sheet2Lines[1][i];
            }

            #endregion
            #region add graph
            //http://stackoverflow.com/questions/14779376/changing-axis-labels-on-excel-chart-created-in-c-sharp
            Excel.Shape chart;
            if (workSheet2.Shapes.Count > 0)
                chart = workSheet2.Shapes.Item(1);
            else
                chart = workSheet2.Shapes.AddChart2("", "", 150, 150, 400, 400);

            chart.Title = "Spray Force vs Flow";
            Excel.Chart theChart = chart.Chart;
            foreach (var series in theChart.SeriesCollection())
                series.Delete();
            theChart.ChartType = Excel.XlChartType.xlXYScatter;
            theChart.HasTitle = true;
            theChart.ChartTitle.Text = "Spray Force";

            var yAxis = (Excel.Axis)theChart.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary);
            yAxis.HasTitle = true;
            yAxis.AxisTitle.Text = "Y-Axis Title text";

            var xAxis = (Excel.Axis)theChart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary);
            xAxis.HasTitle = true;
            xAxis.AxisTitle.Text = "X-Axis Title text";

    
            theChart.SeriesCollection().NewSeries();
            theChart.SeriesCollection(1).Name = "Average Force";

            theChart.SeriesCollection(1).Values = workSheet2.Range[workSheet2.Cells[2, 1], workSheet2.Cells[startRow + 1, 1]];
            theChart.SeriesCollection(1).XValues = workSheet2.Range[workSheet2.Cells[2, 2], workSheet2.Cells[startRow + 1, 2]];

            #endregion

            //var flow = workSheet.Range["C5"];
            //var aveForce = workSheet.Range["C6"];
            //theChart.SetSourceData(aveForce,flow);



            // Excel.SeriesCollection oSeriesCollection = (Excel.SeriesCollection)chart.Chart.SeriesCollection(0);
            //Excel.Series Data = oSeriesCollection.NewSeries();



            //           theChart.Axes(Excel.XlCategoryType.xlCategoryScale, Excel.XlAxisGroup.xlPrimary).HasTitle = true;
            //           theChart.Axes(Excel.xl, Excel.XlAxisGroup.xlPrimary).HasTitle = true;

            //               chart.Chart.Axes(Excel.XlAxisGroup.xlPrimary)

            //workSheet.Cells[startRow, 1] = "Test Name";
            //workSheet.Cells[startRow, 2] = "Item";
            //workSheet.Cells[startRow, 3] = "Date";
            //workSheet.Cells[startRow, 4] = "Time";
            //workSheet.Cells[startRow, 5] = "Tester";
            //workSheet.Cells[startRow, 6] = "Units";
            //workSheet.Cells[startRow, 7] = "Notes";
            //workSheet.Cells[startRow + 1, 1] = testName;
            //workSheet.Cells[startRow + 1, 2] = item;
            //workSheet.Cells[startRow + 1, 3] = dateAndTime[0];
            //workSheet.Cells[startRow + 1, 4] = dateAndTime[1];
            //workSheet.Cells[startRow + 1, 5] = tester;
            //workSheet.Cells[startRow + 1, 6] = units;
            //workSheet.Cells[startRow + 1, 7] = testNotes;
            //workSheet.Cells[startRow + 2, 1] = "Measured Flow";
            //workSheet.Cells[startRow + 3, 1] = "";


            //  workSheet.get_Range("A1", "B4").Value = 4;
            // workSheet.Range["H1", "I2"].Value = "this,that";

            workbook.Save();  
            excelApp.Quit();

        }

        public static void writeExcelReport2(string root)
        {
            var excelApp = new Excel.Application();
            //excelApp.Workbooks.Open(@"C:\Users\rames\Documents\Spray Force Data\Full Results\Test1(full).csv)");
            object[][] lines = new object[10][];
            lines[0] = new object[0];//Skip first Line
            lines[1] = new object[] { "Test Name", "Items", "Date", "Time", "Tester", "Units", "Notes" };
            lines[2] = new object[] { "testName", "item", "dateAndTime[0]", "dateAndTime[1]", "tester", "units", "testNotes" };
            lines[3] = new object[] { "Test Length:", "", "testLength" };
            lines[4] = new object[] { "Test Length:", "", "testLength" };
            lines[5] = new object[] { "Test Length:", "", "testLength", "Data Points:", "dataPoints" };
            lines[6] = new object[] { "Measured Flow:", "", "measuredFlow", "Measured Pressure", "measuredPressure" };
            lines[7] = new object[] { "Average Force", "", "averageForce" };
            lines[8] = new object[] { "Max Force", "", "maxForce" };
            lines[9] = new object[] { "Min Force", "", "minForce" };



            excelApp.Workbooks.Add();
            excelApp.Visible = true;
            Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;
            workSheet.Cells.NumberFormat = "0.00"; //this converts whole sheet to text format so it doesn't change values willy nilly
            int startRow = 1;
            //workSheet.Cells[startRow, 1] = lines[startRow][1];
            //workSheet.Cells[startRow, 2] = "Item";
            //workSheet.Cells[startRow, 3] = "Date";
            //workSheet.Cells[startRow, 4] = "Time";
            //workSheet.Cells[startRow, 5] = "Tester";
            //workSheet.Cells[startRow, 6] = "Units";
            //workSheet.Cells[startRow, 7] = "Notes";
            //workSheet.Cells[startRow + 1, 1] = "testName";
            //workSheet.Cells[startRow + 1, 2] = "item";
            //workSheet.Cells[startRow + 1, 3] = "5/5/15";
            //workSheet.Cells[startRow + 1, 4] = "dateAndTime[1]";
            //workSheet.Cells[startRow + 1, 5] = "tester";
            //workSheet.Cells[startRow + 1, 6] = "units";
            //workSheet.Cells[startRow + 1, 7] = "testNotes";
            //workSheet.Cells[startRow + 2, 1] = "5.0";
            //workSheet.Cells[startRow + 3, 1] = "2";

            for (int row = 0; row < lines.Length; row++)
            {
                for (int col = 0; col < lines[row].Length; col++)
                    workSheet.Cells[row + 1, col + 1] = lines[row][col];

            }
            //workSheet.Cells[startRow, 1] = "Test Name";
            //workSheet.Cells[startRow, 2] = "Item";
            //workSheet.Cells[startRow, 3] = "Date";
            //workSheet.Cells[startRow, 4] = "Time";
            //workSheet.Cells[startRow, 5] = "Tester";
            //workSheet.Cells[startRow, 6] = "Units";
            //workSheet.Cells[startRow, 7] = "Notes";
            //workSheet.Cells[startRow + 1, 1] = "testName";
            //workSheet.Cells[startRow + 1, 2] = "item";
            //workSheet.Cells[startRow + 1, 3] = "5/5/15";
            //workSheet.Cells[startRow + 1, 4] = "dateAndTime[1]";
            //workSheet.Cells[startRow + 1, 5] = "tester";
            //workSheet.Cells[startRow + 1, 6] = "units";
            //workSheet.Cells[startRow + 1, 7] = "testNotes";
            //workSheet.Cells[startRow + 2, 1] = "5.0";
            //workSheet.Cells[startRow + 3, 1] = "2";

            //workSheet.Range["A1", "i10"].FormatConditions.Add(Excel.XlFormatConditionType.xlTextString);
            //  workSheet.get_Range("A1", "B4").Value = 4;
            List<string> alist = new List<string>();

            workSheet.Range["H1", "I2"].Value = "this,that";
            //Range aRange = ws.Cells(1,1);
            //  aRange.Value = 4;
            //  wb.SaveAs(root + testName + ".xlsx");
       
            excelApp.Quit();

        }

    }
}
