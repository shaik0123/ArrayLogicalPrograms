using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayLogical
{
    public  class UniqueElements
    {
        public static void Unique()
        {
            int[] Elements = { 11, 12, 12, 13, 14, 14, 15 };
            for (int i = 0; i < Elements.Length; i++) 
            {
                for (int j = i+1;  j < Elements.Length; j++)
                {
                    if (Elements[j] == Elements[i])
                    { 
                       
                    }
                    
                    
                }
            }
        }
    }
}
