/**
 * Definition for a binary tree node.
 * function TreeNode(val, left, right) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.left = (left===undefined ? null : left)
 *     this.right = (right===undefined ? null : right)
 * }
 */
/**
 * @param {TreeNode} root
 * @return {number}
 */
var sumNumbers = function(root) {
  let sum = 0;
  const visit = (node, numb) => {
    numb += node.val;
    const isLeaf = node?.left === null && node?.right === null;
    if (isLeaf) { sum += numb; }
    if (node.left) visit(node.left, numb*10);
    if (node.right) visit(node.right, numb*10);
  };

  if (root) visit(root, 0);
  return sum;
};