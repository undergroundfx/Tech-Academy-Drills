using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Options
    {
        public Options()
        {

        }

        // method with optional (default) value
        public int Optional(int num1, int num2 = 10)
        {
            int sum = num1 * num2;
            return sum;
        }
    }
}
