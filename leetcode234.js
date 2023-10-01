/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} head
 * @return {boolean}
 */
var isPalindrome = function(head) {
  let vals = new Array();
  current = head;
  while(current) {
    vals.push(current.val);
    current = current.next;
  }
  let [leftPtr, rightPtr] = [0, -1];
};