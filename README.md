# C# Generics
This is a simple repo to demonstrate what Generics is in C# and an example of why one would use Generics.

## What is Generics?

Generics is a way of writing type-safe code in C# to handle support for writing methods or classes that support potentially limitless types.

One could read Microsoft's documentation regarding Generics [here](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/types/generics) however I think it is best to use an example. 

## Example Console Application
Let's implement a simple console application that collects integer values from the user. Once done the program will display the numbers entered as well as the average.

## Using an array

Let's start by using a simple integer array for storing the values.

The program will collect 5 values from the user and add the value entered to the array.

Once done the program iterates through the array displaying the integers back to the user as well as keeping a running total to display the average.

Since arrays are fixed size the array will _always_ store 5 values, no more, no less.

### Pros
#### Simple
It doesn't get much easier to read, write, and understand.

### Cons
#### fixed size
Since arrays are fixed size the consider how we could handle some of the following cases:
 - want to store more values.
   - 10 values
   - 100 values
   - 1000 values
 - want to store an unknown number of values.
   - allow the user to stop entering values once they decide to stop

In the case of storing more values it could be as simple as just changing the `NUMBER_OT_VALUES` constant and recompiling. This kind of sucks though as for such a trivial change it would require a recompile. For this simple app it's not such a big deal, but in the case of a production application then we would not only have to recompile, but also re-distrubute to the users. Again, all of this just to allow the user to enter more values.

One simple solution would be to prompt the user how many numbers they want to enter and , however this wouldn't be the best user experience. 

