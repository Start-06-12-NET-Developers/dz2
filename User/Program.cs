using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    class User
    {
        public string login, name, lastname;
        public int age;
        public readonly DateTime data = DateTime.Now;

        public User(string login, string name, string lastname, int age)
        {
            this.login = login;
            this.name = name;
            this.lastname = lastname;
            this.age = age;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            string lgn, names, lnames, ages;

            Console.WriteLine("Создание профиля");
            Console.Write("Введите Логин: ");
            lgn = Console.ReadLine();
            Console.Write("Введите Имя: ");
            names = Console.ReadLine();
            Console.Write("Введите Фамилию: ");
            lnames = Console.ReadLine();
            Console.Write("Введите Возраст: ");
            ages = Console.ReadLine();

            User user = new User(lgn, names, lnames, Convert.ToInt32(ages));
            Console.Clear();

            Console.WriteLine("Профиль");
            Console.WriteLine("Login: " + user.login);
            Console.WriteLine("Name: " + user.name);
            Console.WriteLine("LastName: " + user.lastname);
            Console.WriteLine("Age: " + user.age);
            Console.WriteLine("Date: " + user.data);


            Console.ReadKey();
        }
    }
}
