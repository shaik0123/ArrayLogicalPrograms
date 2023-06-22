using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayLogical
{
    public  class ElementFrequency
    {
        public static void Frequency() 
        {
            int[] arr = { 1, 1, 2, 3, 4, 4, 5, 6, 6 };
            for (int i = 0; i < arr.Length; i++) 
            {
                int x = arr[i];
                int count = 0;
                if (x == -1)
                {
                    continue;
                }
                for (int j = 0; j < arr.Length; j++) 
                {
                    if (arr[j] == x)
                    {
                        count++;
                        arr[j] = -1;
                    }
                }
                Console.WriteLine("frequency : " + x + "   count : " + count);
            }
            
        }
    }
}
