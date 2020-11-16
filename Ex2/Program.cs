using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
 * а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум. 
 * Использовать массив (или список) делегатов, в котором хранятся различные функции.
 * б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. 
 * Пусть она возвращает минимум через параметр (с использованием модификатора out). 
 * 
 * У матросов нет вопросов
*/
namespace Ex2
{
    delegate double Func(double x);
    class Program
    {
        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static double F2(double x)
        {
            return x * x / 2;
        }

        public static double F3(double x)
        {
            return Math.Sin(x);
        }

        public static void SaveFunc(string fileName, Func f, double from, double until, double step)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = from;
            while (x <= until)
            {
                bw.Write(f(x));
                x += step;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static List<double> Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            List<double> result = new List<double>();
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                result.Add(d);
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return result;
        }
        static void Main(string[] args)
        {
            Func[] funcs = new Func[3] { F, F2, F3 };
            Console.WriteLine("Выберите функцию 1-3:");
            Func f = funcs[int.Parse(Console.ReadLine())];
            Console.WriteLine("Выберите отрезок от:");
            double from = double.Parse(Console.ReadLine());
            Console.WriteLine("Выберите отрезок до:");
            double until = double.Parse(Console.ReadLine());
            SaveFunc("data.bin", f, from, until, 0.5);
            double min;
            List<double> list = Load("data.bin", out min);
            foreach (double d in list)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("min :" + min);
            Console.ReadKey();
        }
    }
}
