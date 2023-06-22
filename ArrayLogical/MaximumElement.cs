using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayLogical
{
    public class MaximumElement
    {
        public static void Max()
        {
            int[] array = { 21, 32, 9, 36, 90 };
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
