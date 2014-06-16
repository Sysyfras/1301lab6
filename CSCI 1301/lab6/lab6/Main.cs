using System;

class Program
{
    public static void Main(string[] args)
    {
        int num1, num2, quotient;

        char repeat = 'y';

        while (repeat == 'y')
        {
            // get the first number
            Console.WriteLine("Enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            // get the first number
            Console.WriteLine("Enter another number: ");
            num2 = Convert.ToInt32(Console.ReadLine());


            // num2 is not zero, perform the division            
            if (num2 == 0)
            {
                Console.WriteLine("Division by zero is not possible ");
                Console.WriteLine("You have to enter number other than zero ");
            }
            else
            {
                quotient = num1 / num2;
                Console.WriteLine("The quotient of {0} divided by {1} is {2}", num1, num2, quotient);
            }

            Console.WriteLine("Do you wish to continue? (y for yes): ");

            repeat = Convert.ToChar(Console.ReadLine());
        }

        Console.WriteLine("Good bye! ");
        Console.ReadLine(); //pause
    }
}