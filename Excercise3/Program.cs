using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел
 */
namespace Excercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, sum = 0;
            do
            {
                Console.WriteLine("Введите чиселко:");
                a = int.Parse(Console.ReadLine());
                if (a > 0 && a % 2 == 1)
                {
                    sum += a;
                }
            } while (a > 0);
            Console.WriteLine("Сумма всех нечётных положительных чисел равна: " + sum);
            Console.ReadKey();
        }
    }
}
