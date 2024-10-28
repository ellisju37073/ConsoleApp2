using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a string array with the first few words of a nursery rhyme
        string[] rhymeWords = { "Twinkle", "twinkle", "little", "star", "how", "I", "wonder", "what", "you", "are" };

        // Use the string array to initialize a LinkedList
        LinkedList<string> rhymeList = new LinkedList<string>(rhymeWords);

        // Print the rhyme on a single line using the enumerator
        Console.WriteLine("Rhyme using enumerator:");
        foreach (string word in rhymeList)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();

        // Walk the linked list starting from the head and print each word
        Console.WriteLine("\nRhyme by walking the linked list:");
        LinkedListNode<string> currentNode = rhymeList.First;
        while (currentNode != null)
        {
            Console.Write(currentNode.Value + " ");
            currentNode = currentNode.Next;
        }
        Console.WriteLine();

        // Remove a word from the middle of the list and print the list
        LinkedListNode<string> nodeToRemove = rhymeList.Find("how");
        if (nodeToRemove != null)
        {
            rhymeList.Remove(nodeToRemove);
        }

        Console.WriteLine("\nRhyme after removing 'how':");
        foreach (string word in rhymeList)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();

        // Add the word back into the list and print the list again
        LinkedListNode<string> nodeBefore = rhymeList.Find("star");
        if (nodeBefore != null)
        {
            rhymeList.AddAfter(nodeBefore, "how");
        }

        Console.WriteLine("\nRhyme after adding 'how' back:");
        foreach (string word in rhymeList)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }
}
