using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_Conversion
{
    /// <summary>
    /// Represents a custom stack data structure that stores elements of type T.
    /// </summary>
    /// <typeparam name="T">The type of elements stored in the stack.</typeparam>
    public class CustomStack<T>
    {
        private Node<T> top;

        /// <summary>
        /// Checks if the stack is empty.
        /// </summary>
        /// <returns>True if the stack is empty; otherwise, false.</returns>
        public bool IsEmpty()
        {
            return top == null;
        }

        /// <summary>
        /// Pushes a new element onto the top of the stack.
        /// </summary>
        /// <param name="value">The value to be pushed onto the stack.</param>
        public void Push(T value)
        {
            Node<T> newNode = new Node<T>(value);
            newNode.Right = top;
            top = newNode;
        }

        /// <summary>
        /// Pops the element from the top of the stack.
        /// </summary>
        /// <returns>The value popped from the top of the stack.</returns>
        /// <exception cref="InvalidOperationException">Thrown when attempting to pop from an empty stack.</exception>
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T value = top.Value;
            top = top.Right;
            return value;
        }

        /// <summary>
        /// Peeks at the element on the top of the stack without removing it.
        /// </summary>
        /// <returns>The value at the top of the stack.</returns>
        /// <exception cref="InvalidOperationException">Thrown when attempting to peek an empty stack.</exception>
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return top.Value;
        }
    }
}
