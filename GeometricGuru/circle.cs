using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricGuru
{
    public class Circle
    {
        public double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double Area()
        {
            return Math.PI * radius * radius;
        }
        public double Circumference()
        {
            return 2 * Math.PI * radius;
        }
    }
}
