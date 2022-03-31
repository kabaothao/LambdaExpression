// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {

            // args => expression syntax for a lambda expression
            //if i rewrite this method it would look like:
            //we also need to assign a delegate.  delegate Is a pointer or reference by a method or a group of methods. Func and Action
            //number => number*number

            Func<int, int> squarre = number => number * number;

            
            Console.WriteLine(Square(5));
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
