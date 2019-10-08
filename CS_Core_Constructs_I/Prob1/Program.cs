/*
Author: George Ledbury
Date:   Oct 8, 2019
CTEC 135: Microsoft Software Development with C#

<Solution Name>

<Problem description from README.md file. Make sure the comment text is 
reformatted to fit 1-80 column display, with appropriate indentations to 
make it readable>

Example:
Prob 1: Prob 1: Variables and Printing

* region 1: variable declarations

    page 18 in Troelsen shows two different ways to declare int variables. 
    page 71 shows a third way using the "new" keyword.

    In this section declare three different double variables using each of 
    the three type declarations.
...

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            System.Int32 c, d;
            int e, f = new int();

            a = 79;
            b = 128;
            c = 992;
            d = 7635;
            e = c - a;
            f = a + b + c + d;

            Console.WriteLine("a = {0}, b = {1}, c = {2}, d = {3:n}, e = {4:n}, f = {5:n}", a, b, c, d, e, f);
            
            Console.WriteLine("The min value of an Int32 is -2,147,483,648. It is constant meaning a user cannot change this value.");
            Console.WriteLine("The max value of an Int32 is 2,147,483,647. It is constant meaning a user cannot change this value.");
        }
    }
}
