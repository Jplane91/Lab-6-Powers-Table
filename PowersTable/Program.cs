using System;

namespace Loops
{
    class Program
    {
   
    static void Main(string[] args)
            
        {
            int result = ValidateIntergers("Interger");
            int result1 = PowersTable(result);
            AskToContinue();
            
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine("Enter in an interger");
            message = Console.ReadLine();
            return message;
;            
        }


        public static int ValidateIntergers(string message)
        {
            string input = GetUserInput(message);
            int number;
            if (int.TryParse(input, out number))
            {
                return number;
            }

            else
            {
                return ValidateIntergers("Please input a correct number!");
            }

        }

        public static int PowersTable(int num1)
        {
            int squared = 0;
            int cubed = 0;
            Console.WriteLine("\nNumber \t        Squared         Cubed");
            Console.WriteLine("======          =======         =====");
          

            Console.WriteLine();

            for (int i = 1; i <= num1; i++)
            {
                squared = i * i;
                cubed = i * i * i;
                Console.WriteLine(i + "\t\t" + squared + "\t\t" + cubed);

            }

            return squared;
            
        }

        static void AskToContinue()
        {
            Console.WriteLine("Would you like to enter in another number?(yes or no)");
            string userResponse = Console.ReadLine().ToLower();

          

                if (userResponse == "yes" || userResponse == "y")
                {
                    int result = ValidateIntergers("Enter in an interger");
                    int result1 = PowersTable(result);
                    AskToContinue();
                }

                else if (userResponse == "no" || userResponse == "n")
                {
                    Console.WriteLine("Have a good day");
                    System.Environment.Exit(1);
            }

                else
                {
                    Console.WriteLine("That wasn't a valid option, please enter again");
                    AskToContinue();
                }


            System.Environment.Exit(1);
        }
    }
}
