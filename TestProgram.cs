using System;

namespace Test_Application
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            Human zayd = new Human();
            zayd.firstName = "Zayd";
            zayd.lastName = "Carelse";
            zayd.IntroduceHuman();

            Human denis = new Human();
            denis.firstName = "Dennis";
            denis.lastName = "The Menace";
            denis.IntroduceHuman();
        }
    }
}