using System;

namespace Test_Application
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            Human zayd = new Human("Zayd", "Carelse", "Brown", 36);
            zayd.IntroduceHuman();

            Human denis = new Human("Dennis", "The Menace", "Blue", 12);
            denis.IntroduceHuman();
        }
    }
}