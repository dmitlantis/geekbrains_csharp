using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_Measures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y2");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Расстояние между точками: " + calculateDistance(x1, y1, x2, y2).ToString("###.##"));
            Console.ReadLine();
        }

        static double calculateDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
