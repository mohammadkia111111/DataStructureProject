using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralizedListProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a GeneralizedList with numbers
            GeneralizedList<int> numbersList = new GeneralizedList<int>();
            numbersList.Add(1);
            numbersList.Add(2);
            numbersList.Add(3);

            // Creating another GeneralizedList with more numbers
            GeneralizedList<int> moreNumbersList = new GeneralizedList<int>();
            moreNumbersList.Add(4);
            moreNumbersList.Add(5);

            // Creating a GeneralizedList with nested lists
            GeneralizedList<int> nestedList1 = new GeneralizedList<int>();
            nestedList1.Add(7);
            nestedList1.Add(6);

            GeneralizedList<int> nestedList2 = new GeneralizedList<int>();
            nestedList2.Add(9);
            nestedList2.Add(8);

            GeneralizedList<int> combinedNestedList = new GeneralizedList<int>();
            combinedNestedList.Add(nestedList1);
            combinedNestedList.Add(nestedList2);

            // Adding the numbers and nested lists to the main list
            numbersList.Add(10);
            numbersList.Add(combinedNestedList);

            // Printing the list
            Console.WriteLine("Original GeneralizedList:");
            numbersList.Print();

            // Testing depth and sum
            Console.WriteLine("\nDepth of the GeneralizedList: " + numbersList.Depth());
            Console.WriteLine("Sum of the GeneralizedList: " + numbersList.Sum());

            // Creating a copy of the GeneralizedList for testing SequenceEqual
            GeneralizedList<int> copyList = new GeneralizedList<int>();
            copyList.Add(1);
            copyList.Add(2);
            copyList.Add(3);
            copyList.Add(10);
            copyList.Add(combinedNestedList);

            // Testing SequenceEqual
            Console.WriteLine("\nIs the copied list equal to the original list? " + numbersList.SequenceEqual(copyList));

            // Removing an item from the list
            numbersList.Remove(7);

            // Printing the modified list
            Console.WriteLine("\nModified GeneralizedList after removing 7:");
            numbersList.Print();

            // Convert to sorted linked list
            var sortedLinkedList = numbersList.ToSortedTwoWayCircularLinkedList();
            Console.WriteLine("\nSorted LinkedList:");
            sortedLinkedList.Print();
            Console.ReadKey();
        }
    }
}
