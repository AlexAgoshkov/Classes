using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address(2, "Ukraine", "Dnipro", "Center", 25, 56);

            Console.WriteLine($"Index - {address.Index}");
            Console.WriteLine($"Country - {address.Country}");
            Console.WriteLine($"City - {address.City}");
            Console.WriteLine($"Street - {address.Street}");
            Console.WriteLine($"House - {address.House}");
            Console.WriteLine($"Apartment - {address.Apartment}");

            Console.ReadKey();
        }
    }
}
