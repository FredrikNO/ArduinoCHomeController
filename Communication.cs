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
    internal class Communication : ICommunication
    {

        private static readonly SerialPort SerialPort = new SerialPort() { BaudRate = 9600, PortName = "COM3" };
        public static void StartCommunicationWithArduino()
        {
            SerialPort.Open();
        }
        public static void StopCommunicationWithArduino()
        {
            SerialPort.Close();
        }

        public void WriteToArduino(string message)
        {
            SerialPort.Write(message);
        }
    }
}