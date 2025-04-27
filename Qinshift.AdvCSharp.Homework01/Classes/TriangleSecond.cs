
namespace Qinshift.AdvCSharp.Homework01.Classes
{
   public class TriangleSecond : Shape
    {
        public double BaseLength { get; set; }
        public double Height { get; set; }
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public TriangleSecond(double baseLength, double height, double sideA, double sideB, double sideC)
        {
            BaseLength = baseLength;
            Height = height;
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double CalculateArea()
        {
            return 0.5 * BaseLength * Height;
        }

        public override double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }
    }
}
