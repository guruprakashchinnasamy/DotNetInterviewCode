using System;
using System.Collections.Generic;

namespace ConsoleApp_Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            foreach (int v in hello(30))
            {
                Console.Write(v);
                Console.Write(" ");
            }
            static IEnumerable<int> hello(int Loops)
            {
                for (int i = 0; i < Loops; i++)
                {
                    yield return i;
                }

            }
        }
    }
}
