using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Rectangle
    {
        public Rectangle(double side1, double side2)
        {
            _side1 = side1;
            _side2 = side2;
        }

        private double GetAreaCalculator()
        {
            return _side1 * _side2;
        }

        private double GetPerimeterCalculator()
        {
            return (_side1 + _side2) * 2;
        }


        public double Area
        {
            get
            {
                return GetAreaCalculator();
            }
        }

        public double Perimeter
        {
            get
            {
                return GetPerimeterCalculator();
            }
        }


        private double _side1;

        private double _side2;
    }
}
