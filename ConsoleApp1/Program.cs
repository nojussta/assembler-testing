using System;

namespace ConsoleApp1
{
    internal class Program
    {
        //# a	DW  4  ;   10000; perpildymo situacijai
        //# b	DB 3
        //# c	DB 8
        //# x	DW -1,-2,-4,12,9,45,6

        //# ;
        //# ; suskaiciuoti     /   (a+2b)/(a-x)    , kai a-x > 0
        //# ;              y = |   a*a-3b            , kai a-x = 0
        //# ;                  \   |c+x|          , kai a-x < 0
        static void Main(string[] args)
        {
            int a = 4;
            int b = 3;
            int c = 8;
            int[] x = { -1, -2, -4, 12, 9, 45, 6 };

            for (int i = 0; i < x.Length; i++)
            {
                var strX = x[i];
                if ((a - x[i]) > 0)
                {
                    Console.WriteLine(string.Format($"x = {strX} | a-x > 0 | y = {(a + 2 * b) / (a - x[i])}"));
                }
                else if ((a - x[i]) == 0)
                {
                    Console.WriteLine(string.Format($"x = {strX} | a-x = 0 | y = {(a * a) - 3 * b}"));
                }
                else
                {
                    Console.WriteLine(string.Format($"x = {strX} | a-x < 0 | y = {Math.Abs(c + x[i])}"));
                }
            }

        }
    }
}

