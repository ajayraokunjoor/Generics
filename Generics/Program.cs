using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Utilities
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }
        public T Max<T>(T a, T b) where T : IComparable
        {
            
            return a.CompareTo(b) > 0 ? a : b;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
#if badcode
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
 
            //Length
            Console.WriteLine("Length of Array is: "+ numbers.Length);

            //IndexOf
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9 is: " + index);

            //Clear


            var book = new Book { Isbn = "1111", Title = "C# Basic" };
            var book1 = new Book { Isbn = "2222", Title = "C# Intermediate" };
            var book2 = new Book { Isbn = "3333", Title = "C# Advanced" };


            var number = new Custom_List();
            number.Add(10);

            foreach (var item in numbers)
            {
                number.Add(item);
            }

            foreach (var item in number)
            {
                Console.WriteLine(item);
            }

            var books = new BookList();
            books.Add(book);
            books.Add(book1);
            books.Add(book2);

            for (int i = 0; i <3; i++)
            {
                Console.WriteLine(books[i].Title);
            }

            var number1 = new GenericList<int>();
            foreach (var item in numbers)
            {
                number1.Add(item);
            }
            number1.Add(10);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(number1[i]);
            }

            var books1 = new GenericList<Book>();
            books1.Add(book);
            books1.Add(book1);
            books1.Add(book2);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(books1[i].Title);
            }

#endif


        }
    }
}
