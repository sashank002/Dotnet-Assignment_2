// See https://aka.ms/new-console-template for more information


using System;

namespace Program 
{
    class MainClass 
    {
        public static void Main(string[] args)
        {
            NumberExample.IntExample();
            NumberExample.DoubleExample();
            NumberExample.DecimalExample();
            NumberExample.FormulaExample();
        }
    }

    static class NumberExample
    {
        public static void IntExample()
        {
            Console.WriteLine("__________________________________________");
            Console.WriteLine("hello integer");
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine("Math Operations : : :");
            Console.WriteLine("a+b = " + c);
            c = a-b;
            Console.WriteLine("a-b = " + c);
            c = a*b;
            Console.WriteLine("a*b = " + c);
            c = a/b;
            Console.WriteLine("a/b = " + c);

            Console.WriteLine("ORDER OF OPERATIONS : :");
            a = 5;
            b = 4;
            c = 2;
            int d = a+b*c;
            Console.WriteLine("a + b * c = " + d);
            Console.WriteLine("(a + b) * c = " + (a+b)*c);
            Console.WriteLine("(a + b) - 6 * c + (12 * 4) / 3 + 12 = " + ((a + b) - 6 * c + (12 * 4) / 3 + 12));
            Console.WriteLine("(a + b) / c = " + (a+b)/c);

            Console.WriteLine("INTEGER PRECISION & LIMITS : :");
            a = 7;
            b = 4;
            c = 3;
            d = (a+b) / c;
            int e = (a+b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is (min : ) {min} to (max : ) {max}");
            int what = max + 3;
            Console.WriteLine($"An example of overflow (max + 3) : {what}");


        }

        public static void DoubleExample() 
        {
            Console.WriteLine("__________________________________________");
            Console.WriteLine("Double Type Example : :");
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine($"(a + b) / c {d}");

            Console.WriteLine("MORE COMPLICATED EXAMPLE OF DOUBLE : :");
            a = 19;
            b = 23;
            c = 8;
            d = (a+b)/c;
            Console.WriteLine($"(a + b) / c {d}");

            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");

            double third = 1.0 / 3.0;
            Console.WriteLine($"Rounding error : {third}");

        }

        public static void DecimalExample()
        {
            Console.WriteLine("__________________________________________");
            Console.WriteLine("DECIMAL EXAMPLE : : ");
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine( "IN DECIMAL (c / d) = " + (c / d));
        }

        public static void FormulaExample()
        {
            Console.WriteLine("__________________________________________");
            Console.WriteLine("FINDING AREA USING Math.PI : : ");
            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine("AREA : " + area);
        }
    }
}
