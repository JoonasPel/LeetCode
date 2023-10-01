
function TreeNode(val, left, right) {
  this.val = (val===undefined ? 0 : val)
  this.left = (left===undefined ? null : left)
  this.right = (right===undefined ? null : right)
}

/**
 * @param {TreeNode} root
 * @param {number} targetSum
 * @return {boolean}
 */
var hasPathSum = function(root, targetSum) {
  let tempSum = 0;
  let goalFound = false;
  const visit = (node) => {
    const isLeaf = !node.left && !node.right;
    tempSum += node.val;
    if (isLeaf && tempSum === targetSum) { 
      goalFound = true;
      return;
    }
    if (!goalFound && node.left) { visit(node.left); }
    if (!goalFound && node.right) { visit(node.right); }
    tempSum -= node.val;
  };
  if (root) visit(root);
  return goalFound;
};

let node2 = new TreeNode(2);
let node3 = new TreeNode(3);
let root = new TreeNode(4, node2, node3);
console.log(hasPathSum(root, 5));