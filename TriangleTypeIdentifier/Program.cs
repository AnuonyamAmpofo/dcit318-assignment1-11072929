using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Triangle Type Identifier ===");

            Console.Write("Enter length of side 1: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter length of side 2: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter length of side 3: ");
            double side3 = Convert.ToDouble(Console.ReadLine());

            // Check if the sides can form a valid triangle
            if (IsValidTriangle(side1, side2, side3))
            {
                string triangleType = GetTriangleType(side1, side2, side3);
                Console.WriteLine($"The triangle is: {triangleType}");
            }
            else
            {
                Console.WriteLine("The given sides do not form a valid triangle.");
            }
        }

        static bool IsValidTriangle(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        static string GetTriangleType(double a, double b, double c)
        {
            if (a == b && b == c)
                return "Equilateral";
            else if (a == b || b == c || a == c)
                return "Isosceles";
            else
                return "Scalene";
        }
    }
}
