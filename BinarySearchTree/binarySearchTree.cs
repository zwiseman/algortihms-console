using System;

namespace algorithms {
    public class BinarySearchTree {
        TreeNode root;
        int size;

        public BinarySearchTree () {
            root = null;
            size = 0;
        }

        public TreeNode insert (TreeNode node) {
            TreeNode rootHolder = null;
            TreeNode x = this.root;

            while (x != null) {
                rootHolder = x;

                if (node.getKey () < x.getKey ()) {
                    x = x.getLeftChild ();
                } else {
                    x = x.getRightChild ();
                }
            }

            node.setParent (rootHolder);

            if (rootHolder == null) {
                this.root = node;
                size++;
            } else if (node.getKey () < rootHolder.getKey ()) {
                rootHolder.setLeftChild (node);
                size++;
            } else {
                rootHolder.setRightChild (node);
                size++;
            }
            return node;
        }

        public TreeNode search (int key) {
            return search (root, key);
        }

        private TreeNode search (TreeNode node, int key) {
            if (node == null) {
                return null;
            }

            if (key == node.getKey ()) {
                return node;
            }

            if (key < node.getKey ()) {
                return search (node.getLeftChild (), key);
            } else {
                return search (node.getRightChild (), key);
            }
        }

        public TreeNode minimum () {
            return minimum (root);
        }

        private TreeNode minimum (TreeNode node) {
            while (node.getLeftChild () != null) {
                node = node.getLeftChild ();
            }

            return node;
        }

        public TreeNode maximum () {
            return maximum (root);
        }

        private TreeNode maximum (TreeNode node) {
            while (node.getRightChild () != null) {
                node = node.getRightChild ();
            }

            return node;
        }

        public void preOrderTraversal () {
            preOrderTraversal (root);
        }

        private void preOrderTraversal (TreeNode node) {
            if (node != null) {
                Console.Write (node.getKey () + " ");
                preOrderTraversal (node.getLeftChild ());
                preOrderTraversal (node.getRightChild ());
            }
        }

        public void InOrderTraversal () {
            InOrderTraversal (root);
        }

        private void InOrderTraversal (TreeNode node) {
            if (node != null) {
                InOrderTraversal (node.getLeftChild ());
                Console.Write (node.getKey () + " ");
                InOrderTraversal (node.getRightChild ());
            }
        }

        public void postOrderTraversal () {
            postOrderTraversal (root);
        }

        private void postOrderTraversal (TreeNode node) {
            if (node != null) {
                postOrderTraversal (node.getLeftChild ());
                postOrderTraversal (node.getRightChild ());
                Console.Write (node.getKey () + " ");
            }
        }

        public int getSize () {
            return size;
        }

        public static void printBST (int [] arr) {
            for (int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i] + " ");
            }
        } //printMaxHeap
    }
}