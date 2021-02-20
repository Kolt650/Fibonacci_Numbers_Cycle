using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Numbers_Cycle
{

    class Test_Fib
    {
        static void Fibonacci(int max)
        {
            int first = 0;
            int second = 1;
            int f_n = 0;
            if (first == max)
                Console.WriteLine("Подавалось " + max + " Ожидается " + first+"\n");
            else if (second == max)
                Console.WriteLine("Подавалось " + max + " Ожидается " + second+"\n");
            else
            {
                while (f_n < max)
                {
                    f_n = first + second;
                    first = second;
                    second = f_n;
                    Console.WriteLine(f_n);
                }
                Console.WriteLine("\nПодавалось " + max + " ожидается " + f_n);
            }
        }

        //Подаётся 34, ожидается 34
        public void Do34_Return34() 
        {
            int max = 34;
            Fibonacci(max);
        }
        //Подаётся 0, ожидается 0
        public void Do0_Return0()
        {
            int max = 0;
            Fibonacci(max);
        }
        //Подаётся 1, ожидается 1
        public void Do1_Return1()
        {
            int max = 1;
            Fibonacci(max);
        }

    }
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Введите конечное число");
            //int max=Int32.Parse(Console.ReadLine());
            var TEST = new Test_Fib();
            TEST.Do0_Return0();
            TEST.Do1_Return1();
            TEST.Do34_Return34();
            Console.ReadKey();
        }

    }
}
