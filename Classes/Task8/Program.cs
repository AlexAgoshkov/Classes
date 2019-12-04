using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1, "Bob", "USA");
            invoice.OrderList(250, "PC", 1);


            Console.ReadKey();
        }
    }
}
