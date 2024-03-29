﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Address
    {
        public Address(int index, string country, string city, string street,int house, int apartment)
        {
            _index = index;
            _country = country;
            _city = city;
            _street = street;
            _house = house;
            _apartment = apartment;
        }

        public int Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                _apartment = value;
            }
        }

        public int House
        {
            get
            {
                return _house;
            }
            set
            {
                _house = value;
            }
        }

        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                _street = value;
            }
        }

        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }

        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
            }
        }

        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                _index = value;
            }
        }

        private int _index;

        private string _country;

        private string _city;

        private string _street;

        private int _house;

        private int _apartment;
    }
}
