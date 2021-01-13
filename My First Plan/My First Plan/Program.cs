using System;

namespace My_First_Plan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Steps for withdrawing money out of an ATM");
            Console.WriteLine();
            Console.WriteLine("Please press enter to start the program...");
            Console.Read();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Step 1");
            Console.WriteLine("Insert debit card into card slot.");
            Console.WriteLine();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Step 2");
            Console.WriteLine("Input security access code or pin.");
            Console.WriteLine();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Step 3");
            Console.WriteLine("Select withdraw money.");
            Console.WriteLine();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Step 4");
            Console.WriteLine("Select account.");
            Console.WriteLine();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Step 5");
            Console.WriteLine("Input amount you wish to withdraw.");
            Console.WriteLine();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Step 6");
            Console.WriteLine("Confirm your transaction.");
            Console.WriteLine();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Step 7");
            Console.WriteLine("Take your money out.");
            Console.WriteLine();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Step 8");
            Console.WriteLine("Exit ATM.");
            Console.WriteLine();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Step 9");
            Console.WriteLine("Take your card out.");
            Console.WriteLine();
            Console.ReadLine();

            string myName = "Carlos Marquez";
            Console.WriteLine($"This program was created by:\t{myName}");

        }
    }
}
