# pylint: disable=C0115, C0116, C0103
"""
[*] DIFFICULTY: Easy
[*] QUESTION: 226. Invert Binary Tree

[*] DESCRIPTION:
Given the root of a binary tree, invert the tree, and return its root.

[*] INTUITION/APPROACH:
[*] TIME COMPLEXITY: O(n), n = amount of nodes
[*] THOUGHTS:
"""
from typing import Optional

class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

class Solution:
    def __recursive(self, node: Optional[TreeNode]):
        node.left, node.right = node.right, node.left
        if node.right:
            self.__recursive(node.right)
        if node.left:
            self.__recursive(node.left)

    def invertTree(self, root: Optional[TreeNode]) -> Optional[TreeNode]:
        if root:
            self.__recursive(root)
        return root

    # used for testing
    def __call__(self, params):
        method = [m for m in dir(self) if callable(getattr(self, m)) and not m.startswith("_")]
        assert len(method) == 1, f"Only one public method allowed. Found {len(method)}"
        return getattr(self, method[0])(*params)


solution = Solution()
# used for testing
def test(params, answer):
    result = solution(params)
    if result != answer:
        print(f"Got {result} expected {answer} with params:", *params)


if __name__ == "__main__":
    pass
