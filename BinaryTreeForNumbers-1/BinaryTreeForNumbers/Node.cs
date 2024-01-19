using System;

namespace BinaryTreeForNumbers
{
    /// <summary>
    /// Represents a node in a binary tree that stores elements of type T, where T is comparable.
    /// </summary>
    /// <typeparam name="T">The type of elements stored in the node, must be comparable.</typeparam>
    public class Node<T> where T : IComparable<T>
    {
        /// <summary>
        /// Gets or sets the value of the node.
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// Gets or sets the left child node of the current node.
        /// </summary>
        public Node<T> Left { get; set; }

        /// <summary>
        /// Gets or sets the right child node of the current node.
        /// </summary>
        public Node<T> Right { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Node{T}"/> class with the specified value.
        /// </summary>
        /// <param name="value">The value to be stored in the node.</param>
        public Node(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}
