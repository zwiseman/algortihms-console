using System;

namespace algorithms
{
    public class algorithm
    {
        public algorithm() {}
        
        /**
         * Binary Search: break each array size in half until we find the number we
         * are looking for.
         */
        public bool binarySearch(int [] array, int number, int head, int tail) {
            int pos = head + ((tail - head) / 2 );

            if (pos > array.Length - 1) {
                return false;
            } else {
                if (number == array[pos]) {
                    return true;
                } else if (number <= array[pos]) {
                    return binarySearch(array, number, head, pos - 1); // search first half
                } else {
                    return binarySearch (array, number, pos + 1, tail);
                }
            }
        }

        /**
         * Find if the sum of a pair of values are in the array.
         */
        public bool sumInArray(int [] array, int sumValue) {
            return false;
        }
    }
}