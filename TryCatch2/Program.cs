using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            //string age = Console.ReadLine();
            int num = Convert.ToInt16(Console.ReadLine());

            DateTime year = DateTime.Now.AddYears(-num);

            Console.WriteLine(year.Year); 
            Console.ReadLine();
        }
    }
}
