namespace algorithms
{
    public class TreeNode
    {
        int key;
        TreeNode parent;
        TreeNode leftChild;
        TreeNode rightChild;

        public TreeNode (int key) {
            this.key = key;
            parent = null;
            leftChild = null;
            rightChild = null;
        }

        public int getKey() {
            return key;
        }

        public TreeNode getParent() {
            return parent;
        }

        public TreeNode getLeftChild() {
            return leftChild;
        }

        public TreeNode getRightChild() {
            return rightChild;
        }

        public void setParent(TreeNode parent) {
            this.parent = parent;
        }

        public void setLeftChild(TreeNode leftChild) {
            this.leftChild = leftChild;
        }

        public void setRightChild(TreeNode rightChild) {
            this.rightChild = rightChild;
        }
    }
}