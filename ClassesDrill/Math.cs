using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDrill
{
    public class Math
    {
        // all classes must have this constructor
        public Math()
        {

        }

        // create an int valued method
        public int Addition(int num)
        {
            int answer = num + 42;
            return answer;
        }

        public int Multiply(int num)
        {
            int answer = num * 42;
            return answer;
        }

        public int Divide(int num)
        {
            int answer = num / 42;
            return answer;
        }
    }
}
