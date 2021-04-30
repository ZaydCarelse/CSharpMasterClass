using System;

namespace Test_Application
{
    class TestProgram
    {
        public static bool userIsRegistered = false;
        public static string userName;
        public static string passWord;
        
        static void Main(string[] args)
        {
            RegisterUser();
            if (userIsRegistered)
            {
                Login();
            }
        }
        
        /// <summary>
        /// Registers the user, if not registered
        /// </summary>
        public static void RegisterUser()
        {
            Console.WriteLine("--- Welcome to the User Registration Portal ---");
            Console.Write("What is your username: ");
            userName = Console.ReadLine();
            Console.Write("Great! Please enter your password: ");
            passWord = Console.ReadLine();
            Console.WriteLine("Congratulations! You are successfully registered.");
            userIsRegistered = true;
        }
        
        /// <summary>
        ///  Allows a registered user to login
        /// </summary>
        public static void Login()
        {
            Console.WriteLine("Please Login to continue...");
            Console.Write("Username: ");
            string userNameInput = Console.ReadLine();
            if (userNameInput == userName)
            {
                Console.Write("Username is correct. Please enter your password: ");
                string passWordInput = Console.ReadLine();
                if (passWordInput == passWord)
                {
                    Console.WriteLine("Login successful!");
                }
                else
                {
                    Console.WriteLine("That password is incorrect.");
                }
            }
            else
            {
                Console.WriteLine("That username is not registered.");
            }
        }
    }
}