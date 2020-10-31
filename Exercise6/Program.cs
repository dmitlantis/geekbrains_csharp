using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise2;
/**
 * Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
 * «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
*/
namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            int goodNumbers = 0;
            for (int i = 1; i <= 1000000000; i++)
            {
                if (i % Exercise2.Program.SumNumbers(i) == 0)
                {
                    goodNumbers++;
                    Console.WriteLine($"Хорошее число {i}");
                }
            }
            Console.WriteLine($"Общее количество хороших чисел: {goodNumbers}");
            Console.WriteLine("Время выполнения: " + (DateTime.Now - start));
            Console.ReadKey();
        }
    }
}
