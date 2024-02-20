using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZadachaSumirane
{
    internal class Circle : Shape
    {


        public double Radius { get; set; }

        public Circle(double radius)
        {
              Radius = radius;
        }
        public override double calculateArea()
        {
           return Math.PI * Radius * Radius;
        }

        public override double calculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public override string Draw()
        {
            "circle";
        }
    }
}
