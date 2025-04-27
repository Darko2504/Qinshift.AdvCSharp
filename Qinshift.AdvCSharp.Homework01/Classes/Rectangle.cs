
using Qinshift.AdvCSharp.Homework01.Interfaces;

namespace Qinshift.AdvCSharp.Homework01.Classes
{
   public class Rectangle : IArea
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double GetArea()
        {
            return Width * Height;
        }
    }
}
