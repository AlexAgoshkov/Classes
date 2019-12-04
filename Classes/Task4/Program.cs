using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(3, 3, "A");
            Point b = new Point(4, 6, "B");
            Point c = new Point(6, 2, "C");
            Point d = new Point(7, 4, "D");
            Point g = new Point(2, 5, "G");


            Figure figure = new Figure(a, b, c, d, g);

            Console.WriteLine(figure.LengthSide(a,b));
            figure.PerimeterCalculator();

            
            Console.WriteLine($"Perimeter of {figure.NameOfFigure} = {figure.Perimeter}");


            Console.ReadKey();
        }
    }
}
