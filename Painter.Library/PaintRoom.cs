using System;

namespace Painter.Library
{
    public class PaintRoom
    {
        public static double FloorArea(double length, double width)
        {

            //check condition for values <=0

            if(length<= 0 || width <=0)
            {

                return 0;
            }

            //calculate the area of the floor
            double floorArea = width * length;

            return floorArea;

        }

        public static double PaintedArea(double length, double width, double height)
        {
            //check condition for values <=0
            if (length <= 0 || width <= 0 || height <=0)
            {
                return 0;
            }

            //calculate the amount of paint required
            double paintRequired = 2 * ((length * height) + (width * height));
            return paintRequired;
        }

        public static double Volume(double length, double width, double height)
        {
            //check condition for values <=0
            if (length <= 0 || width <= 0 || height <= 0)
            {
                return 0;
            }

            //calculate the volume of the room
            double volume = length * width * height;
            return volume;
        }
    }
}
