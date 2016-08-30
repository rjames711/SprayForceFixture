using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;


namespace WindowsFormsApplication1
{
  partial  class back
    {
        double currentForce;
        public List<double> forceValues = new List<double>();
        public double tare = 0;
        double taredForce = 0;
        public double calibratedForce;
        double calibrationFactor = 1;
        public double dps = 10;       //number of front end datapoints per second
        double dataSmoothing; //number of datapoint to collect and average before reporting back force.

        public double getCurrentForce()
        {
            return currentForce;
        }
        public double getTaredForce()
        {
            return taredForce;
        }
        public void calibrate(double calWeight)
        {
            calibrationFactor = calWeight / taredForce;
            Properties.Settings.Default.calibrationFactor = calibrationFactor;
            Properties.Settings.Default.Save();
        }

        public void tareGauge()
        {
            if (hasConnection())
            {
                tare = currentForce;
                Properties.Settings.Default.tare = tare;
                Properties.Settings.Default.Save();
            }
        }
        double getForceAverage()
        {
            double sum = 0;
            foreach (double force in forceValues)
            {
                sum += force;
            }
            return sum;
        }
        public List<double> getForce()
        {
            string rawRead = "0";
            while (rawRead == "0")
                rawRead = getReading();

            string[] reading = rawRead.Split(' ');
            unit = reading[1].Replace('\r', ' ');
            double j = 0;
            foreach (string f in reading)
            {
                Console.Write(f);
                Double.TryParse(f, out j);
                readings.Add(j);
            }
            Console.WriteLine();
            //return double.Parse(reading[0]) * -1; //returns the double representation of the reading(inverting negative reading from gauge))
            return readings;
        }
        public double getDataPoint()
        {
            List<double> sum = new List<double>();

            for (int i = 0; i < dataSmoothing; i++)
            {
                timer.Start();
                if (i == 0)
                    sum = getForce();
                else
                {
                    for (int j = 0; j < sum.Count; j++)
                        sum[j] += getForce()[j];
                }
                while (timer.Elapsed.TotalMilliseconds < 5) ; //Timing occurs here.
                timer.Reset();
            }
            currentReadings.Clear();
            foreach (double sample in sum)
                currentReadings.Add(sample / dataSmoothing);

            taredForce = currentForce - tare;
            calibratedForce = taredForce * calibrationFactor; // If a calibration is performed
            if (recording)
            {
                forceValues.Add(calibratedForce);
            }

            return calibratedForce;
        }


    }
}
