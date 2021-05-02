using System;

namespace Test_Application
{
    public class Box
    {
        // Member variable
        public int length;
        public int height;
        public int width;
        public int volume;

        public void DisplayInfo()
        {
            Console.WriteLine("___ These are the properties of the box: ___");
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Height: {0}", height);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Considering the above data, the volume of the box is {0}", 
                volume = length * height * width);
        }
    }
}