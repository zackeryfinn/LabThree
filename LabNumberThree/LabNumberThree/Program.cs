using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumberThree
{
    class Program
    {
        static void Main(string[] args)
   
         
        {
            //start the yes no repeat loop here
            while (true)
            { 


            //get your name
            Console.WriteLine("Hello, this is the computer speaking, welcome to my program.");
            Console.Write("May I start with your name please?  ");
            var name = Console.ReadLine();
            Console.WriteLine();
   
            //get number & validate
            Console.Write("Please enter a number between 1 and 100: ");
            string inputNumber = Console.ReadLine();
            var number = 0;
            while (!int.TryParse(inputNumber, out number) || number < 0 || number > 100)
            {
                Console.WriteLine("Sorry, that is not a valid input.");
                Console.Write("Please enter a nubmer between 1 and 100: ");
                inputNumber = Console.ReadLine();
            }

            //Let's be nice and repeat what was stated
            Console.WriteLine();
            Console.WriteLine($"Thank you {name}. Your number is: {number}.");


            //a series of if / else loops to get it all sorted
            //lets start with sorting odds from evens

            if (number % 2 == 0)
            {
                if (number <= 25)
                {
                    Console.WriteLine($"{name}, your number is even and less than 25.");
                }
                else
                {
                    if (number <= 60)
                    {
                        Console.WriteLine($"{ name}, your number is even and equal to or less than 60.");
                    }
                    else
                    {
                        Console.WriteLine($"{name}, your number is even and greater than 60.");
                    }
                }
            }
            else
            {
                if (number <= 25)
                {
                    Console.WriteLine($"{name}, your number is odd and less than or equal to 25.");
                }
                else
                {
                    if (number <= 60)
                    {
                        Console.WriteLine($"{ name}, your number is odd and less than 60.");
                    }
                    else
                    {
                        Console.WriteLine($"{name}, your number is odd and greater than 60.");
                    }
                }
            }
            Console.WriteLine();

            //section to go again
            //Section to go again
            Console.WriteLine();

            Console.Write("Would you like to try again ? If no press \"n\" to exit. -");
            if (Console.ReadLine().Equals("n", StringComparison.OrdinalIgnoreCase)) break;
            Console.Clear();



            }
            Console.WriteLine();
            Console.WriteLine("I hope you enjoyed my humble little progam.");
            Console.WriteLine("Thank you and have a great day!");
            Console.ReadKey();

        }


        }

   
    }

