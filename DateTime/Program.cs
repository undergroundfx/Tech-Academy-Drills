using System;

namespace DateTimer
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(DateTime.Now);

            Console.WriteLine("Please Enter a Number: ");   

            int num = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(DateTime.Now.AddHours(num));
            Console.ReadLine();
        }
    }
}
