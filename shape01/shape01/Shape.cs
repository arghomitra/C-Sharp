using System;
namespace Shape
{
    public class Shape
    {
        //properties
        public int Width { get; set; }
        public int Height { get; set; }

        //constructor
        public Shape(int width, int height)
        {
            Width = width;
            Height = height;
        }

        //method
        public Shape(int width)
        {
            Width = width;
        }
    }
}

