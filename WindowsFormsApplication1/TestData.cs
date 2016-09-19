using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class TestData
    {
        private List<double> values;
        private string item;
        private string flowRate;
        private string measuredFlow;
        private string testNotes;
        private string tester;
        private string testName;
        private string testType;
        private string units;
        private double averageForce;
        private double maxForce;
        private double minForce;
        private int dataPoints;
        private string timeStamp;
        private string[] dateAndTime;
        private string measuredPressure;
        private string testLength;
        private string temperature;

        public TestData(List<double> values, string testName, string item, string units, string flowRate, string measuredFlow, string measuredPressure, string tester, string testNotes)
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

        #region getter and setters
        public List<double> Values
        {
            get
            {
                return values;
            }

            set
            {
                values = value;
            }
        }

        public string Item
        {
            get
            {
                return item;
            }

            set
            {
                item = value;
            }
        }

        public string FlowRate
        {
            get
            {
                return flowRate;
            }

            set
            {
                flowRate = value;
            }
        }

        public string MeasuredFlow
        {
            get
            {
                return measuredFlow;
            }

            set
            {
                measuredFlow = value;
            }
        }

        public string TestNotes
        {
            get
            {
                return testNotes;
            }

            set
            {
                testNotes = value;
            }
        }

        public string Tester
        {
            get
            {
                return tester;
            }

            set
            {
                tester = value;
            }
        }

        public string TestName
        {
            get
            {
                return testName;
            }

            set
            {
                testName = value;
            }
        }

        public string TestType
        {
            get
            {
                return testType;
            }

            set
            {
                testType = value;
            }
        }

        public string Units
        {
            get
            {
                return units;
            }

            set
            {
                units = value;
            }
        }

        public double AverageForce
        {
            get
            {
                return averageForce;
            }

            set
            {
                averageForce = value;
            }
        }

        public double MaxForce
        {
            get
            {
                return maxForce;
            }

            set
            {
                maxForce = value;
            }
        }

        public double MinForce
        {
            get
            {
                return minForce;
            }

            set
            {
                minForce = value;
            }
        }

        public int DataPoints
        {
            get
            {
                return dataPoints;
            }

            set
            {
                dataPoints = value;
            }
        }

        public string TimeStamp
        {
            get
            {
                return timeStamp;
            }

            set
            {
                timeStamp = value;
            }
        }

        public string[] DateAndTime
        {
            get
            {
                return dateAndTime;
            }

            set
            {
                dateAndTime = value;
            }
        }

        public string MeasuredPressure
        {
            get
            {
                return measuredPressure;
            }

            set
            {
                measuredPressure = value;
            }
        }

        public string TestLength
        {
            get
            {
                return testLength;
            }

            set
            {
                testLength = value;
            }
        }

        public string Temperature
        {
            get
            {
                return temperature;
            }

            set
            {
                temperature = value;
            }
        }
        #endregion
    }
}
