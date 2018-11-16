using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpertaorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees employees1 = new Employees()
            {
                Id = 25
            };

            Employees employees2 = new Employees()
            {
                Id = 25
            };

            if (employees1 == employees2)
                Console.WriteLine("Employees ID's are equal");
            else
                Console.WriteLine("Employees ID's are not equal");
      
            Console.ReadLine();
        }
    }
    
}
