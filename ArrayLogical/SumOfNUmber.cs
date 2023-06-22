using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayLogical
{
    public  class SumOfNUmber
    {
        public static void Num(int num)
        {
            int r;
            int sum = 0;
            while (num > 0)
            { 
                r = num % 10;
                sum = sum + r;
                num = num / 10;
            }
            Console.Write(sum);
            Console.WriteLine("");
        }
    }
}
