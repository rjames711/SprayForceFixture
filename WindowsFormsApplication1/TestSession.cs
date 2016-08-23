using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
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


        public TestSession(List<double> values,string testName, string item,string units, string flowRate, string measuredFlow, string measuredPressure, string tester, string testNotes )
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


        }
        /// <summary>
        /// Writes test summary without full list of datapoints. 
        /// Creates new file if name does't exist. Appends to file if does exist
        /// </summary>
        public void writeTest(string root)
        {
            using (System.IO.StreamWriter file = 
                new System.IO.StreamWriter(root+"\\"+testName+".csv", true))
            {
                writedetails(file);
            }
        }
        /// <summary>
        /// Writes test results including full list of datapoints for graphing etc. 
        /// Creates new file if name does't exist. Appends to file if does exist
        /// </summary>

        public void writeLongTest(string root)
        {
            using (System.IO.StreamWriter file = 
                new System.IO.StreamWriter(root +"\\"+ testName + "(full).csv", true))
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
            file.WriteLine("Test Length:,," + Convert.ToDouble(dataPoints / 10.0).ToString("N1") +" s"+ ",DataPoints:,," + dataPoints);
            file.Write("Measured Flow:,," + measuredFlow);
            file.WriteLine(",Measured Pressure:,," + measuredPressure);
            file.WriteLine("Average Force:,," + averageForce);
            file.WriteLine("Max Force:,," + maxForce);
            file.WriteLine("Min Force:,," + minForce);
        }

    }
}
