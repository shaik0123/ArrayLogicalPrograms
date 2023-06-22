using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayLogical
{
    public  class PrintValues
    {
        
        public static void Values(int n)
        { 
            Console.WriteLine(n);
            if (n < 100 ) 
            {
                Values(n+1);

            }
        }
    }
}
