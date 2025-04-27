

namespace Qinshift.AdvCSharp.Homework01.Classes
{
    public class Triangle
    {
        public Triangle(double baseLength, double height)
        {
            BaseLength = baseLength;
            Height = height;
        }

        public double BaseLength { get; set; }
        public double Height { get; set; }

        public double GetArea()
        {
            return 0.5 * BaseLength * Height;
        }
    }
}
