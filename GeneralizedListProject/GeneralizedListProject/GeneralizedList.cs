using System;
using System.Collections.Generic;

namespace GeneralizedListProject
{
    /// <summary>
    /// Represents a generalized list containing elements of type T.
    /// </summary>
    /// <typeparam name="T">The type of elements in the list, must implement IComparable.</typeparam>
    public class GeneralizedList<T> where T : IComparable<T>
    {
        private class Node
        {
            public T Data { get; set; }
            public GeneralizedList<T> SubList { get; set; }
            public Node Next { get; set; }

            public bool HasNestedList => SubList != null;

            public Node(T data)
            {
                Data = data;
                Next = null;
                SubList = null;
            }

            public Node(GeneralizedList<T> list)
            {
                SubList = list;
                Data = default(T);
                Next = null;
            }
        }

        private Node head;

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralizedList{T}"/> class.
        /// </summary>
        public GeneralizedList()
        {
            head = null;
        }

        /// <summary>
        /// Adds an item to the generalized list.
        /// </summary>
        /// <param name="item">The item to add.</param>
        public void Add(T item)
        {
            Node node = new Node(item);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }
        }

        /// <summary>
        /// Adds a nested generalized list to the current list.
        /// </summary>
        /// <param name="list">The nested list to add.</param>
        public void Add(GeneralizedList<T> list)
        {
            Node node = new Node(list);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }
        }

        /// <summary>
        /// Prints the generalized list.
        /// </summary>
        /// <param name="colorful">Specifies whether to use colorful output.</param>
        public void Print(bool colorful = true)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[");
            Console.ResetColor();
            PrintRecursive(head, colorful);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("]");
            Console.ResetColor();
        }

        private void PrintRecursive(Node node, bool colorful, ConsoleColor color = ConsoleColor.White)
        {
            if (node == null)
                return;

            Node current = node;
            while (current != null)
            {
                if (current.HasNestedList)
                {
                    var newColor = colorful ? ((ConsoleColor)((int)color % 15) + 1) : color;
                    Console.ForegroundColor = newColor;
                    Console.Write("[");
                    Console.ResetColor();
                    PrintRecursive(current.SubList.head, colorful, newColor);
                    Console.ForegroundColor = newColor;
                    Console.Write("]");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = color;
                    Console.Write(current.Data);
                    Console.ResetColor();
                }
                if (current.Next != null)
                {
                    Console.ForegroundColor = color;
                    Console.Write(", ");
                    Console.ResetColor();
                }
                current = current.Next;
            }
        }

        /// <summary>
        /// Calculates the depth of the generalized list.
        /// </summary>
        /// <returns>The depth of the list.</returns>
        public int Depth() => 1 + DepthRecursive(head);

        private int DepthRecursive(Node node)
        {
            if (node == null)
                return 0;

            Node current = node;
            var maxDepth = 0;
            while (current != null)
            {
                var depth = current.HasNestedList ? 1 + DepthRecursive(current.SubList.head) : 0;

                if (depth > maxDepth)
                    maxDepth = depth;
                current = current.Next;
            }

            return maxDepth;
        }

        /// <summary>
        /// Calculates the sum of elements in the generalized list.
        /// </summary>
        /// <returns>The sum of elements.</returns>
        public T Sum() => SumRecursive(head);

        private T SumRecursive(Node node)
        {
            if (node == null)
                return default(T);

            dynamic sum = default(T);

            Node current = node;
            while (current != null)
            {
                sum += current.HasNestedList ? SumRecursive(current.SubList.head) : current.Data;

                current = current.Next;
            }
            return sum;
        }

        /// <summary>
        /// Removes specified items from the generalized list.
        /// </summary>
        /// <param name="item">The item to remove.</param>
        public void Remove(T item)
        {
            if (head == null)
                return;

            while (head != null && !head.HasNestedList && head.Data.Equals(item))
                head = head.Next;

            if (head == null)
                return;

            if (head.HasNestedList)
                head.SubList.Remove(item);

            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.HasNestedList)
                    current.Next.SubList.Remove(item);
                else
                {
                    if (current.Next.Data.Equals(item))
                    {
                        current.Next = current.Next.Next;
                    }
                }
                if (current.Next == null)
                    return;
                current = current.Next;
            }
        }

        /// <summary>
        /// Checks if two generalized lists are equal.
        /// </summary>
        /// <param name="other">The other generalized list to compare.</param>
        /// <returns>True if the lists are equal, otherwise false.</returns>
        public bool SequenceEqual(GeneralizedList<T> other)
        {
            if (other == null)
                return false;
            if (head is null && other.head is null)
                return true;
            if (head is null || other.head is null)
                return false;

            Node a = head;
            Node b = other.head;

            while (a != null && b != null)
            {
                if (a.HasNestedList && b.HasNestedList)
                {
                    if (!a.SubList.SequenceEqual(b.SubList))
                        return false;
                }
                else if (a.HasNestedList || b.HasNestedList)
                    return false;
                else if (!a.Data.Equals(b.Data))
                    return false;

                a = a.Next;
                b = b.Next;
            }

            if (a is null && b is null)
                return true;
            return false;
        }

        /// <summary>
        /// Converts the generalized list to a sorted two-way circular linked list.
        /// </summary>
        /// <returns>The sorted two-way circular linked list.</returns>
        public TwoWayCircularLinkedList<T> ToSortedTwoWayCircularLinkedList() => ToSortedTwoWayCircularLinkedList(this);

        private static TwoWayCircularLinkedList<T> ToSortedTwoWayCircularLinkedList(GeneralizedList<T> generalizedList)
        {
            TwoWayCircularLinkedList<T> result = new TwoWayCircularLinkedList<T>();
            generalizedList.AddToLinkedList(result);
            result.Sort();
            return result;
        }

        private void AddToLinkedList(TwoWayCircularLinkedList<T> list)
        {
            if (head is null)
                return;

            Node current = head;
            while (current != null)
            {
                if (current.HasNestedList)
                    current.SubList.AddToLinkedList(list);
                else
                {
                    list.Add(current.Data);
                }

                current = current.Next;
            }
        }
    }
}
