function ListNode(val, next) {
  this.val = (val===undefined ? 0 : val);
  this.next = (next===undefined ? null : next);
  return this;
}

/**
 * @param {ListNode} head
 * @return {ListNode}
 */
var reverseList = function(head) {
  if (!head || !head.next) {return head; }
  let [prev, current, next] = [head, head.next, undefined];
  head.next = null;
  while(current) {
    next = current.next;
    current.next = prev;
    prev = current;
    current = next;
  }
  return prev;
}


let x = new ListNode(5, undefined);
let x1 = new ListNode(4, x);
let x2 = new ListNode(3, x1);
let x3 = new ListNode(2, x2);
let x4 = new ListNode(1, x3);

reverseList(x4);
