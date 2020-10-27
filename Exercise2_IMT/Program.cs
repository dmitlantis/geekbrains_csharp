using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2_IMT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваш рост в м");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ваш вес в кг");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ваш индекс массы тела : " + (weight / (height * height)).ToString());
            Console.ReadLine();
        }
    }
}
