using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Написать метод подсчета количества цифр числа
 */
namespace Exercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Сумма чисел числа {a} равна {SumNumbers(a)}");
            Console.ReadKey();
        }

        public static int SumNumbers(int number)
        {
            if (number < 10)
            {
                return number;
            }
            return number % 10 + SumNumbers(number / 10);
        }
    }
}
