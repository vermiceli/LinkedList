// <copyright file="LinkedList.cs" company="Michael Miceli">
// Copyright Michael Miceli.  All rights are reserved.
// </copyright>

namespace Michael.Collecition.LinkedList
{
    using System.Collections;
    using System.Collections.Generic;
    using Michael.Collecition.LinkedList.Enumerators;

    /// <summary>
    /// A linked list implementation
    /// </summary>
    /// <typeparam name="T">The type that the linked list is composed of</typeparam>
    public class LinkedList<T> : IEnumerable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedList{T}"/> class.
        /// </summary>
        public LinkedList()
        {
            this.Head = null;
            this.Count = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedList{T}"/> class.  A copy constructor
        /// </summary>
        /// <param name="list">A collection to copy</param>
        public LinkedList(ICollection<T> list)
        {
            foreach (T t in list)
            {
                this.Add(t);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedList{T}"/> class.
        /// </summary>
        /// <param name="head">The first element in a list</param>
        public LinkedList(T head)
        {
            this.Add(head);
        }

        /// <summary>
        /// Gets or sets the number of elements in the list
        /// Exposing set so that I can do some programming exercises, usually I wouldn't expose these to the client
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the head (first element) of the list.  Internal so that <see cref="LinkedListForwardEnumerator"/> can access.
        /// Exposing set so that I can do some programming exercises, usually I wouldn't expose these to the client
        /// </summary>
        public Node<T> Head { get; set; }

        /// <summary>
        /// Gets or sets the tail (end element) of the list.  Internal so that <see cref="LinkedListForwardEnumerator"/> can access.
        /// Exposing set so that I can do some programming exercises, usually I wouldn't expose these to the client
        /// </summary>
        public Node<T> Tail { get; set; }

        /// <summary>
        /// Adds an element to the list
        /// </summary>
        /// <param name="node">A node to add</param>
        public void Add(T node)
        {
            // We have an empty list
            if (this.Count == 0)
            {
                this.Head = new Node<T>(node);
                this.Tail = this.Head;
                this.Count = 1;
            }
            else
            {
                this.Tail.Next = new Node<T>(node);
                this.Tail.Next.Previous = this.Tail;
                this.Tail = this.Tail.Next;
                this.Count++;
            }
        }

        /// <summary>
        /// Inherited from IEnumerable, used for enumeration of collections
        /// </summary>
        /// <returns>An enumerator to go over the list</returns>
        public IEnumerator GetEnumerator()
        {
            return new LinkedListForwardEnumerator<T>(this);
        }
    }
}