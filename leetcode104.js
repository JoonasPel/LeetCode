
function TreeNode(val, left, right) {
  this.val = (val===undefined ? 0 : val)
  this.left = (left===undefined ? null : left)
  this.right = (right===undefined ? null : right)
}

/**
 * @param {TreeNode} root
 * @return {number}
 */
var maxDepth = function(root) {
  const visit = (node, depth) => {
    maxDepth = Math.max(depth, maxDepth);
    if (node.left) { visit(node.left, depth+1); }
    if (node.right) { visit(node.right, depth+1); }
  };

  let maxDepth = 0;
  if (root) { visit(root, 1); } 
  return maxDepth;
};