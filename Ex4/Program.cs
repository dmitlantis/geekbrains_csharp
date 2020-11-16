using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
/**
 * **Считайте файл различными способами. 
 *  * Смотрите “Пример записи файла различными способами”. Создайте методы, которые возвращают массив byte 
 *  * (FileStream, BufferedStream), строку для StreamReader и массив int для BinaryReader.
 *  
 *  Не уверен правильно ли я сделал считывание из буферезированого потока в фукнции BufferedStreamSample
 *  */
namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] fileStream, bufferedStream;
            string streamReader;
            int[] binaryReader;
            //Write FileStream
            //Write BinaryStream
            //Write StreamReader/StreamWriter
            //Write BufferedStream

            fileStream = FileStreamSample("C:\\Tmp\\bigdata0.bin");
            binaryReader = BinaryStreamSample("C:\\Tmp\\bigdata1.bin");
            streamReader = StreamReaderSample("C:\\Tmp\\bigdata2.bin");
            bufferedStream = BufferedStreamSample("C:\\Tmp\\bigdata3.bin");

            Console.ReadKey();
        }

        static byte[] FileStreamSample(string filename)
        {
            
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            //FileStream fs = new FileStream("D:\\temp\\bigdata.bin", FileMode.CreateNew, FileAccess.Write);
            byte[] result = new byte[fs.Length];
            for (int i = 0; i < fs.Length; i++)
                result[i] = (byte) fs.ReadByte();
            fs.Close();
            
            return result;
        }

        static int[] BinaryStreamSample(string filename)
        { 
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            int[] result = new int[fs.Length];
            BinaryReader bw = new BinaryReader(fs);
            for (int i = 0; i < fs.Length; i++)
                result[i] = bw.ReadByte();
            fs.Close();
           
            return result;
        }

        static string StreamReaderSample(string filename)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
           
            return sw.ReadToEnd();
        }

        static byte[] BufferedStreamSample(string filename)
        {

            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            long size = fs.Length;
            byte[] result = new byte[size];
            int countPart = 4;//количество частей
            int bufsize = (int)(size / countPart);
            
            BufferedStream bs = new BufferedStream(fs, bufsize);
            //bs.Write(buffer, 0, (int)size);//Error!
            for (int i = 0; i < countPart; i++) {
                bs.Read(result, 0, (int)bufsize);
            }

            fs.Close();
            
            return result;
        }
    }
}
