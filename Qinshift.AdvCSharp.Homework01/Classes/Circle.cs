
using Qinshift.AdvCSharp.Homework01.Interfaces;

namespace Qinshift.AdvCSharp.Homework01.Classes
{
    public class Circle : IArea
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius { get; set; }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
