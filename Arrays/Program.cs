using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
#if code
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{ arr[i] = i} \t");
            }
            Console.WriteLine();

            int a = 0;
            for (int i = 0; i < 10; i++)
            {
                a += 10;
                arr[i] = a;
            }
            foreach (int i in arr)
            {
                Console.WriteLine(i + "\t" );
            }
#else
            //Declaring the array
            int[] arr = { 17, 23, 4, 59, 27, 36, 96, 9, 1, 3 };
            Console.WriteLine("The array contains below element");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            //Sorting an Array
            Array.Sort(arr);
            Console.WriteLine("The Array Elements After Sorting");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            //Reversing the Array
            Array.Reverse(arr);
            Console.WriteLine("The Array Elements After Reversing");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //Creating a New Array
            int[] brr = new int[10];

            //Copying some elements from old array to new array
            Console.WriteLine("The new array elements");
            Array.Copy(arr, brr, 5);
            //We declare the array with size 10. we copy only 5 elements. so the rest
            //5 elements will take the default value. In this array, it will take 0
            foreach (int i in brr)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();

#endif


        }
    }
}
