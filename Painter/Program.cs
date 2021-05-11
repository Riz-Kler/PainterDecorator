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

            //call the methods and output the results

            double floorarea = PaintRoom.FloorArea(length, width);

            if(floorarea == 0)
            {
                Console.WriteLine("Invalid value");

                Console.Write("Press enter to exit... ");
                while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            }
            Console.WriteLine("The Area of the Floor is:" + floorarea) ;

            double wallarea = PaintRoom.PaintedArea(length, width, height);
            Console.WriteLine("The paint required for the walls is:" + wallarea);

            double volume = PaintRoom.Volume(length, width, height);
            Console.WriteLine("The volume of the room is:" + volume);


            //prints text but keeps cursor in same line
            Console.Write("Press enter to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;

        }
    }
}
