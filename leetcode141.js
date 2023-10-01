function ListNode(val, next) {
  this.val = val;
  this.next = next;
};

/**
 * @param {ListNode} head
 * @return {boolean}
 */
var hasCycle = function(head) {
  let current = head;
  while(current) {
    if (current.val === -9) { return true; }
    current.val = -9;
    current = current.next;
  }
  return false;
};

let x = new ListNode(-4, null);
let x1 = new ListNode(0, x);
let x2 = new ListNode(2, x1);
let x3 = new ListNode(3, x2);
x.next = x2;

hasCycle(x3);

