using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class User
    {
        public User(string login, string name, string surname, int age)
        {
            _login = login;
            _name = name;
            _surname = surname;
            _age = age;
            _dateOfCreate = DateTime.Now;
        }

        public void Show()
        {
            Console.WriteLine($"User Login - {_login}");
            Console.WriteLine($"User Name - {_name}");
            Console.WriteLine($"User Surname {_surname}");
            Console.WriteLine($"User Age - {_age}");
            Console.WriteLine($"Date of creation - {_dateOfCreate}");
        }


        private int _age;

        private string _surname;

        private string _login;

        private string _name;

        readonly DateTime _dateOfCreate;
    }
}
