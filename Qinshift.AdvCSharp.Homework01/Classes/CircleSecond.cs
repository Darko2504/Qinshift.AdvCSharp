

namespace Qinshift.AdvCSharp.Homework01.Classes
{
   public class CircleSecond : Shape
    {
        public double Radius { get; set; }

        public CircleSecond(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
