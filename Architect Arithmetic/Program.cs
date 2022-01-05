using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            CalculateTotalCost();
        }

        public static double RectangleArea(double lenght, double width)
        {
            double recArea = lenght * width;
            return recArea;
        }

        public static double CircleArea(double radius)
        {
            double cirArea = Math.PI * Math.Pow(radius, 2);
            return cirArea;
        }

        public static double TriangleArea(double bottom, double height)
        {
            double triArea = 0.5 * bottom * height;
            return triArea;
        }

        public static void Teotihuacan()
        {
            double totalArea = RectangleArea(2500, 1500) + CircleArea(375) + TriangleArea(750, 500);
            double mexicanPesos = 180;
            double totalAreaCost = totalArea * mexicanPesos;

            Console.WriteLine($"The total cost is {Math.Round(totalAreaCost, 2)} Pesos");
        }

        public static void TajMahal()
        {
            double totalArea = RectangleArea(90.5, 90.5) - (TriangleArea(24, 24) * 4);
            double mexicanPesos = 180;
            double totalAreaCost = totalArea * mexicanPesos;

            Console.WriteLine($"The total cost is {Math.Round(totalAreaCost, 2)} Pesos");
        }

        public static void GreatMosqueOfMecca()
        {
            double totalArea = RectangleArea(106,180) + RectangleArea(284, 200) - TriangleArea(84,264);
            double mexicanPesos = 180;
            double totalAreaCost = totalArea * mexicanPesos;

            Console.WriteLine($"The total cost is {Math.Round(totalAreaCost, 2)} Pesos");
        }

        public static void CalculateTotalCost()
        {
            Console.WriteLine($"Wich monument would you like to work with?");
            Console.WriteLine("1 - Teotihuacan in Mexico City, Mexico\n" +
                "2 - Taj Mahal in Agra, India\n" +
                "3 - Great Mosque of Mecca in Mecca, Saudi Arabia ");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case (1):
                        Teotihuacan();
                        break;

                case (2):
                    TajMahal();
                    break;

                case (3):
                    GreatMosqueOfMecca();
                    break;
                        
            }

        }
    }
}
