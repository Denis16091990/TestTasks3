﻿using System;
using FooBar.MoreReal.Builder;

namespace FooBar.MoreReal.Cli
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello from more real FooBar implementation.");
            Console.WriteLine("***");
            Console.WriteLine();

            var fooBar = new FooBarBuilder().UseDefaults().Build();

            /* Classic way
            foreach (var message in fooBar.FooBars())
            {
                Console.WriteLine(message);
            }
            */

            // "Modern" way
            fooBar.ProcessEach(message => { Console.WriteLine(message); });


            Console.WriteLine();
            Console.WriteLine("***");
            Console.WriteLine("Work has finished. Have a nice day!");
            Console.WriteLine("Press any button to exit.");
            Console.ReadKey();
        }
    }
}