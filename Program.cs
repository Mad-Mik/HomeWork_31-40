using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 106;
            int b = 29;
            int c = 66;
            int d = 11;



            int[] numbers = { a, b, c, d };

            //31
            Console.WriteLine(numbers.Max());

            //32
            Console.WriteLine(numbers.Min());

            //33
            Console.WriteLine(numbers.Contains(1));

            //34
            if (a + b == c + d)
            {
                Console.WriteLine(true);
            }
            else if (b + c == d + a)
            {
                Console.WriteLine(true);
            }
            else if (c + a == b + d)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            //35
            if (a == b + c + d || b == a + c + d || c == a + b + d || d == a + b + c)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            //36
            int resault = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    resault++;
                }

            }

            if (resault > 3) Console.WriteLine(1);
            else Console.WriteLine(2);


            //37
            if (b - a == c - b && c - b == d - c)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            //38            
            if (b / a == c / b && c / b == d / c)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }


            //39
            Array.Sort(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            //40
            Array.Reverse(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
