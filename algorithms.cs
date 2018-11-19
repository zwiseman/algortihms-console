using System;

namespace algorithms {
    public class algorithm {
        public algorithm () { }

        /**
         * Binary Search: break each array size in half until we find the number we
         * are looking for. O(log n)
         */
        public bool binarySearch (int[] array, int number, int head, int tail) {
            int pos = head + ((tail - head) / 2);

            if (pos > array.Length - 1) {
                return false;
            } else {
                if (number == array[pos]) {
                    return true;
                } else if (number <= array[pos]) {
                    return binarySearch (array, number, head, pos - 1); // search first half
                } else {
                    return binarySearch (array, number, pos + 1, tail);
                }
            }
        }

        /**
         * Counting Sort: given an input array, create another array with
         * length the same size as the input array that will be the sorted array
         * and create another array to store the counts of each number that
         * will be the length of the largest number + 1. i.e (largest value 3, length 4,
         * [0, 1, 2, 3, 4]). O(n + k) where k is the size of the largest number.
         */
        public void countingSort (int[] a, int[] b, int largest) {
            int[] c = new int[largest + 1];

            for (int i = 0; i < a.Length; i++) {
                c[a[i]]++;
            }

            for (int i = 1; i < c.Length; i++) {
                c[i] = c[i] + c[i - 1];
            }

            for (int i = a.Length - 1; i > 0; i--) {
                b[c[a[i]] - 1] = a[i];
                c[a[i]]--;
            }
        }

        /**
         * Bubble sort: Sawp each element of the array from start to finish.example 
         * Average case: O(n)
         * 
         * worst Case: O(n2) when array is sorted in reverse order
         */
        public void bubbleSort (int[] arr) {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++) {
                for (int j = 0; j < n - i - 1; j++) {
                    if (arr[j] > arr[j + 1]) {
                        // swap temp and arr[i] 
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        /**
         * If there is a value that is zero the change it to one in the array.
         */
        public int[, ] manipulateZeroValue (int[, ] array) {
            bool[] hasZero = new bool[array.GetLength (0)];
            for (int i = 0; i < array.GetLength (0); i++) {
                for (int j = 0; j < array.GetLength (1); j++) {
                    if (array[i, j] != 1) {
                        array[i, j] = 1;
                    }
                }
            }
            return array;
        }

        /**
         * Reverse an input array.
         */
        public int[] reverseArray (int[] array) {
            int count = 0;
            int[] reversed = new int [array.Length];
            for (int i = array.Length - 1; i > 0; i--) {
                reversed[count] = array[i];
                count++;
            } 
            return reversed;
        }

        public void swap(int[] array, int current, int next) {
            int temp = array[current];
            array[current] = array[next];
            array[next] = temp;
        }
    }
}