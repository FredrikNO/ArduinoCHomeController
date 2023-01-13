using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using System.Runtime.CompilerServices;

namespace ArduinoCHomeController
{
    internal class Communication
    {
        private static readonly SerialPort SerialPort  = new SerialPort();

        public static void SetBaudRateAndPortName(int baudRate,string portName)
        {
            SerialPort.BaudRate = baudRate;
            SerialPort.PortName = portName;
        } 
        public static void StartCommunicationWithArduino()
        {
            SerialPort.Open();
        }
        public static void StopCommunicationWithArduino()
        {
            SerialPort.Close();
        }

        protected void WriteToArduino(string message) //Burde endres. Skal endres når det byttes til interface.
        {
            SerialPort.Write(message);
        }
    }
}
