﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Number amount = new Number()
            {
                Amount = 58.50m
            };

            Console.WriteLine(amount.Amount);
            Console.ReadLine();
        }

        public struct Number
        {
            public decimal Amount;
        }

    }



}
