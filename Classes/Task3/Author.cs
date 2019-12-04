using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Author
    {
        public Author(string name)
        {
            _authorName = name;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(_authorName);
        }

        public string AuthorName
        {
            get
            {
                return _authorName;
            }

        }

        private string _authorName; 
    }
}
