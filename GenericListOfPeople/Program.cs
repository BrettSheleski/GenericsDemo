using GenericList;
using System;

namespace GenericListOfPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demo using the same MyList class from GenericList
            // no need to define another type of list.

            MyList<Person> people = new MyList<Person>();
            bool getFromUser = true;
            string firstName, lastName;
            ConsoleKeyInfo key;

            while (getFromUser)
            {
                Console.WriteLine($"Person {people.Count + 1}:");

                firstName = null;

                while (string.IsNullOrWhiteSpace(firstName))
                {
                    Console.Write($"\tFirst Name: ");
                    firstName = Console.ReadLine();
                }


                lastName = null;

                while (string.IsNullOrWhiteSpace(lastName))
                {
                    Console.Write($"\tLast Name: ");
                    lastName = Console.ReadLine();
                }

                people.Add(new Person
                {
                    FirstName = firstName,
                    LastName = lastName
                });

                Console.WriteLine("Do you want to add another? [Y/n]");

                 key = Console.ReadKey();

                if (key.KeyChar != 'Y' && key.KeyChar != 'y' && key.Key != ConsoleKey.Enter)
                {
                    break;
                }
            }

            Console.WriteLine($"You entered {people.Count} people: ");

            for (int i = 0; i < people.Count; ++i)
            {
                Console.WriteLine($"\t{people[i].FirstName} {people[i].LastName}");
            }
        }
    }
}
