using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(24.4, 28.7, 0.37);

            Console.WriteLine(converter.ConvertToUsd(1000));
            Console.WriteLine(converter.ConvertToEur(1000));
            Console.WriteLine(converter.ConvertToRub(1000));

            Console.WriteLine(converter.ConvertUsdToUah(100));
            Console.WriteLine(converter.ConvertEurToUah(100));
            Console.WriteLine(converter.ConvertRubToUah(100));

            Console.ReadKey();
        }
    }
}
