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
        
        // Member function
        public void IntroduceHuman()
        {
            Console.WriteLine("Hi, I am " + firstName + " " + lastName + ".");
            Console.WriteLine("I am " + age + " years old and have " + eyeColor + " eyes.");
        }
    }
}