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
    public class LinkedList<T> : IEnumerable // ICollection<T>
    {
        /// <summary>
        /// The head (first element) of the list.
        /// </summary>
        private Node<T> head;

        /// <summary>
        /// The tail (end element) of the list.
        /// </summary>
        private Node<T> tail;

        /// <summary>
        /// The number of elements in the list
        /// </summary>
        private int count;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedList{T}"/> class.
        /// </summary>
        public LinkedList()
        {
            this.head = null;
            this.count = 0;
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
        /// Gets the number of elements in the list
        /// </summary>
        public int Count
        {
            get
            {
                return this.count;
            }
        }

        /// <summary>
        /// Gets the head (first element) of the list.  Internal so that <see cref="LinkedListForwardEnumerator"/> can access.
        /// </summary>
        internal Node<T> Head
        {
            get
            {
                return this.head;
            }
        }

        /// <summary>
        /// Adds an element to the list
        /// </summary>
        /// <param name="node">A node to add</param>
        public void Add(T node)
        {
            // We have an empty list
            if (this.Count == 0)
            {
                this.head = new Node<T>(node);
                this.tail = this.head;
                this.count = 1;
            }
            else
            {
                this.tail.Next = new Node<T>(node);
                this.tail.Next.Previous = this.tail;
                this.tail = this.tail.Next;
                this.count++;
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