using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            for(int i=0; i<=5; i++)
            {
                Console.WriteLine(i);
            }
            int number = 2;
            if(number<5)
            {
                Console.WriteLine("{0} is less than 5", number);
            }
            Console.WriteLine("This statement is always executed");

            Program program = new Program();
            program.Print();
            string x = Console.ReadLine();
            Console.WriteLine(x);
            Console.WriteLine("Hi");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello  { name}!");

            int a = -5;
            int b = a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            b = 10;
            Console.WriteLine(a);
            Console.WriteLine(b);

            int[] p = { -5 };
            int[] q = p;
            Console.WriteLine(p[0]);
            Console.WriteLine(q[0]);

            Program program1 = new Program();
            program1.Test();

            Test1(q);
            Console.WriteLine(q[0]);

            int x1 = (int)29.99;
            Console.WriteLine(x1);
            float x2 = 3.2f;
            double x3 = 55.666666;
            decimal x4 = 5555.666M;
            double x5 = Math.Pow(9999, 99999999999999999);
            Console.WriteLine(decimal.Ceiling(x4));
            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.WriteLine(x4);
            Console.WriteLine(double.IsInfinity(x5));
            Console.ReadLine();


        }
        void Print()
        {
            int a = 8;
            int b = 9;
            int c;
            c = a + b;
            Console.WriteLine(c);
        }
        void Test()
        {
            int[] a1 = { -25 };
            int[] a2 = a1;
            a2[0] = 30;
            Console.WriteLine(a1[0]);
        }
        static void Test1(int[] a3)
        {
            a3[0] = 40;
        }
    }
}
