using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 2;
            Math m = new Math();
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("Add(a,b) = {0}", m.add(a, b));
            Console.WriteLine("Subtract(a,b) = {0}", m.subtract(a, b));
            Console.WriteLine("Multiply(a,b) = {0}", m.multiply(a, b));
            Console.WriteLine("Divide(a,b) = {0}", m.divide(a, b));
        }
    }
    class Math
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int subtract(int a, int b)
        {
            return a - b;
        }
        public int multiply(int a, int b)
        {
            return a * b;
        }
        public int divide(int a, int b)
        {
            return a / b;
        }
    }
}
