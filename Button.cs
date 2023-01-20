using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoCHomeController
{
    internal class Button
    {
        private readonly ICommunication _communication;
        private string _portName;
        public Button(ICommunication communication, string portName)
        {
            _communication = communication;
            _portName = portName;
        }
        public void ControllLight(string command)
        {

            if (command is "ON" or "OFF") _communication.WriteToArduino(_portName + ":" + command);
            else if (String.IsNullOrWhiteSpace(command))
            {
                _communication.WriteToArduino(_portName + command);
                Console.WriteLine("Closing application");
            }
            else Console.WriteLine($"You typed {command} this is not an option");
        }
    }
}
