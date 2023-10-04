/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} head
 * @param {number} k
 * @return {ListNode}
 */
var reverseKGroup = function(head, k) {
  const reverseLinkedList = (head) => {
      if (!head) { return [null, null]; }
      if (!head.next) { return [head, head]; }
      let current = head.next;
      head.next = null;
      let prev = head;
      const originalHead = head;
      while (current) {
          let next = current.next;
          current.next = prev;
          prev = current;
          current = next;
      }
      return [prev, originalHead];
  };

  let [current, tempHead] = [head, head];
  let [finalHead, prevTail] = [null, null];
  let tempK = 0;
  while (current) {
      tempK++;
      if (tempK % k !== 0) {
          current = current.next;
      } else {
          let next = current.next;
          current.next = null;
          let [head, tail] = reverseLinkedList(tempHead);
          if (!finalHead) { finalHead = head; }
          if (prevTail) { prevTail.next = head; }
          prevTail = tail;
          [tempHead, tail.next, current] = [next, next, next];
      }
  }
  return finalHead;
};
