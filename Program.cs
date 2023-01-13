namespace ArduinoCHomeController
{
    internal class Program
    {
        private static Button button = new Button();
        static void Main(string[] args)
        {
            Communication.SetBaudRateAndPortName(9600, "COM3");
            Communication.StartCommunicationWithArduino();
            string command = string.Empty;
            do
            {
                Console.WriteLine(@"To control the light write ""on"" or ""Off"". To close the program press enter.");
                command = Console.ReadLine().ToUpper();
                button.ControllLight(command);

            } while (!String.IsNullOrEmpty(command));
            Communication.StopCommunicationWithArduino();
        }
    }
}