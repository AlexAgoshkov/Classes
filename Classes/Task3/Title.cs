using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Title 
    {
        public Title(string name)
        {
            _titleName = name;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(_titleName);
        }

        public string TitleName
        {
            get
            {
                return _titleName;
            }

        }


        private string _titleName;
    }
}
