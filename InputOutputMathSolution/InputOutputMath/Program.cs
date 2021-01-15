using System;

namespace InputOutputMath
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Implement a temperature converter from
             * Calcius to Farenheit
             * 
             * January 2021
             */

            // input: celcius temperature
            //          string inputTemp
            //          double theCelciusTemperature

            // output: Farenheith temperature
            //          double theFarenheitTemperature

            // expression (calculation): (ct * (9.0/5.0)) +32
            // check with ct = 0 expect ft = 32
            // check with ct = 100 expect ft = 212
            // check with ct = -40 expect ft = -40

            // prompt for a celcius temperature
            // .Write() keeps your cursor on the same line
            Console.Write("Enter a Celcius temperature: ");

            // How does the program pull in the entry from thr user
            // to obtain the key strokes that the user types (input)
            // .ReadLine()
            // IMPORTANT
            // data comes into the program as a string
            // DOES NOT matte if you enter a number, it is treated as
            // a string

            // declare the variable:        datatype variablename;
            string inputTemp;
            // assignment statement:        expression on the right is placed
            //                              into the variable on the left
            // expression (action):         read the user input
            inputTemp = Console.ReadLine();

            //// you could do both statement on one line
            //string intputTemp = Console.WriteLine();

            // currently the celcius value is a string
            // the value needs to be converted to a number
            // to be used in a math calculation
            // convert data to a different datatype
            // to do this; you will use a technique called parsing
            // syntax:  datatypeTo.Parse(string value)

            // WARNING i am assuming the user will enter valid data
            //         if the user does not enter a number this program will
            //         will abort on the execution of this line
            double theCelciusTemperature = double.Parse(inputTemp);

            // calculation using the conversion expression
            double theFarenheitTemperature =
                (theCelciusTemperature * (9.0 / 5.0)) + 32;

            // output
            // .WriteLine() which automatically goes to the next line
            Console.WriteLine($"The Celcius temperature of {theCelciusTemperature} is {theFarenheitTemperature} degrees in Farenheit");
        }
    }
}
