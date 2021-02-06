using System;
using System.Collections;
using System.Text;

namespace BrailleDots.TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(DotPattern.Get("123"));
            Console.WriteLine(DotPattern.Get(new BitArray(new[] {true, true, true, false, false, false, false, false})));
            Console.WriteLine(DotPattern.Get(true, true, true, false, false, false, false, false));
        }
    }
}
