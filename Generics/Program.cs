using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            Employees<string> myStrings = new Employees<string>();


            myStrings.Things.Add("Text here");

            Console.ReadLine();
        }
    }
}
