using System;
using System.Collections.Generic;

namespace GeneralizedListProject
{
    /// <summary>
    /// Represents a two-way circular linked list containing elements of type T.
    /// </summary>
    /// <typeparam name="T">The type of elements in the list.</typeparam>
    public class TwoWayCircularLinkedList<T>
    {
        private class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }

            public Node(T data)
            {
                Data = data;
            }
        }

        private Node head;
        private Node tail;

        /// <summary>
        /// Adds an item to the two-way circular linked list.
        /// </summary>
        /// <param name="item">The item to add.</param>
        public void Add(T item)
        {
            Node newNode = new Node(item);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Previous = tail;
                tail = newNode;
            }

            tail.Next = head;
            head.Previous = tail;
        }

        /// <summary>
        /// Removes the specified item from the two-way circular linked list.
        /// </summary>
        /// <param name="item">The item to remove.</param>
        public void Remove(T item)
        {
            Node current = head;

            do
            {
                if (current.Data.Equals(item))
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;

                    if (current == head)
                        head = current.Next;

                    if (current == tail)
                        tail = current.Previous;

                    return;
                }

                current = current.Next;
            } while (current != head);
        }

        /// <summary>
        /// Prints the elements of the two-way circular linked list.
        /// </summary>
        public void Print()
        {
            if (head == null)
                return;

            Node current = head;

            do
            {
                Console.Write($"{current.Data} ");
                current = current.Next;
            } while (current != head);

            Console.WriteLine();
        }

        /// <summary>
        /// Sorts the elements of the two-way circular linked list.
        /// </summary>
        public void Sort()
        {
            // Implement your sorting algorithm here.
            // For simplicity, let's use a bubble sort in this example.
            bool swapped;

            do
            {
                swapped = false;
                Node current = head;

                while (current.Next != head)
                {
                    if (Comparer<T>.Default.Compare(current.Data, current.Next.Data) > 0)
                    {
                        T temp = current.Data;
                        current.Data = current.Next.Data;
                        current.Next.Data = temp;
                        swapped = true;
                    }

                    current = current.Next;
                }

            } while (swapped);
        }
    }
}
