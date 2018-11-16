using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDrill
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                // get input from user
                Console.WriteLine("\nPlease select a number: ");
                int userNum = Convert.ToInt16(Console.ReadLine());

                // create Math object and call its methods
                var add = new Math();
                Console.WriteLine("Your number added is: " + Convert.ToString(add.Addition(userNum)));
                Console.WriteLine("Your number multiplied is: " + Convert.ToString(add.Multiply(userNum)));
                Console.WriteLine("Your number divided is: " + Convert.ToString(add.Divide(userNum)));

                Console.WriteLine("This is just a test {0} you know what I mean {1}", "mean", "jelly bean");
            }
        }
    }
}
