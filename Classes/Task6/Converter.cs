using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Converter
    {
        public Converter(double usd, double eur, double rub)
        {
            _usd = usd;
            _eur = eur;
            _rub = rub;
        }

        public double ConvertToUsd(double uah)
        {
            return uah / _usd;
        }

        public double ConvertToEur(double uah)
        {
            return uah / _eur;
        }

        public double ConvertToRub(double uah)
        {
            return uah / _rub;
        }

        public double ConvertUsdToUah(double currency)
        {
            return _usd * currency;
        }

        public double ConvertRubToUah(double currency)
        {
            return _rub * currency;
        }

        public double ConvertEurToUah(double currency)
        {
            return _eur * currency;
        }

        private double _usd;

        private double _eur;

        private double _rub;
    }
}
