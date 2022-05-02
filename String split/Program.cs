using System;

namespace String_split
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сообщение!");
            string str = Convert.ToString(Console.ReadLine());
            string[] line = str.Split(' ');
            foreach (var lineStr in line)
            {
                Console.WriteLine(lineStr);
            }
        }
    }
}
