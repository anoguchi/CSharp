﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsParameters
{
    public static class MathShortcuts
    {
        public static double Add(double x, double y)
        {
            // Console.WriteLine($"The value of {x} and {y} is {x + y}"); 
            double output = x + y;
            return output;
        }

        public static void AddAll(double[] values)
        {
            double result = 0;
            foreach (double value in values)
            {
                result += value;
            }
            Console.WriteLine($"The total is {result}");
        }
    }
}
