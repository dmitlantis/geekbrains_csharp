using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
 * б) Разработать рекурсивный метод, который считает сумму чисел от a до b.
*/
namespace Excercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            do
            {
                Console.WriteLine("Введите А");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите B");
                b = int.Parse(Console.ReadLine());
                if (a >= b)
                {
                    Console.WriteLine("Нужно A < B");
                }
            } while (a >= b);

            Console.WriteLine("Сумма чисел: " + Recursive(a, b, 0));
            Console.ReadKey();
        }

        static int Recursive(int a, int b, int sum)
        {
            Console.WriteLine("Число " + a);
            if (a == b)
            {
                return sum + b;
            }
            sum += a++;
            return Recursive(a, b, sum);
        }
    }
}
