using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Options Option = new Options();

            Console.WriteLine("Please enter a number: ");
            int num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please enter another number or leave blank: ");
            int num2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(Option.Optional(num1, num2));
            Console.ReadLine();
        }
    }
}
