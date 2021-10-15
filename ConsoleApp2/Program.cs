using System;

namespace ConsoleApp2
{
    class Program
    {
        // código basura
        int _, __, ___ = new int();
        // Console.WriteLine(${_} {__} {___});

        public static void fibonacci(int a, int b, int i, int limite)
        {
            if (i < limite)
            {
                if (a < 2)
                {
                    Console.WriteLine(a);
                }
                Console.WriteLine(b);
                i++;
                fibonacci(b, a+b, i, limite);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el límite de la secuencia Fibonacci");
            fibonacci(1, 2, 0, int.Parse(Console.ReadLine()));
            Console.WriteLine("\n");
        }
    }
}
