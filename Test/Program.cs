﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Print();
            Check(10);
            PrintAlot();
            Foo.Bar foobar = new Foo.Bar();
            foobar.NestedPrint();
            I.Am.A.Burger burger = new I.Am.A.Burger();
            burger.Eat();
            FindMe();
            ReplaceMe();
            RemoveMe();
            Console.Read();
        }

        static void Print()
        {
            Console.WriteLine("Hello");
        }

        static void Check(int i)
        {
            Console.WriteLine(i > 0 ? "Error" : "Secret Key Here");
        }

        static void PrintAlot()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
        }

        static void FindMe()
        {
            Console.WriteLine("You");
            Console.WriteLine("Wont");
            Console.WriteLine("Find");
            Console.WriteLine("TheWord");
            Console.WriteLine("The");
            Console.WriteLine("Word");
        }

        static void ReplaceMe()
        {
            Console.WriteLine("I love dogs");
        }

        static void RemoveMe()
        {
            Console.WriteLine("The next sentence is a lie");
            Console.WriteLine("ion is best");
        }
    }
}
