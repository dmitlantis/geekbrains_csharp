using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 
 * Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
 * а) Вывести только те слова сообщения,  которые содержат не более n букв.
 * б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
 * в) Найти самое длинное слово сообщения.
 * г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
 * 
 * У матросов нет вопросов!
 * 
 */
namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность слов, разделённых пробелом");
            string words = Console.ReadLine();
            Console.WriteLine("Слова, длинной не более 5 символов:");
            Console.WriteLine(Message.noMoreThan(words, 5));
            Console.WriteLine("Слова, не заканчивающиеся на букву `z`:");
            Console.WriteLine(Message.deleteEnding(words, 'z'));
            Console.WriteLine("Самые длинные слова:");
            Console.WriteLine(Message.findLongestWords(words));
            Console.ReadKey();
        }
    }
}
