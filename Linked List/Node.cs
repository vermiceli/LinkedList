// <copyright file="Node.cs" company="Michael Miceli">
// Copyright Michael Miceli.  All rights are reserved.
// </copyright>

namespace Michael.Collecition.LinkedList
{
    using System;

    /// <summary>
    /// A simple node that contains data and next/previous pointers
    /// </summary>
    /// <typeparam name="T">The type that he node contains</typeparam>
    public class Node<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Node{T}"/> class.
        /// </summary>
        public Node()
        {
            this.Next = null;
            this.Previous = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Node{T}"/> class.
        /// </summary>
        /// <param name="data">Data for the node to hold</param>
        public Node(T data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("data");
            }

            this.Data = data;
            this.Next = null;
            this.Previous = null;
        }

        /// <summary>
        /// Gets or sets the data of the node
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Gets or sets a next pointer
        /// </summary>
        public Node<T> Next { get; set; }

        /// <summary>
        /// Gets or sets a previous pointer
        /// </summary>
        public Node<T> Previous { get; set; }

        /// <summary>
        /// A simple toString method that calls {T}'s toString method
        /// </summary>
        /// <returns>A string representation of the data</returns>
        public override string ToString()
        {
            return this.Data.ToString();
        }
    }
}
