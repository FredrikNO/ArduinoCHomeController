using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoCHomeController
{
    internal class CalculateTemperature
    {
        public double TemperatureCelcius { get; private set; }
        public double TemperatureFahrenheit { get; private set; }
        private readonly ICommunication _communication;
        public CalculateTemperature(ICommunication communication)
        {
            _communication= communication;
        }

        public void GetTempFromArduino(string message)
        {
            var voltage = _communication.ReadFromArduino(message);
            ConvertVoltageToCelsius(voltage);
            ConvertCelsiusToFahrenheit();
        }
        private void ConvertVoltageToCelsius(int voltage)
        {
            TemperatureCelcius = (voltage-0.5)*100;
        }
        private void ConvertCelsiusToFahrenheit()
        {
            TemperatureFahrenheit = (TemperatureFahrenheit * 1.8) + 32;
        }
    }
}
