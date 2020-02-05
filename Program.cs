using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                var D = new SortedDeque<int>();
                string path = @"C:\\Users\\DNS\\source\\repos\\ConsoleApp26\\ConsoleApp26\\integers.txt";

                StreamReader sr = new StreamReader(path);

                string line;
                while ((line = sr.ReadLine()) != null)
                {

                    Console.WriteLine(line);
                    int x = int.Parse(line);
                    if (x >= -100 && x <= 100)
                        D.PushBack(x);
                }

                while (D.Count >= 2)
                {
                    string[] text = (D.PopBack().ToString() + " , -" + D.PopFront().ToString()).Split('\n');
                    File.AppendAllLines(@"C:\\Users\\DNS\\source\\repos\\ConsoleApp26\\ConsoleApp26\\results.txt", text);
                }
                Console.WriteLine("Press <escape> to exit...");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
