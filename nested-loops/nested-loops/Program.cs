using System;

namespace nested_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yo Josie, check out your gardens!");
            Console.WriteLine("Catnip = x, Mint = o");
            Console.WriteLine();

            string exes = "x ";
            string ohs = "o ";
            Checkers(exes, ohs);
            Console.WriteLine();
            Console.WriteLine("Carrots = x, Tomatos = o");
            Rows(exes, ohs);

            Console.Read();
        }

        static void Checkers(string x, string o)
        {
            int z = 0;
            for (int ii = 0; ii < 5; ii++)
            {
                z++;
                for (int jj = 0; jj < 5; jj++)
                {
                    if ((jj + z) % 2 == 0)
                    {
                        Console.Write(x);
                    }
                    else
                    {
                        Console.Write(o);
                    }
                }
                Console.WriteLine();
            }
        }
        static void Rows(string x, string o)
        {
            for (int ii = 0; ii < 5; ii++)
            {
                for (int jj = 0; jj < 5; jj++)
                {
                    if (ii % 2 == 0)
                    {
                        Console.Write(x);
                    }
                    else
                    {
                        Console.Write(o);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
