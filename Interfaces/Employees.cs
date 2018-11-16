using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Employees : IQuittable
    {
        public Employees()
        {

        }

        public bool Quit()
        {
            Console.WriteLine("True");
            Console.ReadLine();
            return true;
        }

    }
}
