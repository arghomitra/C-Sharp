using System.Drawing;

namespace Shape;
class Program
{
    static void Main(string[] args)
    {
        

        Rectangle shapeTwo = new Rectangle(5, 6);
        int areaTwo = shapeTwo.Area(shapeTwo.Width, shapeTwo.Height);
        Console.WriteLine(areaTwo);

        
    }
}

