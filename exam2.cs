using System;

namespace xyz
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x, y, krn;
            Console.Write("Input a number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Input b number: ");
            b = int.Parse(Console.ReadLine());
            x = a;
            y = b;

            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            krn = (x * y) / a;
            Console.Write("krn: " + krn);
            Console.Read();
        }
    }
}
