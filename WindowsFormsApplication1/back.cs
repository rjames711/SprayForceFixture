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
    class back
    {
        
        SerialPort mySerialPort;
        public string unit;
        bool startButton = true;
        public bool recording = false;
        double currentForce;
        public List<double> forceValues = new List<double>();
        public double tare = 0;
        string comPort;
        double taredForce = 0;
        public double calibratedForce;
        double dataTiming = 5; //milliseconds between datasamplings
        public double dps = 10;       //number of front end datapoints per second
        double dataSmoothing; //number of datapoint to collect and average before reporting back force.
        Stopwatch timer = new Stopwatch();
        double calibrationFactor=1;

        public double getCurrentForce()
        {            
            return currentForce;
        }
        public double getTaredForce()
        {
            return taredForce;
        }

        public void setStart(bool s)
        {
            this.startButton = s;
        }

 
        public back(string comPort)
        {
            Console.WriteLine(comPort);
            this.comPort = comPort;
            connectPort(comPort);
            dataSmoothing = 1000 / (dps * dataTiming);
            tare = Properties.Settings.Default.tare;
            calibrationFactor = Properties.Settings.Default.calibrationFactor;

        }

        /// <summary>
        /// Makes timed calls to getForce() (# depends on dps and timing) averages the result. 
        /// The averaged result returned is what the front end sees as a datapoint.
        /// </summary>
        /// <returns>The average force for the given number of force samples. .</returns>
        public double getDataPoint()
        {
            double sum = 0;
            for (int i = 0; i < dataSmoothing; i++)
            {
                timer.Start();
                sum += getForce();
                while (timer.Elapsed.TotalMilliseconds < 5) ; //Timing occurs here.
                timer.Reset();             
            }
            currentForce = (sum / dataSmoothing); //need to maintain raw force reading for tare function to work.
            taredForce = currentForce - tare;
            calibratedForce = taredForce*calibrationFactor; // If a calibration is performed
            if (recording)
            {
                forceValues.Add(calibratedForce); 
            }
          
            return calibratedForce;
        }



        void connectPort(string port)
        {
            Console.WriteLine("Connecting to device");
            mySerialPort = new SerialPort(port, 9600);
            try
            {
                Console.WriteLine(mySerialPort.IsOpen);
                mySerialPort.Open();
                mySerialPort.DiscardInBuffer();
                mySerialPort.DiscardOutBuffer();
                mySerialPort.DiscardNull = true;
                Console.WriteLine(mySerialPort.IsOpen);
            }
            catch
            {
                Console.WriteLine("error opening serial port.");

            }

        }

        public double getForce()
        {
            string rawRead = "0";
            while (rawRead == "0")
                rawRead = getReading();

            string[] reading = rawRead.Split(' ');
            unit = reading[1].Replace('\r', ' '); ;
            return double.Parse(reading[0]) * -1; //returns the double representation of the reading(inverting negative reading from gauge))
        }


        string getReading()
        {
            try
            {
                mySerialPort.Write("?");
                String reading = null;
                while (String.IsNullOrEmpty(reading)) //should update this to more conventional serial method validation
                {
                    reading = mySerialPort.ReadExisting();

                }
               // dumbDelay(delay);
                return reading;
            }
            catch
            {
                Console.WriteLine("error");
                return "error";
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


        public bool hasConnection()
        {
            return mySerialPort.IsOpen;
 
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

        public back()
        {

        }


    }
        
   }
