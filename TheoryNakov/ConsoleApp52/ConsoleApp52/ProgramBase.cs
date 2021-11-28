using System;

namespace ConsoleApp52
{
    internal class ProgramBase
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine(Max(a, b, c, d));
        }
        public static int Max(int a, int b, int c, int d)
        {
            //1.случай: a<b или b<a
            if (a < b)
            {
                //a<b
                if (b < c)
                {
                    //a<b<c
                    if (c < d)
                    {
                        //a<b<c<d
                        return d;
                    }
                    else
                    {
                        //a<b<c и d<c
                        return c;
                    }
                }
                else
                {
                    //a,c<b
                    if (b < d)
                    {
                        //a,c<b<d 
                        return d;
                    }
                    else
                    {
                        //a,c<b и d<b
                        return b;
                    }
                }
            }
            else
            {
                //b<a
                if (a < c)
                {
                    //b<a<c
                    if (c < d)
                    {
                        //b<a<c<d
                        return d;
                    }
                    else
                    {
                        //b<a<c и d<c
                        return c;
                    }
                }
            }
            //2.случай: a<c или c<a
            if (a < c)
            {
                //a<c
                if (c < b)
                {
                    //a<c<b
                    if (b < d)
                    {
                        //a<c<b<d
                        return d;
                    }
                    else
                    {
                        //a<c<b и d<b
                        return b;
                    }
                }
                else
                {
                    //a,b<c
                    if (c < d)
                    {
                        //a,b<c<d
                        return d;
                    }
                    else
                    {
                        //a,b<c и d<c
                        return c;
                    }
                }
            }
            else
            {
                //c<a
                if (a < b)
                {
                    //c<a<b
                    if (b < d)
                    {
                        //c<a<b<d
                        return d;
                    }
                    else
                    {
                        //c<a<b и d<b
                        return b;
                    }
                }
                else
                {
                    //c,b<a
                    if (a < d)
                    {
                        //c,b<a<d
                        return d;
                    }
                    else
                    {
                        //c,b<a и d<a
                        return a;
                    }
                }
            }

        }
    }
}