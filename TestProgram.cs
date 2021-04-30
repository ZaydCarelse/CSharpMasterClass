using System;

namespace Test_Application
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            string friend1 = "Frank";
            string friend2 = "George";
            string friend3 = "Mark";
            
            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);
        }

        public static void GreetFriend(string name)
        {
            Console.WriteLine("Hi " + name + ", my friend!");
        }
        
    }
}