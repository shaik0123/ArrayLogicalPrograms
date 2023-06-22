using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayLogical
{
    public  class MinimumElement
    {
        public static void Min()
        {
            int[] array = { 21, 32, 9, 36, 11 };
            int min = array[0];
            for (int i = 0; i < array.Length; i++) 
            {
                if (array[i] < min)
                {
                    min = array[i]; 
                }
            }
            Console.WriteLine(min);
        }
    }
}
