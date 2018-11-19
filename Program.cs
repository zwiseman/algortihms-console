using System;

namespace algorithms {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("*************************** Algorithms **********************");

            algorithm algorithm = new algorithm ();

            /********** Binary Search **************/
            int[] sortedArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1001 };
            Console.WriteLine ("Binary Search: O(log n)");
            Console.WriteLine (algorithm.binarySearch (sortedArray, 1001, 0, sortedArray.Length));
            Console.WriteLine ();

            /************ Counting Sort *************/
            int[] a = { 0, 5, 6, 10, 4, 7, 4, 1000000, 1, 1, 1, 1, 1, 1, 1, 0, 200 };
            int[] b = new int[a.Length];
            Console.WriteLine ("Counting Sort: O(n)");
            Console.Write ("unsorted array: ");

            for (int i = 0; i < a.Length; i++) {
                Console.Write (a[i] + " ");
            }

            algorithm.countingSort (a, b, 1000000);
            Console.WriteLine ();
            Console.Write ("sorted array: ");

            for (int i = 0; i < b.Length; i++) {
                Console.Write (b[i] + " ");
            }

            Console.WriteLine ();

            /**************** Matrix **************/
            Console.WriteLine ();
            int[, ] matrix = { { 0, 20, 15, -1 },
                { 101, 1, 1, 6 },
                {-1, 0, -4, 10 },
                { 1, 1, 3, 1 },
                { 0, 0, 0, -1 },
                { 5, 5, 1, 1 },
                { 1, 1, -100, 1 },
                { 16, 77, 0, 2 },
                { 1, 7, 1, 5 }
            };
            Console.WriteLine ("Matrix has all ones");
            Console.WriteLine("Input Matrix:");
            for (int i = 0; i < matrix.GetLength (0); i++) {
                Console.Write("  ");
                for (int j = 0; j < matrix.GetLength (1); j++) {
                    Console.Write (matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[, ] result = algorithm.manipulateZeroValue (matrix);

            Console.WriteLine ();
            Console.WriteLine("  Output Matrix:");
            for (int i = 0; i < result.GetLength (0); i++) {
                Console.Write("  ");
                for (int j = 0; j < result.GetLength (1); j++) {
                    Console.Write (result[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine ();

            int[] notbst = { 21, 30, 10, 15, 16, 18, 22, 100, 1000, 20, 50, 30, 60, 1001, 999, 1, 2, 19, 13, 99 };

            BinarySearchTree bst = new BinarySearchTree ();

            for (int i = 0; i < notbst.Length; i++) {
                bst.insert (new TreeNode (notbst[i]));
            }

            Console.WriteLine ();
            Console.WriteLine ("Binary Search Tree");
            Console.WriteLine ("  Tree Size: " + bst.getSize ());
            Console.Write ("  Pre-order Traversal: ");
            bst.preOrderTraversal ();
            Console.WriteLine ();
            Console.Write ("  In-order Traversal: ");
            bst.InOrderTraversal ();
            Console.WriteLine ();
            Console.Write ("  Post-order Traversal: ");
            bst.postOrderTraversal ();
            Console.WriteLine();
            Console.WriteLine ("  Maximum value: " + bst.maximum ().getKey ());
            Console.WriteLine ("  Minumum value: " + bst.minimum ().getKey ());

            Console.WriteLine ();
            Console.WriteLine ("Search for 50 information ");
            Console.WriteLine ("  Parent: " + bst.search (50).getParent ().getKey ());
            Console.WriteLine ("  Right Child: " + bst.search (50).getRightChild ().getKey ());
            Console.WriteLine ("  Left Child: " + bst.search (50).getLeftChild ().getKey ());

            Console.WriteLine ();
            Console.WriteLine ("Bubble Sort");
            int[] bubbleSort = { 1, -10, 1000, 39 };

            Console.Write ("  Unsorted array: ");
            for (int i = 0; i < bubbleSort.Length; i++) {
                Console.Write (bubbleSort[i] + " ");
            }

            algorithm.bubbleSort (bubbleSort);

            Console.WriteLine ();
            Console.Write ("  Sorted array: ");
            for (int i = 0; i < bubbleSort.Length; i++) {
                Console.Write (bubbleSort[i] + " ");
            }

            Console.WriteLine ();
            Console.WriteLine ();
            Console.WriteLine ("Reverse an input array");
            int[] reverse = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] reversed = algorithm.reverseArray (reverse);

            Console.Write ("  Input Array: ");
            for (int i = 0; i < reverse.Length; i++) {
                Console.Write (reverse[i] + " ");
            }

            Console.WriteLine ();
            Console.Write ("  Reversed array: ");
            for (int i = 0; i < reversed.Length; i++) {
                Console.Write (reversed[i] + " ");
            }
            Console.WriteLine ();
        }
    }
}