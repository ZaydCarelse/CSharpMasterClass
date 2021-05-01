using System;

namespace Test_Application
{
    public class Human
    {
        // Member variable
        public string firstName;
        public string lastName;
        
        // Member function
        public void IntroduceHuman()
        {
            Console.WriteLine("Hi, I am " + firstName + " " + lastName + ".");
        }
    }
}