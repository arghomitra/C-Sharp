using System;
namespace Shape
{
    public class Rectangle : Shape
    {
        //constructor
        public Rectangle(int width, int height) : base(width, height)
        {
        }

        //method
        public int Area(int width, int height)
        {
            int area = (Width * Height);
            return (area);
        }
    }
}

