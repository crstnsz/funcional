using System.Collections.Generic;
using System;
using System.Collections;

namespace Funcionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Tamanho("Hello World!".GetEnumerator()));
            Console.WriteLine(Somatorio(new int[] {10, 20, 30}.GetEnumerator()));
        }

        static int Tamanho(IEnumerator x)
            => x.MoveNext()?Tamanho(x) + 1:0;

        static int Somatorio(IEnumerator x)
            => x.MoveNext()?Somatorio(x) + (int)x.Current: (int)x.Current;
    }
}
