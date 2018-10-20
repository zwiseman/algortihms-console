using System;

namespace algorithms {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("*************************** Algorithms **********************");

            algorithm algorithm = new algorithm ();

            int[] sortedArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1001 };
            Console.WriteLine ("Binary Search: O(n)");
            Console.WriteLine (algorithm.binarySearch (sortedArray, 1001, 0, sortedArray.Length));
            Console.WriteLine ();
        }
    }
}