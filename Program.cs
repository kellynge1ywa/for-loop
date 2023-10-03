﻿namespace For_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
               
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }




        }

       
    }
}