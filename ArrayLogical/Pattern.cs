using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayLogical
{
    public  class Pattern
    {
        public static void Star()
        {
            int row =7;
            for (int i = row; i >= 0; i--) {      
                for (int j = 0; j <=i; j++) { 
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
