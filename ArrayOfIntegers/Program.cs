using System;

namespace ArrayOfIntegers
{
    class Program
    {
        const int NUMBER_OF_VALUES = 5;

        static void Main(string[] args)
        {
            int[] values = new int[NUMBER_OF_VALUES];
            int count = 0;
            string userEnteredString;
            int userEnteredValue;
            
            for (int i = 0; i < NUMBER_OF_VALUES; ++i)
            {
                while (true)
                {
                    Console.WriteLine($"Enter an integer ({count + 1} of 5)");

                    userEnteredString = Console.ReadLine();

                    if (userEnteredString != null && int.TryParse(userEnteredString, out userEnteredValue))
                    {
                        values[count] = userEnteredValue;
                        ++count;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You did not enter a valid integer, try again.");
                        continue;
                    }
                }
            }

            Console.Write("Values entered: ");

            int sum = 0;
            for(int i = 0; i < NUMBER_OF_VALUES; ++i)
            {
                sum += values[i];

                Console.Write($"{values[i]} ");
            }

            
            Console.WriteLine();

            double average = sum / (double)NUMBER_OF_VALUES;

            Console.WriteLine($"Average: {average}");
        }
    }
}
