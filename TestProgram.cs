using System;

namespace Test_Application
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            string myString = "156";
            string mySecondString = "13";

            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);

            int result = num1 + num2;
            Console.WriteLine("The result of the addition is : " + result);
        }
    }
}