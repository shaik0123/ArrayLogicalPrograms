using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayLogical
{
    public class WordReverse
    {
        public static void Word(String str)
        {
            String[] array = str.Split(" ");
           // Console.WriteLine(array);
            for (int i = 0; i < array.Length; i++)
            {
                String str1 = array[i];
                for (int j = str1.Length-1; j >= 0; j--)
                {
                    Console.Write(str1[j]+" ");
                }
                Console.Write("  ");
            }
            Console.WriteLine(" ");

        }
    }
}
