using System.IO.Ports;

namespace ArduinoCHomeController
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Button button = new Button(new Communication());
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