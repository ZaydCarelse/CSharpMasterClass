using System;

namespace Test_Application
{
    public class Box
    {
        // Setting Properties
        public int Width { get; set; }
        public int Length { get; set; }
        public int Height { get; set; }

        public int Volume
        {
            get
            {
                return Length * Width * Height;
            }
        }

        public int FrontSurface
        {
            get
            {
                return Height * Length;
            }
        }

        // Constructor
        public Box(int length, int width, int height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("___ These are the properties of the box: ___");
            Console.WriteLine("Length: {0}", Length);
            Console.WriteLine("Height: {0}", Height);
            Console.WriteLine("Width: {0}", Width);
            Console.WriteLine("Considering the above data, the volume of the box is {0}", Volume);
        }
    }
}