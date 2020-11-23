using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * С помощью рефлексии выведите все свойства структуры DateTime
 * 
 * У матросов нет вопросов.
 */
namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(DateTime);
            foreach(System.Reflection.PropertyInfo property in type.GetProperties())
            {
                Console.WriteLine("Пропертя: " + property.Name);
            }
            Console.ReadKey();
        }
    }
}
