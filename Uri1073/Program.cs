using System;

namespace Uri1073
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,raiz;

            raiz = 0;

            n = int.Parse(Console.ReadLine());

            for (int c = 1; c <= n; c++)
            {
                if (c%2==0)
                {
                    raiz = (int)Math.Pow(c, 2);
                    Console.WriteLine(c + "^2 = " + raiz);
                }
            }

        }
    }
}
