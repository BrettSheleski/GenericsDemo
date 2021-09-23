using System;

namespace ListOfDoubles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Allow the user to keep entering as many integers as they want
            // what happens when the user enters more than NUMBER_OF_VALUES ??

            DoubleList doubleList = new DoubleList();
            string userEnteredString;
            double userEnteredValue;
            bool getFromUser = true;

            while (getFromUser)
            {
                while (true)
                {
                    Console.WriteLine($"Enter a number ({doubleList.Count + 1}, blank to stop)");

                    userEnteredString = Console.ReadLine();

                    if (userEnteredString != null && double.TryParse(userEnteredString, out userEnteredValue))
                    {
                        doubleList.Add(userEnteredValue);
                        break;
                    }
                    else if (string.IsNullOrWhiteSpace(userEnteredString))
                    {
                        getFromUser = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You did not enter a valid number, try again.");
                        continue;
                    }
                }
            }

            Console.Write("Values entered: ");

            double sum = 0;
            for (int i = 0; i < doubleList.Count; ++i)
            {
                sum += doubleList[i];

                Console.Write($"{doubleList[i]} ");
            }


            Console.WriteLine();

            double average = sum / (double)doubleList.Count;

            Console.WriteLine($"Average: {average}");
        }
    }
}
