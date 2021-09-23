using System;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<double> myList = new MyList<double>();
            string userEnteredString;
            double userEnteredValue;
            bool getFromUser = true;

            while (getFromUser)
            {
                while (true)
                {
                    Console.WriteLine($"Enter a number ({myList.Count + 1}, blank to stop)");

                    userEnteredString = Console.ReadLine();

                    if (userEnteredString != null && double.TryParse(userEnteredString, out userEnteredValue))
                    {
                        myList.Add(userEnteredValue);
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
            for (int i = 0; i < myList.Count; ++i)
            {
                sum += myList[i];

                Console.Write($"{myList[i]} ");
            }


            Console.WriteLine();

            double average = sum / (double)myList.Count;

            Console.WriteLine($"Average: {average}");
        }
    }
}
