using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayLogical
{
    public  class PatternTwo
    {
        public static void Square()
        {
            int row = 7;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                     if (i == 0 || j == 0 || i == row - 1 || j == row - 1)
                     { 
                         Console.Write("*");
                     }
                     else
                     {
                         Console.Write(" ");
                     }
                    //Console.Write("*");
                  
                }
                Console.WriteLine();
            }
        }
    }
}
