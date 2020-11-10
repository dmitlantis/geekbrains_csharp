using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/**
 * Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, 
 * содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
 * а) без использования регулярных выражений;
 * б) **с использованием регулярных выражений.
 * 
 * У матросов нет вопросов!
*/
namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите логин");
            string login = Console.ReadLine();

            Regex regex = new Regex(@"^[A-z][A-z\d]{1,9}$");
            if (!regex.IsMatch(login))
            {
                Console.WriteLine("Некорректный логин");
            }
            
            if (login.Length < 2 || login.Length > 10)
            {
                Console.WriteLine("Неверная длина логина");
                Console.ReadKey();
                return;
            }

            if (Char.IsDigit(login[0]))
            {
                Console.WriteLine("Число не должно начинаться с цифры");
                Console.ReadKey();
                return;
            }

            for (int i = 0; i<login.Length; i++)
            {
                if (!Char.IsDigit(login[i]) && (login[i] < 'A' || login[i] > 'z'))
                {
                    Console.WriteLine("Число должно состоять только из букв и цифр!");
                    Console.ReadKey();
                    return;
                }
            }


            Console.WriteLine($"Логин `{login}` корректен!");
            Console.ReadKey();
          
        }
    }
}
