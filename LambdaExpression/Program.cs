// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Square(5));
        }
        static int Square(int number)
        {
            return number * number;
        }
    }
}


/*
 
 A lambda expression is nothing but an anonymous method.

That is a method that has no access modifier, like public or private, and has no name, and it has no return statement.

Why do we use them? Why do we use anonymous methods? For convenience. We can write less code and achieve the same thing, plus our code would be more readable.

Let's say, we would like to write a method that takes a number and returns a square of that number.


 An anonymous method
No access modifier
No name
no return satement 
 */
