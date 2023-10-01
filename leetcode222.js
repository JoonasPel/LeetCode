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
var countNodes = function(root) {
  let height = 0;
  let missingNodesCount = 0;
  let goalFound = false;

  const visit = (node, currHeight) => {
    currHeight++;
    if (currHeight === height) {
      if (node === null ) { 
        missingNodesCount++; 
        return;
      }
      else { goalFound = true; return; }
    } 
    if (!goalFound) visit(node.right, currHeight);
    if (!goalFound) visit(node.left, currHeight);
    currHeight--;
  };

  const findHeight = (node, height) => {
    height++;
    if (node.left) { height = findHeight(node.left, height); }
    return height;
  };

  if (root) { height = findHeight(root, 0); }
  if (root) visit(root, 0);
  const result = (Math.pow(2, height) - 1) - missingNodesCount;
  return result;
};