using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricGuru
{
    public class Rectangle
    {   public double length;
        public double width;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public double Area()
        {
            return length * width;
        }
        public double Perimeter()
        {
            return 2 * (length + width);
        }
    }
}
