using System;

namespace Test_Application
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            string myString;
            string searchChar;
            
            Console.Write("Enter string here: ");
            myString = Console.ReadLine();
            
            Console.Write("Enter the character to search for here: ");
            searchChar = Console.ReadLine();
            
            Console.WriteLine(myString.IndexOf(searchChar));

            string firstName;
            string lastName;
            
            Console.Write("Please enter your first name: ");
            firstName = Console.ReadLine();
            
            Console.Write("Please enter your last name: ");
            lastName = Console.ReadLine();

            string fullName = string.Concat(" ",firstName, lastName, " ");
            Console.WriteLine("Your full name is:" + fullName);
        }
    }
}