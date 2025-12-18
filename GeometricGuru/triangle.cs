using System;

namespace GeometricGuru
{
    public class Triangle
    {
        public double x;
        public double y;
        public double z;
        public bool IsValid { get; private set; } // Uchburchak to‘g‘ri ekanligini saqlash

        public Triangle(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;

            // Uchburchak tengsizligini tekshirish
            if (x + y > z && y + z > x && z + x > y)
            {
                IsValid = true;
            }
            else
            {
                Console.WriteLine("Bunday tomonlarga ega uchburchak mavjud emas!");
                Console.WriteLine("Eslatma: Uchburchak tengsizligi bajarilishi uchun istalgan ikkita tomon yig'indisi uchinchi tomondan katta bo'lishi kerak");
                IsValid = false;
            }
        }

        public double Area()
        {
            if (!IsValid)
            {
                return 0;
               
            }

            double p = (x + y + z) / 2;
            return Math.Sqrt(p * (p - x) * (p - y) * (p - z));
        }

        public double Perimeter()
        {
            if (!IsValid)
            {
               return 0;
            }

            return x + y + z;
        }
    }
}