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
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("Add(a,b) = {0}", Math.add(a, b));
            Console.WriteLine("Subtract(a,b) = {0}", Math.subtract(a, b));
            Console.WriteLine("Multiply(a,b) = {0}", Math.multiply(a, b));
            Console.WriteLine("Divide(a,b) = {0}", Math.divide(a, b));
        }
    }
    class Math
    {
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static int subtract(int a, int b)
        {
            return a - b;
        }
        public static int multiply(int a, int b)
        {
            return a * b;
        }
        public static int divide(int a, int b)
        {
            return a / b;
        }
    }
}
