using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Point
    {
        public Point(int a, int b, string name)
        {
            _a = a;
            _b = b;
            _name = name;
        }


        public int A
        {
            get
            {
                return _a;
            }
        }

        public int B
        {
            get
            {
                return _b;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        private string _name;

        private int _a;

        private int _b;
    }
}
