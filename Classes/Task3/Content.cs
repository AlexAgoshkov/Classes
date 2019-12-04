using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Content
    {
        public Content(string name)
        {
            _content = name;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(_content);
        }

        public string Contents
        {
            get
            {
                return _content;
            }

        }

        private string _content;
    }
}
