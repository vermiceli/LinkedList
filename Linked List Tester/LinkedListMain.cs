// <copyright file="LinkedListMain.cs" company="Michael Miceli">
// Copyright Michael Miceli.  All rights are reserved.
// </copyright>

namespace Michael.Collecition.LinkedListMain
{
    using System;
    using System.Diagnostics;
    using Michael.Collecition.LinkedList;

    /// <summary>
    /// Main class that contains the main method
    /// </summary>
    public class LinkedListMain
    {
        /// <summary>
        /// Main class that uses personal linked list implementation
        /// </summary>
        public static void Main()
        {
            LinkedList<int> list = new LinkedList<int>() { 1, 2, 3, 4, 5 };

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            Reverse<int>(list);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Reverses a linked list in place.  Goes through and swaps the next and previous pointers.
        /// </summary>
        /// <typeparam name="T">The type that the list contains</typeparam>
        /// <param name="list">The list to reverse</param>
        private static void Reverse<T>(LinkedList<T> list)
        {
            Node<T> temp;
            list.Tail = list.Head;
            while (list.Head != null)
            {
                // swapping the next and previous pointers
                temp = list.Head.Previous;
                list.Head.Previous = list.Head.Next;
                list.Head.Next = temp;

                // We've reached the end of the list
                if (list.Head.Previous == null)
                {
                    break;
                }

                // move to "next" element (now the previous)
                list.Head = list.Head.Previous;
            }
        }
    }
}
