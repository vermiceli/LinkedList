// <copyright file="LinkedListForwardEnumerator.cs" company="Michael Miceli">
// Copyright Michael Miceli.  All rights are reserved.
// </copyright>

namespace Michael.Collecition.LinkedList.Enumerators
{
    using System.Collections;

    /// <summary>
    /// An enumerator
    /// </summary>
    /// <typeparam name="T">The type that the linked list is composed of</typeparam>
    public class LinkedListForwardEnumerator<T> : IEnumerator
    {
        /// <summary>
        /// The current position of the list
        /// </summary>
        private Node<T> ptr;

        /// <summary>
        /// A local (shallow) copy of the list
        /// </summary>
        private LinkedList<T> linkedList;

        /// <summary>
        /// A pointer to one element before the list
        /// </summary>
        private Node<T> begin;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedListForwardEnumerator{T}" /> class.
        /// </summary>
        /// <param name="list">A copy constructor</param>
        public LinkedListForwardEnumerator(LinkedList<T> list)
        {
            this.linkedList = list;
            this.begin = new Node<T>();
            this.begin.Next = this.linkedList.Head;
            this.ptr = this.begin;
        }

        /// <summary>
        /// Gets the current element in the collection
        /// </summary>
        public object Current
        {
            get
            {
                return this.ptr.Data;
            }
        }

        /// <summary>
        /// Dispose is required because of
        /// </summary>
        public void Dispose()
        {
        }

        /// <summary>
        /// Advances the enumerator to the next element of the collection
        /// </summary>
        /// <returns>true if successfully advanced; false if passed the end of the collection</returns>
        public bool MoveNext()
        {
            this.ptr = this.ptr.Next;
            if (this.ptr == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Sets the enumerator to its initial position, which is before the first element in the collection
        /// </summary>
        public void Reset()
        {
            this.ptr = this.begin;
        }
    }
}