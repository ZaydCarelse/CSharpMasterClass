using System;

namespace Test_Application
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            int num1 = 32;
            int num2 = 156;
            int sum = num1 + num2;

            string message = "This is a string to test the program with.";

            Console.WriteLine("The sum of " + num1 + " and " + num2 +" is " + sum);
            Console.WriteLine(message.ToUpper());
        }
    }
}