using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachaSumirane
{
    internal class Rectangle : Shape
    {

         public double Width{ get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double calculatePerimeter()
        {
            return (Width + Height) * 2;
        }

        public override double calculateArea()
        {
            return Width * Height;
        }
    }
}
