namespace Conditionals_Hunt_Shayla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asks the user to enter a whole number and assigns to integer variable
            Console.WriteLine("Enter a whole number, please!");
            int WholeNum = Convert.ToInt32(Console.ReadLine());

            //Checks if the number is positive or negative
            if (WholeNum >= 0)
            {
                Console.WriteLine($"{WholeNum} is a positive number!");
            }
            else
            { 
                Console.WriteLine($"{WholeNum} is a negative number!"); 
            }

            //Checks if the number is even or odd
            if (WholeNum % 2 == 0)
            {
                Console.WriteLine($"{WholeNum} is a even number!");
            }
            else
            {
                Console.WriteLine($"{WholeNum} is a odd number!");
            }

            // Creates two more integer numbers
            int num1 = 7;
            int num2 = 43;

           
            int firstMax = Math.Max(WholeNum, num1); // Gets first max
            int max = Math.Max(firstMax, num2); // Gets maxium number

            Console.WriteLine($"The maxium number between {WholeNum}, {num1}, and {num2} is {max}!"); // Prints max to console

            // Asks the user to enter a grade and assigns to a char variable
            Console.WriteLine("Enter a grade (A, B, C, D, F)!");
            char grade = Console.ReadKey().KeyChar;

            // Prints description based on grade value
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("\nSuperior");
                    break;
                case 'B':
                    Console.WriteLine("\nVery Good");
                    break;
                case 'C':
                    Console.WriteLine("\nAverage");
                    break;
                case 'D':
                    Console.WriteLine("\nBelow Average");
                    break;
                case 'F':
                    Console.WriteLine("\nFail");
                    break;
                default:
                    Console.WriteLine("\nYou did not enter a valid grade!");
                    break;
            }
        }
    }
}
