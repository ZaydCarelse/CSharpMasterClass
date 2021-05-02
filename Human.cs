using System;

namespace Test_Application
{
    public class Human
    {
        // Member variable
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;
        
        // Constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }
        
        // Default Constructor
        public Human()
        {
            Console.WriteLine("This is used in case the parameters are not filled.");
        }
        
        // Member function
        public void IntroduceHuman()
        {
            if (firstName != null || lastName != null || eyeColor != null)
            {
                Console.WriteLine("Hi, I am " + firstName + " " + lastName + ".");
                Console.WriteLine("I am " + age + " years old and have " + eyeColor + " eyes.");
            }
            else
            {
                Console.WriteLine("This Human object is empty.");
            }
        }
    }
}