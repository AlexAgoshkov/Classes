﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{


    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.AddBook("Johny", "Visual Studio", "Text");
            book.Showk();

            Console.ReadKey();
        }
    }
}
