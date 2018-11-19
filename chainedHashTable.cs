using System;
using System.Collections.Generic;

namespace algorithms {
    public class ChainedHashTable {
        Stack<int> stack = new Stack<int> ();
        Queue<int> queue = new Queue<int> ();
        LinkedList<int>[] hashTable;
        double A = 0.6180339887;
        int m;

        public ChainedHashTable (int n) {
            m = 1;
            while (m <= n) {
                m *= 2;
            }

            hashTable = new LinkedList<int>[m];

            for (int i = 0; i < hashTable.Length; i++) {
                hashTable[i] = new LinkedList<int> ();
            }
        }

        public void insert(int value) {
            hashTable[hash(value)].AddFirst(value);
        }

        public bool delete (int value) {
            return hashTable[hash(value)].Remove(value);
        }
        
        public LinkedList<int> search(int value) {
            bool isInTable = hashTable[hash(value)].Contains(value);
            if (isInTable == true) {
                return hashTable[hash(value)];
            }
            return null;
        }

        /**
         * Multiplicaiton method ot hash.
         */
        public int hash (int key) {
            double hash = m * ((key * A) % 1);
            return (int) hash;
        }
    }
}