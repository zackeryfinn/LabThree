using System;

namespace LabNumberThreeVersion2
{
    class Program
    {
        static void Main(string[] args)
        {


            // I like that getting a name is in a seperate method! keeping your code seperated is a great thing.
            var name = GetYourName();
            while (true)
            {

                int number = GetYourNumber();

                Console.WriteLine();

                //Let's be nice and repeat what was stated
                Console.WriteLine();
                Console.WriteLine($"Thank you. Your number is: {number}.");

                CrunchYourNumber(name, number);

                Console.Write("Would you like to try again ? Press any key to continue or \"n\" to exit. -");
                if (Console.ReadLine().Equals("n", StringComparison.OrdinalIgnoreCase)) break;

                // James - I would start practicing on  reducing your white space to make your code more readable. 
            }

            Console.WriteLine();
            Console.WriteLine("I hope you enjoyed my humble little progam.");
            Console.WriteLine("Thank you and have a great day!");
            Console.ReadKey();

            // James - please reduce the amount of lines and spaces, makes it hard to read when all of this
            // whitespace is present. 

        }


        //get your name
        public static string GetYourName()
        {
            Console.WriteLine("Hello, this is the computer speaking, welcome to my program.");
            Console.Write("May I start with your name please?  ");
            var name = Console.ReadLine();
            Console.WriteLine();
            return name;
        }

        // James - Great use of seperateion of concerns again, I like that your validation is totally seperate.
        public static int GetYourNumber()
        {       //get number & validate
            Console.Write("Please enter a number between 1 and 100: ");
            string inputNumber = Console.ReadLine();
            var number = 0;
            while (!int.TryParse(inputNumber, out number) || number < 1 || number > 100)
            {
                Console.WriteLine("Sorry, that is not a valid input.");
                Console.Write("Please enter a nubmer between 1 and 100: ");
                inputNumber = Console.ReadLine();
            }
            return number;
        }

        // James - Again great use of  seperations, though as an extra challenge, I would try to reduce the amount 
        // of nested if statements! if you can somehow make all the if statements in the same scope or just use a 
        // switch case. 
        public static void CrunchYourNumber(string name, int number)
        {
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
                        Console.WriteLine($"{name}, your number is odd and less than 60.");
                    }
                    else
                    {
                        Console.WriteLine($"{name}, your number is odd and greater than 60.");
                    }
                }
            }
            Console.WriteLine();



        }
    }



    //  James - again, please try to reduce the amount of whitespace, it really does make it 
    // more difficult for other developers to read 


}
