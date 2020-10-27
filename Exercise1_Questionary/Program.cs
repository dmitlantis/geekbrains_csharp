using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Questionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию");
            string fam = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст");
            string age = Console.ReadLine();
            Console.WriteLine("Введите ваш рост");
            string height = Console.ReadLine();
            Console.WriteLine("Введите ваш вес");
            string weight = Console.ReadLine();
            Console.WriteLine("Здравствуйте" + name + " " + fam + " ваш рост составляет " + height + ", ваш вес " + weight + " и это при возрасте в " + age + " лет!");
            Console.WriteLine("Здравствуйте {0} {1} ваш рост составляет {2}, ваш вес {3}  и это при возрасте в {4} лет!", name, fam, height, weight, age);
            Console.WriteLine($"Здравствуйте {name} {fam} ваш рост составляет {height}, ваш вес {weight}  и это при возрасте в {age} лет!");
            Console.ReadLine();
        }
    }
}
