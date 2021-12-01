using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double length = double.Parse(Console.ReadLine());
                double area = length * length;

                Console.WriteLine($"{area:f3}");
            }
            else if (figure == "rectangle")
            {
                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                double area = length * width;

                Console.WriteLine($"{area:f3}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Math.PI * Math.Pow(radius,2);

                Console.WriteLine($"{area:f3}");
            }
            else if (figure == "triangle")
            {
                double length = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = (length / 2) * height;

                Console.WriteLine($"{area:f3}");
            }
        }
    }
}
