using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample obj = new Sample();
            int sumResult = obj.Sum(4, 5);
            Console.WriteLine("Sum result is :");
            Console.WriteLine(sumResult);          
            Console.WriteLine(Class4.Add(4, 5));

            Console.WriteLine("Write some and try pushing from git");
            Console.Read();




        }
    }

    public class Sample
    {

        public int Sum(int a,int b)
        {
            int result = a + b;
            return result;
        }

        public int Sum(int a,int b,int c)
        {
            int result = a + b + c;
            return result;
        }

    }


}
