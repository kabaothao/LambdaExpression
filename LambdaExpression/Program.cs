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


            //() =>...
            // x=>...
            // (x, y, z) =>...

            //const int factor = 5;


            //Func<int, int> multipler = n => n * factor;

            //var result = multipler(10);

            //Console.WriteLine(result);


            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(b => b.Price < 10); //We read this expression like this, book goes to book.Price is less than $10.

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
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
