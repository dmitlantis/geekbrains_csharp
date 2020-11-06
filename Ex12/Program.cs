using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex12
{
    class StaticClass
    {
        public static int findPairs(int[] a)
        {
            int pairs = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (i + 1 == a.Length)
                {
                    return pairs;
                }
                if (a[i] % 3 == 0 && a[i + 1] % 3 != 0)
                {
                    pairs++;
                }
                if (a[i + 1] % 3 == 0 && a[i] % 3 != 0)
                {
                    pairs++;
                }
            }
            return pairs;
        }

        public static int[] loadFile(string filename)
        {
            if (!File.Exists(filename))
            {
                return new int[0];
            }
            string[] ss = File.ReadAllLines(filename);
            int[] a = new int[ss.Length];

            for (int i = 0; i < ss.Length; i++)
            {
                try
                {
                    a[i] = int.Parse(ss[i]);
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }

            }
            return a;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[20];
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(-10000, 10000);
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Количество пар: " + StaticClass.findPairs(a));
            Console.ReadKey();

        }
    }
}
