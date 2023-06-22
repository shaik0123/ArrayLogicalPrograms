using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayLogical
{
    public  class Matrix
    {
        public static void Sum()
        {
            int[,] Mat = {{ 1, 2, 3, }, {4, 5, 6 }, {7, 8, 9 }};
            for (int i = 0; i < 3; i++) {
                int r = 0;
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Mat[i, j]);
                    r = r + Mat[i, j];
                    Console.Write(" ");

                }
                Console.WriteLine(r);
                Console.WriteLine(" ");
            }
        }
    }
}
