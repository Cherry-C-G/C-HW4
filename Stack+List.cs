using System;
using System.Collections.Generic;

public class MyStack<T>
{
    public static void Main()
    {
        //Create a custom Stack class MyStack<T> that can be used with any data type which has following methods
        // 1. int Count()
        //2.T Pop()
        //3.Void Push()

        Stack<int> numbers = new Stack<int>();
        numbers.Push(1);
        numbers.Push(2);
        numbers.Push(3);
        numbers.Push(4);
        numbers.Push(5);


        // A stack can be enumerated without disturbing its contents.
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nPopping '{0}'", numbers.Pop());
        Console.WriteLine("Peek at next item to destack: {0}",
            numbers.Peek());
        Console.WriteLine("Popping '{0}'", numbers.Pop());
        Console.WriteLine("Count '{0}'", numbers.Count());



        // A stack can be enumerated without disturbing its contents.
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }


        List<int> MyList = new List<int>(numbers.ToArray());
        MyList.Add(1);
        MyList.Add(2);
        MyList.Add(3);
        MyList.Add(4);
        MyList.Add(5);

        Console.WriteLine("\nAdding list:");
        foreach (int number in MyList)
        {
            Console.WriteLine(number);
        }
        //remove
        MyList.Remove(1);
        MyList.Remove(2);
        MyList.Remove(3);

        Console.WriteLine("\nRemoving list:");
        foreach (int number in MyList)
        {
            Console.WriteLine(number);
        }

        //InsertAt
        MyList.Insert(1, 11);
        MyList.Insert(2, 22);
        MyList.Insert(3, 33);


        Console.WriteLine("\nInserting list:");
        foreach (int number in MyList)
        {
            Console.WriteLine(number);



            // Create an array twice the size of the stack and copy the
            // elements of the stack, starting at the middle of the
            // array.
            int[] array2 = new int[numbers.Count * 2];


            // Create a second stack, using the constructor that accepts an
            // IEnumerable(Of T).
            List<int> list = new List<int>(array2);

            Console.WriteLine("\nMyList.Contains(\"four\") = {0}",
                MyList.Contains(4));

            Console.WriteLine("\nMyList.Clear()");
            MyList.Clear();
            Console.WriteLine("\nMyList.Count = {0}", MyList.Count);
        }


    }
}

