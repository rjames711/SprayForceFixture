using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
namespace WindowsFormsApplication1
{
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


        public TestSession(List<double> values,string testName, string item,string units, string flowRate, string measuredFlow, string testType, string tester, string testNotes )
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
            this.testType = testType;
            this.units = units;
            DateTime time = DateTime.Now;
            timeStamp = time.ToString();
            dateAndTime = timeStamp.Split(' ');


        }

        public void writeTest()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\rames\Documents\"+testName+".csv", true))
            {
                file.WriteLine("Test Name,Item,Date,Time,Tester,Units,Notes");
                file.Write(testName+",");
                file.Write(item+", ");
                file.Write(dateAndTime[0]+", ");
                file.Write(dateAndTime[1] + " ,");
                file.Write(tester+",");
                file.Write(units + ",");
                file.Write(testNotes+",");
                file.WriteLine();
                file.WriteLine("Average Force:,," + averageForce);
                file.WriteLine("Max Force:,," + maxForce);
                file.WriteLine("Min Force:,," + minForce);
                file.WriteLine("DataPoint:,Values");
                int i = 0;
                foreach (double value in values)
                {
                    file.Write(++i +",");
                    file.WriteLine(value);
                }
                //for(int i =0; i<dataPoints;i++)
                //{
                //    file.Write((i+1) + ",");
                //    file.WriteLine(values[i]);
                //}
            }
        }


    }
}
