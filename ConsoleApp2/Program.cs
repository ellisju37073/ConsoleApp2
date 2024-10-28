using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        #region Stack
        // Declare and initialize a stack with numbers 1 - 5
        Stack<int> stack = new Stack<int>(new int[] { 1, 2, 3, 4, 5 });

        // Print members in the stack using an enumerator (foreach loop)
        Console.WriteLine("Stack members:");
        foreach (int number in stack)
        {
            Console.WriteLine(number);
        }

        // Peek at the top member in the stack
        Console.WriteLine($"\nPeek at top member in stack: {stack.Peek()}");

        // Pop elements off of the stack and print each
        Console.WriteLine("\nPopping elements from stack:");
        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }
        #endregion

        #region Queue
        // Declare a queue
        Queue<int> queue = new Queue<int>();

        // Initialize the queue with numbers 1 - 5 using a for loop
        for (int i = 1; i <= 5; i++)
        {
            queue.Enqueue(i);
        }

        // Print members in the queue using an enumerator (foreach loop)
        Console.WriteLine("\nQueue members:");
        foreach (int number in queue)
        {
            Console.WriteLine(number);
        }

        // Peek at the top member in the queue
        Console.WriteLine($"\nPeek at front member in queue: {queue.Peek()}");

        // Dequeue elements from the queue and print each
        Console.WriteLine("\nDequeuing elements from queue:");
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
        #endregion
    }
}
