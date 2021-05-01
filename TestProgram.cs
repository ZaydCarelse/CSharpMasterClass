using System;

namespace Test_Application
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            int peopleOnBus = 1;
            string checkPeople = "";
            string allPeople = "";
            int counter = 0;
                
            while (allPeople.Length < peopleOnBus)
            {

                Console.WriteLine("If there is another student getting onto the bus, hit enter.");
                Console.WriteLine("When all the students are on the bus, type anything.");
                Console.WriteLine("There are " + counter + " students on the bus.");
                checkPeople = Console.ReadLine();
                allPeople += checkPeople;
                counter++;
            }
        }
    }
}