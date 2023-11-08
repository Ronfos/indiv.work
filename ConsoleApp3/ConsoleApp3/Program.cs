using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Sqr(double x)
        {
            Console.WriteLine($"Число {x} в квадрате = {Math.Pow(x, 2)}");
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число для возведения в квадрат: ");
            double a = double.Parse(Console.ReadLine());
            Sqr(a);
            Console.ReadKey();
        }
    }
}
