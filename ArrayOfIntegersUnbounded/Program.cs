using System;

namespace ArrayOfIntegersUnbounded
{
    class Program
    {
        const int NUMBER_OF_VALUES = 5;

        static void Main(string[] args)
        {
            // Allow the user to keep entering as many integers as they want
            // what happens when the user enters more than NUMBER_OF_VALUES ??

            int[] values = new int[NUMBER_OF_VALUES];
            int count = 0;
            string userEnteredString;
            int userEnteredValue;
            bool getFromUser = true;

            while(getFromUser)
            {
                while (true)
                {
                    Console.WriteLine($"Enter an integer ({count + 1}, blank to stop)");

                    userEnteredString = Console.ReadLine();

                    if (userEnteredString != null && int.TryParse(userEnteredString, out userEnteredValue))
                    {
                        values[count] = userEnteredValue;
                        ++count;
                        break;
                    }
                    else if (string.IsNullOrWhiteSpace(userEnteredString))
                    {
                        getFromUser = false;
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
            for (int i = 0; i < count; ++i)
            {
                sum += values[i];

                Console.Write($"{values[i]} ");
            }


            Console.WriteLine();

            double average = sum / (double)count;

            Console.WriteLine($"Average: {average}");
        }
    }
}
