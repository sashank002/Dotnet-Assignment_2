// See https://aka.ms/new-console-template for more information



using System;

namespace Program 
{
    class MainClass 
    {
        public static void Main(string[] args)
        {
        //    BranchLoopClass.IfExample();
            // BranchLoopClass.LoopExample();
            BranchLoopClass.FinalExample();
        }
    }

    static class BranchLoopClass
    {
        public static void IfExample()
        {
            Console.WriteLine("__________________________________________");
            Console.WriteLine(" IF STATEMENT EXAMPLE  : : ");
            int a = 5;
            int b = 6;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10.");


            Console.WriteLine("__________________________________________");
            Console.WriteLine(" IF-ELSE STATEMENT EXAMPLE  : : ");
             a = 5;
             b = 3;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10");
            else
                Console.WriteLine("The answer is not greater than 10");

            Console.WriteLine("__________________________________________");
            Console.WriteLine(" IF-ELSE STATEMENT COMPLICATED EXAMPLE  : : ");
            a = 5;
            b = 3;
            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }

        }

        public static void LoopExample() 
        {
            Console.WriteLine("__________________________________________");
            Console.WriteLine(" WHILE - LOOP EXAMPLE  : : ");

            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }

            Console.WriteLine("__________________________________________");
            Console.WriteLine(" DO-WHILE - LOOP EXAMPLE  : : ");
            counter = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 10);


            Console.WriteLine("__________________________________________");
            Console.WriteLine(" FOR - LOOP EXAMPLE  : : ");

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Hello World! The counter is {i}");
            }

            Console.WriteLine("__________________________________________");
            Console.WriteLine(" NESTED - FOR - LOOP EXAMPLE  : : ");

            Console.WriteLine("ROW,COLUMN EXAMPLE : ");
            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }
        }

        public static void FinalExample()
        {
            Console.WriteLine("__________________________________________");
            Console.WriteLine(" FINAL EXAMPLE  : : ");

            int sum = 0;
            for (int number = 1; number < 21; number++)
            {
                if (number % 3 == 0)
                {
                    sum = sum + number;
                }
            }
            Console.WriteLine($"The sum is {sum}");

        }
    }

 
}

