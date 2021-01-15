using System;

namespace My_First_Plan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Steps for withdrawing money out of an ATM\n");
            Console.WriteLine("Please press enter to start the program...\n");
            Console.Read();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Step 1");
            Console.WriteLine("Insert debit card into card slot.\n");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Step 2");
            Console.WriteLine("Input security access code or pin.\n");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Step 3");
            Console.WriteLine("Select withdraw money.\n");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Step 4");
            Console.WriteLine("Select account.\n");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Step 5");
            Console.WriteLine("Input amount you wish to withdraw.\n");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Step 6");
            Console.WriteLine("Confirm your transaction.\n");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Step 7");
            Console.WriteLine("Take your money out.\n");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Step 8");
            Console.WriteLine("Exit ATM.\n");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Step 9");
            Console.WriteLine("Take your card out.\n");
            Console.ReadLine();

            string myName = "Carlos Marquez";
            Console.WriteLine($"This program was created by:\t{myName}");

        }
    }
}
