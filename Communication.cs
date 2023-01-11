using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;

namespace ArduinoCHomeController
{
    internal class Communication
    {
        private SerialPort _serialport;
        public SerialPort SerialPort { get => _serialport; set => _serialport = value; }
        public Communication(int baudRate, string portName)
        {
            SerialPort= new SerialPort();
            SerialPort.BaudRate = baudRate;
            SerialPort.PortName = portName;
        }
        public void StartCommunicationWithArduino()
        {
            SerialPort.Open();
        }
        public void StopCommunicationWithArduino()
        {
            SerialPort.Close();
        }
        public void ControllLight(bool lightMode)
        {
            if (lightMode) SerialPort.Write("ON");
            else SerialPort.Write("OFF");
        }
    }
}
