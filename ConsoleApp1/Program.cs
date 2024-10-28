using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        #region SimpleArray
        // Simple array
        int[] array = new int[5];

        // Initialize array with values 11 to 15
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = 11 + i;
        }

        // Print values in the array using foreach loop
        Console.WriteLine("Array values:");
        foreach (int value in array)
        {
            Console.WriteLine(value);
        }
        #endregion

        #region List<T>
        // List<T>
        List<int> list = new List<int>();

        // Initialize list with values 21 to 25
        for (int i = 0; i < 5; i++)
        {
            list.Add(21 + i);
        }

        // Print values in the list using foreach loop
        Console.WriteLine("\nList values:");
        foreach (int value in list)
        {
            Console.WriteLine(value);
        }

        // Update the values in the list to 31 to 35 using a for loop
        for (int i = 0; i < list.Count; i++)
        {
            list[i] = 31 + i;
        }

        // Print updated list values using a for loop and indexing
        Console.WriteLine("\nUpdated List values:");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
        #endregion
    }
}
