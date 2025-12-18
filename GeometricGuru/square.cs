using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricGuru
{
    public class Square
    {
        public double sideLength;
        public Square(double sideLength)
        {
            this.sideLength = sideLength;
        }
        public double Area()
        {
            return sideLength * sideLength;
        }
        public double Perimeter()
        {
            return 4 * sideLength;
        }
    }
}
