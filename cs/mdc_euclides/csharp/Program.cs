using System;
using static System.Console;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(ReadLine());
            int b = Convert.ToInt32(ReadLine());

            WriteLine(MdcComp(a, b));
        }

        static int MdcComp(int a, int b)
            => a == b?a:(a > b?MdcComp(a - b, b):MdcComp(b - a, a));

        static int MdcExp(int a, int b)
        {
            if (a == b)
                return a;

            if (a < b)
                return MdcExp(a - b, b);
            else
                return MdcExp(b - a, a);
        }
    }
}
