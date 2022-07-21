using System;

namespace EnhancedIfSTatements_Challenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputTempIntoInt;
            string temperatureMessage = string.Empty; //using string.Empty to open up possibilities
            string inputTemp = string.Empty;            
            
            Console.WriteLine("Enter the current temperature: ");
            inputTemp = Console.ReadLine();

            //validating the inputTemp as valid integer
            bool validInt = int.TryParse(inputTemp, out inputTempIntoInt);

            if (validInt)
            {
                temperatureMessage = inputTempIntoInt <= 15 ? "It is too cold" : (inputTempIntoInt >= 28) ? "It's hot here" : "It is ok";
                Console.WriteLine(temperatureMessage);
            }

            else
                Console.WriteLine("PLease enter a valid number temperature");

            Console.Read();
 
        }
    }
}
