using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Figure
    {
        public Figure(Point A, Point B, Point C, Point D, Point G)
        {
            _a = A;
            _b = B;
            _c = C;
            _d = D;
            _g = G;
        }

        public Figure(Point A, Point B, Point C, Point D)
        {
            _a = A;
            _b = B;
            _c = C;
            _d = D;
        }

        public Figure(Point A, Point B, Point C)
        {
            _a = A;
            _b = B;
            _c = C;
        }


        public double LengthSide(Point A, Point B)
        {
            return ((A.A - A.B) * 2) + ((B.A - B.B) * 2);
        }

        public void PerimeterCalculator()
        {
            Point[] points = new Point[] { _a, _b, _c, _d, _g };

            for (int i = 0; i < points.Length; i++)
            {
                if (i != points.Length -1)
                {
                    _perimeter += LengthSide(points[i], points[i + 1]);
                }
                else
                {
                    _perimeter += LengthSide(points[points.Length - 1], points[0]);     
                }
                
            }

            _nameOfFigure = "Polygon";
        }

        public double Perimeter
        {
            get
            {
                return _perimeter;
            }
        }

        public string NameOfFigure
        {
            get
            {
                return _nameOfFigure;
            }
        }

        private string _nameOfFigure;

        private double _perimeter;

        private Point _a;

        private Point _b;

        private Point _c;

        private Point _d;

        private Point _g;

    }
}
