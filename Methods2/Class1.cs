using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Class1
    {
        public Class1()
        {

        }

        public int Math(int num1)
        {
            int sum = num1 * 100;
            return sum;
        }

        public decimal Math(decimal num1)
        {
            decimal sum = num1 + 100.50m;
            return sum;
        }

        public int Math(string num1)
        {
            int sum = Convert.ToInt32(num1) - 50;
            return sum;
        }
    }
}
