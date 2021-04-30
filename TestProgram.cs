using System;

namespace Test_Application
{
    class TestProgram
    {
        public static int temperature = 20;
        
        static void Main(string[] args)
        {
            TakeTemperature();
            GiveAdvice();
        }

        /// <summary>
        /// This method asks the user for the current temperature.
        /// </summary>
        /// <returns> Temperature </returns>
        public static void TakeTemperature()
        {
            Console.Write("What is the current temperature? ");
            string tempInput = Console.ReadLine();
            
            try //Tests to see if the input is a valid number
            {
                temperature = int.Parse(tempInput);
            }
            catch (FormatException) // Exits with an error message if the incorrect format is used.
            {
                Console.WriteLine("Please use only whole numbers. No special characters or letters allowed.");
                Console.WriteLine("The default temperature is: " + temperature);
            }
            finally
            {
                Console.WriteLine("Giving advice based on entered temperature...");
            }
        }

        /// <summary>
        /// Tells the user what to wear based on the temperature input
        /// </summary>
        public static void GiveAdvice()
        {
            if (temperature > 20)
            {
                Console.WriteLine("What a lovely day! You should be able to wear summer wear.");
            } else if (temperature < 5)
            {
                Console.WriteLine("Yikes! You should probably wear winter clothing.");
            }
            else
            {
                    Console.WriteLine("It's not too hot and not too cold. Put a jacket in your backpack.");
            }
        }
    }
}