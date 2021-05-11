using System;
using Painter.Library;

namespace Painter
{
    class Program
    {
        static void Main(string[] args)
        {

            //enter the length of the room
            Console.WriteLine("Enter the length (long) of the room:");
            double length = Double.Parse(Console.ReadLine());

            //enter the width of the room
            Console.WriteLine("Enter the width of the room:");
            double width = Double.Parse(Console.ReadLine());

            //enter the height of the room
            Console.WriteLine("Enter the height of the room:");
            double height = Double.Parse(Console.ReadLine());

            //call the methods
            Console.WriteLine("The Area of the Floor is:"  );

        }
    }
}
