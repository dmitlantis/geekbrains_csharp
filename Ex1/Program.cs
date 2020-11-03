using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
в) Добавить диалог с использованием switch демонстрирующий работу класса.

Вопрос: есть ли в C# оператор возведения в степень аналог Math.Pow() (например ** или ^)
*/
namespace Ex1
{

    class Program
    {
        static void Main(string[] args)
        { 
            Complex complex1;
            
            complex1 = new Complex(1, -2);
           
            Complex complex2 = new Complex(-1, 1);

            Complex result;
            Console.WriteLine("Введите операцию: +,-,*,/");

            switch (Console.ReadLine())
            {
                case "+":
                    result = complex1.Plus(complex2);
                    break;
                case "-":
                    result = complex1.Minus(complex2);
                    break;
                case "*":
                    result = complex1.Multi(complex2);
                    break;
                case "/":
                    result = complex1.Devide(complex2);
                    break;
                default:
                    Console.WriteLine("Недопустимая операция введена");
                    return;
            }

            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}
