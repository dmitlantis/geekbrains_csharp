using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
 * Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран,
 * используя tryParse;
 * б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. 
 * При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;
 *
 * У матросов нет вопросов.
 */
namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, sum = 0;
            do
            {
                try
                {
                    a = summary(ref sum);
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
            } while (a > 0);
            Console.WriteLine("Сумма всех нечётных положительных чисел равна: " + sum);
            Console.ReadKey();
        }

        private static int summary(ref int sum)
        {
            int a;
            Console.WriteLine("Введите чиселко:");
            if (!Int32.TryParse(Console.ReadLine(), out a))
            {
                throw new Exception("Введены некорректные данные");
            }
            if (a > 0 && a % 2 == 1)
            {
                sum += a;
            }

            return a;
        }
    }
}
