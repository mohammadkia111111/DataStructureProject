using System;

namespace BinaryTreeForNumbers
{
    /// <summary>
    /// Represents the main program for testing the BinaryTree class with sample data.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The entry point of the program.
        /// </summary>
        /// <param name="args">Command-line arguments (not used in this program).</param>
        static void Main(string[] args)
        {
            // Create an instance of the BinaryTree<int> class
            BinaryTree<int> binaryTree = new BinaryTree<int>();

            // Display the initial state of the tree
            Console.WriteLine("\n####Print Tree####");
            binaryTree.PrintTree();

            // Create a binary tree with sample data
            int[] sampleData = { 5, 3, 8, 2, 4, 7, 9 };
            binaryTree.CreateTree(sampleData);

            // Display the tree after adding sample data
            Console.WriteLine("\n####Print Tree####");
            binaryTree.PrintTree();

            // Perform various operations on the binary tree
            Console.WriteLine("Binary Tree Operations:");
            Console.WriteLine("1. Print Items In Order:");
            binaryTree.PrintItemsInOrder();

            Console.WriteLine("\n2. Print Items Pre Order:");
            binaryTree.PrintItemsPreOrder();

            Console.WriteLine("\n3. Print Items Post Order:");
            binaryTree.PrintItemsPostOrder();

            Console.WriteLine("\n4. Sum of All Items: " + binaryTree.SumOfAllItems());
            Console.WriteLine("5. Number of Levels: " + binaryTree.CalculateLevelsNumber());
            Console.WriteLine("6. Number of Nodes: " + binaryTree.CalculateNodesNumber());
            Console.WriteLine("7. Number of Leafs: " + binaryTree.CalculateLeafsNumber());

            // Display the tree after performing operations
            Console.WriteLine("\n####Print Tree####");
            binaryTree.PrintTree();

            // Remove an item from the tree and display the updated tree
            Console.WriteLine("\n8. Remove Item 3:");
            binaryTree.RemoveItem(3);

            Console.WriteLine("\n####Print Tree####");
            binaryTree.PrintTree();
            binaryTree.PrintItemsInOrder();

            // Add an item to the tree and display the updated tree
            Console.WriteLine("\n9. Add Item 6:");
            binaryTree.AddItem(6);
            Console.WriteLine("\n####Print Tree####");
            binaryTree.PrintTree();
            binaryTree.PrintItemsInOrder();

            // Display the final state of the tree
            Console.WriteLine("\n####Print Tree####");
            binaryTree.PrintTree();

            // Wait for a key press before closing the console
            Console.ReadKey();
        }
    }
}
