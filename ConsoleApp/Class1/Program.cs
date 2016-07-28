using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test obj = new Test();
            int result = obj.Multiply(4, 5, 6);
           // Console.Read();
            Console.WriteLine("Total: " + result);
            Console.Read();
            Console.Read();
        }
    }
    public class Test
    {
        public int Multiply (int A, int B)
        {
            int total = A * B;
            return total;
        }
        public int Multiply (int A,int B, int C)
        {
            int total = A * B * C;
            return total;
        }
    }
}
