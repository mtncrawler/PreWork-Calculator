using System;

namespace calculator
{
    class Program
    {
        //prompt user to input two numbers then display the sum, difference, product and quotient
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the My Simple Calculator!");
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{num1} + {num2} = {Add(num1, num2)}");
            Console.WriteLine($"{num1} - {num2} = {Subtract(num1, num2)}");
            Console.WriteLine($"{num1} * {num2} = {Multiply(num1, num2)}");
            Console.WriteLine($"{num1} / {num2} = {Divide(num1, num2)}");
        }

        //add two numbers 
        static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        //subtract two numbers
        static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        //multiple two numbers
        static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        //divide two numbers
        static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}