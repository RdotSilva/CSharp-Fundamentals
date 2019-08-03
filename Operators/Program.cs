using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;

			// 3 * 3
            Console.WriteLine((a + b)* c);
			
			// False
			Console.WriteLine(!(c > b || c == a));
        }
    }
}
