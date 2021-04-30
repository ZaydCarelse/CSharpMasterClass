using System;

namespace Test_Application
{
    class TestProgram
    {
        public static string tempInput;
        public static string validInt;
        public static int tempParsed;

        static void Main(string[] args)
        {
            
            TakeInput();
            if (ValidIntegerCheck(tempInput))
            {
                GiveAdvice();
            }
            else
            {
                Console.WriteLine("Not a valid temperature: Please restart the application.");
            }
        }
        
        /// <summary>
        /// Takes the users input for the current temperature 
        /// </summary>
        public static void TakeInput()
        {
            Console.WriteLine("____ This is the temperature input system: ____");
            Console.Write("Please enter the current temperature: ");
            tempInput = Console.ReadLine();
        }
        
        /// <summary>
        /// Checks to see if the temperature input is a valid integer
        /// </summary>
        /// <param name="temp"></param>
        public static bool ValidIntegerCheck(string temp)
        {
            bool isInt = int.TryParse(temp, out tempParsed);
            return isInt; 
        }

        /// <summary>
        /// Gives advice based on the temperature input
        /// </summary>
        public static void GiveAdvice()
        {
            string recommendation = tempParsed <= 15 ? "It is too cold here." : tempParsed > 28 ? "It is way too hot here." : "It is ok.";
            Console.WriteLine(recommendation);
        }
    }
}