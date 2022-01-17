using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        public string name, lastname, position;
        public double oklad, nalog;

        public void Oklad (string pos, int exp)
        {
            switch (pos)
            {
                case "director":
                    {
                        if ((0 < exp) & (exp <= 5))
                        {
                            this.oklad = 30000;
                            this.nalog = this.oklad * 0.18;
                            break;
                        }
                        else if ((5 < exp) & (exp <= 15))
                        {
                            this.oklad = 30000 + (30000 * 0.1);
                            this.nalog = this.oklad * 0.18;
                            break;
                        }
                        else if ((15 < exp) & (exp <= 30))
                        {
                            this.oklad = 30000 + (30000 * 0.2);
                            this.nalog = this.oklad * 0.18;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимый стаж");
                            this.oklad = 0;
                            this.nalog = this.oklad * 0.18;
                            break;
                        }
                    }
                case "accountant":
                    {
                        if ((0 < exp) & (exp <= 5))
                        {
                            this.oklad = 20000;
                            this.nalog = this.oklad * 0.18;
                            break;
                        }
                        else if ((5 < exp) & (exp <= 15))
                        {
                            this.oklad = 20000 + (20000 * 0.1);
                            this.nalog = this.oklad * 0.18;
                            break;
                        }
                        else if ((15 < exp) & (exp <= 30))
                        {
                            this.oklad = 20000 + (20000 * 0.2);
                            this.nalog = this.oklad * 0.18;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимый стаж");
                            this.oklad = 0;
                            this.nalog = this.oklad * 0.18;
                            break;
                        }
                    }
                case "engineer":
                    {
                        if ((0 < exp) & (exp <= 5))
                        {
                            this.oklad = 15000;
                            this.nalog = this.oklad * 0.18;
                            break;
                        }
                        else if ((5 < exp) & (exp <= 15))
                        {
                            this.oklad = 15000 + (15000 * 0.1);
                            this.nalog = this.oklad * 0.18;
                            break;
                        }
                        else if ((15 < exp) & (exp <= 30))
                        {
                            this.oklad = 15000 + (15000 * 0.2);
                            this.nalog = this.oklad * 0.18;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимый стаж");
                            Console.WriteLine();
                            this.oklad = 0;
                            this.nalog = this.oklad * 0.18;
                            break;
                        }
                    }
                default:
                    {
                        Console.WriteLine("Недопустимая должность");
                        Console.WriteLine();
                        this.oklad = 0;
                        this.nalog = this.oklad * 0.18;
                        break;
                    }
            }
        }


        public void PosExp()
        {
            switch (lastname)
            {
                case "Andreev":
                    {
                        this.position = "director";
                        Oklad(this.position, 20);
                        break;
                    }
                case "Ivanov":
                    {
                        this.position = "accountant";
                        Oklad(this.position, 10);
                        break;
                    }
                case "Petrov":
                    {
                        this.position = "engineer";
                        Oklad(this.position, 5);
                        break;
                    }
            }
        }

        public Employee (string name, string lastname)
        {
            this.name = name;
            this.lastname = lastname;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string names, lnames;

            Start:

            Console.Write("Введите Фамилию: ");
            lnames = Console.ReadLine();
            Console.Write("Введите Имя: ");
            names = Console.ReadLine();

            if (((lnames == "Andreev") && (names == "Andrey")) || ((lnames == "Ivanov") & (names == "Ivan")) || ((lnames == "Petrov") & (names == "Petr")))
            {
                Console.Clear();

                Employee emp = new Employee(names, lnames);
                emp.PosExp();

                Console.WriteLine("Фамилия: " + emp.lastname);
                Console.WriteLine("Имя: " + emp.name);
                Console.WriteLine("Должность: " + emp.position);
                Console.WriteLine("Оклад: " + emp.oklad);
                Console.WriteLine("Налоговый сбор: " + (emp.nalog));
            }

            
            else
            {
                Console.WriteLine("Сотрудник отсутствует в базе");
                Console.ReadKey();
                Console.Clear();

                goto Start;
            }

            Console.ReadKey();
        }
    }
}
