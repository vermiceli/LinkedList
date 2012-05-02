// <copyright file="LinkedListMain.cs" company="Michael Miceli">
// Copyright Michael Miceli.  All rights are reserved.
// </copyright>

namespace Michael.Collecition.LinkedListMain
{
    using System;
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
            LinkedList<int> list = new LinkedList<int>() { 1, 3 };

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
