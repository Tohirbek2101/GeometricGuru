using System;
using GeometricGuru;

namespace GeometricGuru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assalomu alaykum. Yuzalarni hisoblab beruvchi dasturmizga hush kelibsiz!!!");
            int shape = 0;
            do
            {
                Console.WriteLine("1. Aylana");
                Console.WriteLine("2. Kvadrat");
                Console.WriteLine("3. To'rtburchak");
                Console.WriteLine("4. Uchburchak");
                Console.WriteLine("0. Chiqish");
                Console.Write("Yuzasi hisoblash kerak bo'lgan shakl raqamini kiriting: ");
                shape = Convert.ToInt32(Console.ReadLine());
                switch (shape)
                {
                    case 1:
                        Console.Write("Aylananing radiusini kiriting: ");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        Circle myCircle = new Circle(radius);
                        Console.WriteLine($"Aylananing yuzi: {myCircle.Area()}");
                        Console.WriteLine($"Aylananing perimetri: {myCircle.Circumference()}");
                        break;
                    case 2:
                        Console.Write("Kvadratning tomon uzunligini kiriting: ");
                        double sideLength = Convert.ToDouble(Console.ReadLine());
                        Square mySquare = new Square(sideLength);
                        Console.WriteLine($"Kvadratning yuzi: {mySquare.Area()}");
                        Console.WriteLine($"Kvadratning perimetri: {mySquare.Perimeter()}");
                        break;
                    case 3:
                        Console.Write("To'rtburchakning uzunligini kiriting: ");
                        double length = Convert.ToDouble(Console.ReadLine());
                        Console.Write("To'rtburchakning kengligini kiriting: ");
                        double width = Convert.ToDouble(Console.ReadLine());
                        Rectangle myRectangle = new Rectangle(length, width);
                        Console.WriteLine($"To'rtburchakning yuzi: {myRectangle.Area()}");
                        Console.WriteLine($"To'rtburchakning perimetri: {myRectangle.Perimeter()}");
                        break;
                    case 4:
                        Console.Write("Uchburchakning birinchi tomonini kiriting: ");
                        double x = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Uchburchakning ikkinchi tomonini kiriting: ");
                        double y = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Uchburchakning uchinchi tomonini kiriting: ");
                        double z = Convert.ToDouble(Console.ReadLine());
                        Triangle myTriangle = new Triangle(x, y, z);
                        Console.WriteLine($"Uchburchakning yuzi: {myTriangle.Area()}");
                        Console.WriteLine($"Uchburchakning perimetri: {myTriangle.Perimeter()}");
                        break;
                    case 0:
                        Console.WriteLine("Dasturdan chiqilyapti. Xayr!");
                        break;
                    default:
                        Console.WriteLine("Noto'g'ri shakl raqami kiritildi.");
                        break;
                }



                } while (shape != 0) ;
            
        }
    }
}
