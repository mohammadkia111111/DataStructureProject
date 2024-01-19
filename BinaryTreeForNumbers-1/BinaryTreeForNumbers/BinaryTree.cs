using System;
using System.Xml.Linq;

namespace BinaryTreeForNumbers
{
    /// <summary>
    /// Represents a binary tree data structure that stores elements of type T, where T is comparable.
    /// </summary>
    /// <typeparam name="T">The type of elements in the binary tree, must be comparable.</typeparam>
    public class BinaryTree<T> where T : IComparable<T>
    {
        private Node<T> root;

        /// <summary>
        /// Creates a binary tree from an array of values.
        /// </summary>
        /// <param name="values">Array of values to create the binary tree.</param>
        public void CreateTree(T[] values)
        {
            foreach (var value in values)
            {
                AddItem(value);
            }
        }

        /// <summary>
        /// Adds an item to the binary tree.
        /// </summary>
        /// <param name="value">The value to add to the binary tree.</param>
        public void AddItem(T value)
        {
            root = AddItemRecursive(root, value);
        }

        /// <summary>
        /// Recursive helper method to add an item to the binary tree.
        /// </summary>
        private Node<T> AddItemRecursive(Node<T> node, T value)
        {
            if (node == null)
            {
                return new Node<T>(value);
            }

            dynamic mod = value;
            mod %= 3;
            if (mod == 0)
            {
                node.Left = AddItemRecursive(node.Left, value);
            }
            else
            {
                node.Right = AddItemRecursive(node.Right, value);
            }

            return node;
        }

        /// <summary>
        /// Removes an item from the binary tree.
        /// </summary>
        /// <param name="value">The value to remove from the binary tree.</param>
        public void RemoveItem(T value)
        {
            root = RemoveItemRecursive(root, value);
        }

        /// <summary>
        /// Recursive helper method to remove an item from the binary tree.
        /// </summary>
        private Node<T> RemoveItemRecursive(Node<T> root, T value)
        {
            if (root == null)
            {
                return root;
            }

            dynamic mod = value;
            mod %= 3;
            if (value.CompareTo(root.Value) == 0)
            {
                if (root.Left == null)
                {
                    return root.Right;
                }
                else if (root.Right == null)
                {
                    return root.Left;
                }

                root.Value = LastDividableValue(root.Right);

                root.Right = RemoveItemRecursive(root.Right, root.Value);
            }
            else if (mod == 0)
            {
                root.Left = RemoveItemRecursive(root.Left, value);
            }
            else 
            {
                root.Right = RemoveItemRecursive(root.Right, value);
            }
            

            return root;
        }

        /// <summary>
        /// Finds the latest dividable value in a subtree.
        /// </summary>
        private T LastDividableValue(Node<T> root)
        {
            T lastDividableValue = root.Value;
            while (root.Left != null)
            {
                lastDividableValue = root.Left.Value;
                root = root.Left;
            }
            return lastDividableValue;
        }

        /// <summary>
        /// Calculates the sum of all items in the binary tree.
        /// </summary>
        public T SumOfAllItems()
        {
            return SumOfAllItemsRecursive(root);
        }

        /// <summary>
        /// Recursive helper method to calculate the sum of all items in the binary tree.
        /// </summary>
        private T SumOfAllItemsRecursive(Node<T> root)
        {
            if (root == null)
            {
                return default(T);
            }

            dynamic sum = root.Value;
            sum += SumOfAllItemsRecursive(root.Left);
            sum += SumOfAllItemsRecursive(root.Right);
            return sum;
        }

        /// <summary>
        /// Calculates the number of levels in the binary tree.
        /// </summary>
        public int CalculateLevelsNumber()
        {
            return CalculateLevelsNumberRecursive(root);
        }

        /// <summary>
        /// Recursive helper method to calculate the number of levels in the binary tree.
        /// </summary>
        private int CalculateLevelsNumberRecursive(Node<T> root)
        {
            if (root == null)
            {
                return 0;
            }

            int leftDepth = CalculateLevelsNumberRecursive(root.Left);
            int rightDepth = CalculateLevelsNumberRecursive(root.Right);

            return Math.Max(leftDepth, rightDepth) + 1;
        }

        /// <summary>
        /// Calculates the total number of nodes in the binary tree.
        /// </summary>
        public int CalculateNodesNumber()
        {
            return CalculateNodesNumberRecursive(root);
        }

        /// <summary>
        /// Recursive helper method to calculate the total number of nodes in the binary tree.
        /// </summary>
        private int CalculateNodesNumberRecursive(Node<T> root)
        {
            if (root == null)
            {
                return 0;
            }

            return 1 + CalculateNodesNumberRecursive(root.Left) + CalculateNodesNumberRecursive(root.Right);
        }

        /// <summary>
        /// Calculates the number of leaf nodes in the binary tree.
        /// </summary>
        public int CalculateLeafsNumber()
        {
            return CalculateLeafsNumberRecursive(root);
        }

        /// <summary>
        /// Recursive helper method to calculate the number of leaf nodes in the binary tree.
        /// </summary>
        private int CalculateLeafsNumberRecursive(Node<T> root)
        {
            if (root == null)
            {
                return 0;
            }

            if (root.Left == null && root.Right == null)
            {
                return 1;
            }

            return CalculateLeafsNumberRecursive(root.Left) + CalculateLeafsNumberRecursive(root.Right);
        }

        /// <summary>
        /// Prints the items in pre-order traversal.
        /// </summary>
        public void PrintItemsPreOrder()
        {
            PrintItemsPreOrderRecursive(root);
            Console.WriteLine();
        }

        /// <summary>
        /// Recursive helper method to print the items in pre-order traversal.
        /// </summary>
        private void PrintItemsPreOrderRecursive(Node<T> root)
        {
            if (root != null)
            {
                Console.Write(root.Value + " ");
                PrintItemsPreOrderRecursive(root.Left);
                PrintItemsPreOrderRecursive(root.Right);
            }
        }

        /// <summary>
        /// Prints the items in post-order traversal.
        /// </summary>
        public void PrintItemsPostOrder()
        {
            PrintItemsPostOrderRecursive(root);
            Console.WriteLine();
        }

        /// <summary>
        /// Recursive helper method to print the items in post-order traversal.
        /// </summary>
        private void PrintItemsPostOrderRecursive(Node<T> root)
        {
            if (root != null)
            {
                PrintItemsPostOrderRecursive(root.Left);
                PrintItemsPostOrderRecursive(root.Right);
                Console.Write(root.Value + " ");
            }
        }

        /// <summary>
        /// Prints the items in in-order traversal.
        /// </summary>
        public void PrintItemsInOrder()
        {
            PrintItemsInOrderRecursive(root);
            Console.WriteLine();
        }

        /// <summary>
        /// Recursive helper method to print the items in in-order traversal.
        /// </summary>
        private void PrintItemsInOrderRecursive(Node<T> root)
        {
            if (root != null)
            {
                PrintItemsInOrderRecursive(root.Left);
                Console.Write(root.Value + " ");
                PrintItemsInOrderRecursive(root.Right);
            }
        }

        /// <summary>
        /// Prints the structure of the binary tree in a tree-like format.
        /// </summary>
        public void PrintTree()
        {
            PrintTreeRecursive(root, "", true);
        }

        /// <summary>
        /// Recursive helper method to print the structure of the binary tree.
        /// </summary>
        private void PrintTreeRecursive(Node<T> node, string indent, bool last)
        {
            if (node == null)
                return;

            Console.WriteLine(indent + "+- " + node.Value);
            indent += last ? "   " : "|  ";

            PrintTreeRecursive(node.Left, indent, false);
            PrintTreeRecursive(node.Right, indent, true);
        }
    }
}
