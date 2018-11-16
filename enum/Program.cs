using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a day of the week:");
            string day = Console.ReadLine();
            //Console.WriteLine(WeekDays.Saturday);
            //int value = Convert.ToInt16(WeekDays.Saturday);

            Console.WriteLine(WeekDays.Friday);
            Console.ReadLine();
        }

        enum WeekDays
        {
            Monday = 0,
            Tuesday = 1,
            Wednesday = 2,
            Thursday = 3,
            Friday = 4,
            Saturday = 5,
            Sunday = 6
        }
    }
}
