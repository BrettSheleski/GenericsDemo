using System;

namespace ListOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Allow the user to keep entering as many integers as they want
            // what happens when the user enters more than NUMBER_OF_VALUES ??

            IntegerList integerList = new IntegerList();
            string userEnteredString;
            int userEnteredValue;
            bool getFromUser = true;

            while (getFromUser)
            {
                while (true)
                {
                    Console.WriteLine($"Enter an integer ({integerList.Count + 1}, blank to stop)");

                    userEnteredString = Console.ReadLine();

                    if (userEnteredString != null && int.TryParse(userEnteredString, out userEnteredValue))
                    {
                        integerList.Add(userEnteredValue);
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
            for (int i = 0; i < integerList.Count; ++i)
            {
                sum += integerList[i];

                Console.Write($"{integerList[i]} ");
            }


            Console.WriteLine();

            double average = sum / (double)integerList.Count;

            Console.WriteLine($"Average: {average}");
        }
    }
}
