﻿using System;
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
            Console.ReadLine();

        }
    }
}