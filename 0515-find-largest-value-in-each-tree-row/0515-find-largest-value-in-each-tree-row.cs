/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<int> LargestValues(TreeNode root)
    {
        IList<int> result = new List<int>();
        if (root == null)
        {
            return result;
        }
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;
            int max = int.MinValue;

            for (int i = 0; i < levelSize; i++)
            {
                var node = queue.Dequeue();

                max = Math.Max(max, node.val);


                if (node.left != null)
                    queue.Enqueue(node.left);

                if (node.right != null)
                    queue.Enqueue(node.right);

            }
            result.Add(max);
        }
        return result;
    }
}