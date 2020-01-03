using System;

namespace csdemo.Utils
{

    public class Fibonacci
    {
        public void printUntilIndex(int index)
        {
            int n1 = 0, n2 = 1, n3, i;
            Console.Write(n1 + " " + n2 + " ");
            for (i = 2; i < index; ++i)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }

        }

        public int calculate(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }

}