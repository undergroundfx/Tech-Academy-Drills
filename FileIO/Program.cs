using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string number = Console.ReadLine();

            File.WriteAllText(@"C:\Users\mario\Desktop\log.txt", number);

            string text = File.ReadAllText(@"C:\Users\mario\Desktop\log.txt");

            Console.WriteLine(text);
            Console.ReadLine();

        }
    }
}
