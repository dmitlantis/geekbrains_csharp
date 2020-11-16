using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
 * Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
 * 
 * 
 * У матросов нет вопросов!
 */
namespace Ex1
{
    // Комментарий о том какой тут прекрасный делегат
    delegate double Func(double a, double b);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите а=");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Func1");
            Table(Func1, -3, 1, 3);
            Console.WriteLine("Func2");
            Table(Func2, -3, 1, 3);
            Console.ReadKey();
        }

        // Комментарий о том как тут выводится любая функция с подходящей сигнатурой
        static void Table(Func func, double x, double a, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, func(a, x));
                x += 1;
            }
            Console.WriteLine("---------------------");

        }

        static double Func1(double a, double x)
        {
            return a * x * x;
        }

        static double Func2(double a, double x)
        {
            return a * Math.Sin(x);
        }
    }
}
