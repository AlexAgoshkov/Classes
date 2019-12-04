using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Rectangle's Sides");
            double side1 = Convert.ToDouble(Console.ReadLine());

            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);


            Console.WriteLine("Rectangle Area");
            Console.WriteLine(rectangle.Area);
            Console.WriteLine("Rectangle Perimeter");
            Console.WriteLine(rectangle.Perimeter);


            Console.ReadKey();
        }
    }
}
