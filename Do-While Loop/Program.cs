﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Do_While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /* local variable definition */
            int a = 10;

            /* do loop execution */
            do
            {
                Console.WriteLine("value of a: {0}", a);
                a = a + 1;
            }
            while (a <= 20);
            Console.ReadLine();
        }
    }
}
