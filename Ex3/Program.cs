using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
/**
 * Переделать программу Пример использования коллекций для решения следующих задач:
 * а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
 * б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
 * в) отсортировать список по возрасту студента;
 * г) *отсортировать список по курсу и возрасту студента;
 * 
 * У матросов нет вопросов.
*/
namespace Ex3
{
    class Program
    {
        struct Student: IComparer
        {
            public int age;
            public int course;
            public string fio;

            // отсортировать список сначала по курсу, потом по возрасту студента;
            public int Compare(object x, object y)
            {
                Student studentX = (Student)x;
                Student studentY = (Student)y;
                if (studentX.course == studentY.course)
                {
                    return studentX.age - studentY.age;
                } else
                {
                    return studentX.course - studentY.course;
                }
            }
        }
    
        static void Main(string[] args)
        {
            int numOfBachelors = 0;
            int numOfMasters = 0;
            // Частотный массив под студентов 18 - 20 лет
            int[] numoOf1820Course = new int[6];

            // Создадим необобщенный список
            List<Student> list = new List<Student>();
            // Запомним время в начале обработки данных
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("..\\..\\students_1.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Console.WriteLine("{0}", s[0], s[1], s[2], s[3], s[4]);]
                    Student student = new Student() { fio = s[1] + " " + s[0], age = int.Parse(s[5]), course = int.Parse(s[6])};
                    list.Add(student);// Добавляем склееные имя и фамилию
                    if (student.course < 5)
                    {
                        numOfBachelors++;
                    }
                    else
                    {
                        numOfMasters++;
                    }
                    
                    if (student.age >= 18 && student.age <= 20) {
                        numoOf1820Course[student.course]++;
                    }
                }
                catch
                {
                }
            }
            sr.Close();
            list.Sort();
            Console.WriteLine("Всего студентов:{0}", list.Count);
            Console.WriteLine("Магистров:{0}", numOfMasters);
            Console.WriteLine("Бакалавров:{0}", numOfBachelors);
            Console.WriteLine("Учащихся на 5-6 курсах :{0}", numOfMasters); // по условию задачи 5-6 куурс и есть магистры
            for (int course = 1; course <= 6; course++)
            {
                Console.WriteLine($"Учащихся 18-20 лет на {course} курсe : " + numoOf1820Course[course]);
            }

            list.Sort();

            foreach (var v in list) Console.WriteLine(v.fio);
            // Вычислим время обработки данных
            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();
        }
    }

}
