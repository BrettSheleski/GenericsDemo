# C# Generics
This is a simple repo to demonstrate what Generics is in C# and an example of why one would use Generics.

## What is Generics?

Generics is a way of writing type-safe code in C# to handle support for writing methods or classes that support potentially limitless types.

One could read Microsoft's documentation regarding Generics [here](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/types/generics) however I think it is best to use an example. 

## Example Console Application
Let's implement a simple console application that collects integer values from the user. Once done the program will display the numbers entered as well as the average.

## Using an array

Let's start by using a simple integer array for storing the values.

The program will collect up to 5 values from the user, ensure the user entered an integer value, and add the value entered to the array.

Once done the program iterates through the array displaying the integers back to the user as well as keeping a running total to display the average.

Since arrays are fixed size we can only store a fixed number of values in the array. We also need a separate variable to hold on to number of numbers entered so far.


### Pro's
- simple
- easy to understand
- type safe

### Con's
- fixed size
  - need separate variable to track number of values entered.
  - cannot enter more values than what the size limit of the array is.
