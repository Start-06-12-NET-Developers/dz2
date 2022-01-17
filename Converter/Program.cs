using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Converter
    {
        public double usdk, eurk, rubk;
        public double usd, eur, rub;

        public Converter(double usd = 0, double eur = 0, double rub = 0)
        {
            this.usdk = 27.7;
            this.eurk = 31.4;
            this.rubk = 0.36;

            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
        
        public void ConvertTo ()
        {
            if (usd != 0)
            {
                Console.WriteLine("Сумма в usd = " + usd / usdk);
            }
            else if (eur != 0)
            {
                Console.WriteLine("Сумма в eur = " + eur / eurk);
            }
            else if (rub != 0)
            {
                Console.WriteLine("Сумма в rub = " + rub / rubk);
            }
        }

        public void ConvertFrom()
        {
            if (usd != 0)
            {
                Console.WriteLine("Сумма в uah = " + usd * usdk);
            }
            else if (eur != 0)
            {
                Console.WriteLine("Сумма в uah = " + eur * eurk);
            }
            else if (rub != 0)
            {
                Console.WriteLine("Сумма в uah = " + rub * rubk);
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            string val,sum;

            Console.Write("Введите желаемую валюту (usd,eur,rub): ");
            val = Console.ReadLine();
            Console.Write("Введите сумму обмена: ");
            sum = Console.ReadLine();

            if (val == "usd")
            {
                Converter conv = new Converter(usd:Convert.ToDouble(sum));
                conv.ConvertTo();
            }
            else if (val == "eur")
            {
                Converter conv = new Converter(eur:Convert.ToDouble(sum));
                conv.ConvertTo();
            }
            else if (val == "rub")
            {
                Converter conv = new Converter(rub:Convert.ToDouble(sum));
                conv.ConvertTo();
            }
            else
            {
                Console.WriteLine("Введена недопустимая валюта");
            }

            Console.WriteLine(new string ('-',50));

            Console.Write("Введите вашу валюту (usd,eur,rub): ");
            val = Console.ReadLine();
            Console.Write("Введите сумму обмена: ");
            sum = Console.ReadLine();

            if (val == "usd")
            {
                Converter conv = new Converter(usd: Convert.ToDouble(sum));
                conv.ConvertFrom();
            }
            else if (val == "eur")
            {
                Converter conv = new Converter(eur: Convert.ToDouble(sum));
                conv.ConvertFrom();
            }
            else if (val == "rub")
            {
                Converter conv = new Converter(rub: Convert.ToDouble(sum));
                conv.ConvertFrom();
            }
            else
            {
                Console.WriteLine("Введена недопустимая валюта");
            }

            Console.ReadKey();
        }
    }
}
