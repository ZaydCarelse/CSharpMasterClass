using System;

namespace Test_Application
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            box.height = 4;
            box.width = 4;
            box.length = 6;
            
            box.DisplayInfo();
        }
    }
}