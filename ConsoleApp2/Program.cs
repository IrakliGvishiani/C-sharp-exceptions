using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //try
            //{
            //    throw new Exception("test");
            //}
            //catch (Exception)
            //{


            //}
            //finally
            //{
            //    Console.WriteLine("Hello, World!");
            //}

            //try
            //{
            //    int a = 10;

            //    int b = 0;

            //    Console.WriteLine(a / b);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //int age = int.Parse(Console.ReadLine());

            //if (age > 18)
            //{
            //        throw new Exception("Age greater than 18 is not allowed.");
            //}
            ////////////////////////////////////////////
            try
            {
                Console.WriteLine("enter first number");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("enter second number");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: " + ex.Message);
            }


            try
            {
                int num = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Input format is incorrect.");
            }
            /////////////////////////////////////////
            bool condition = true;

            while (condition == true)
            {

                try
                {
                    int num = int.Parse(Console.ReadLine());
                    condition = false;
                    Console.WriteLine("You entered: " + num);
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }



            }



            int[] numbers = [10, 20, 30, 40];
            int userGuess = int.Parse(Console.ReadLine());

            try

            {
                if (userGuess > numbers.Length)
                {
                    throw new IndexOutOfRangeException("Index out of range.");
                }

                //Console.WriteLine(numbers[i]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }


            int age = int.Parse(Console.ReadLine());

            try
            {
                if (age < 0)
                {
                    throw new Exception("Age cannot be negative.");
                   
                }
                else if (age < 18)
                {
                    throw new Exception("Age less than 18 is not allowed.");
                }
                else
                {
                    Console.WriteLine("Valid age entered: " + age);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }



            try
            {
                int user = int.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Program Ended.");
            }
        }
    }
}
