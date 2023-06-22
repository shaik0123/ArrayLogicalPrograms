using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayLogical
{
    public class DuplicateElements
    {
        public static void Count()
        {
           // int originalCount = 0;
            int count = 0;
            int[] array = { 1, 2, 2, 3, 4, 4, 5, 5 };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++; 
                        //Console.WriteLine(array[j]);
                     
                    }
                   
                }
               
            }Console.WriteLine(count);
           
        }
    }
}
