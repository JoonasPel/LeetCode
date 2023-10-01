function ListNode(val, next) {  
  this.val = (val===undefined ? 0 : val)
  this.next = (next===undefined ? null : next)
}

const printer = (current) => {
  while (current) {
    process.stdout.write(current.val.toString() + "->")
    current = current.next;
  }
  process.stdout.write(current + "\n");
}

/**
 * @param {ListNode} head
 * @return {ListNode}
 */
var deleteDuplicates = function(head) {
  if (!head || !head.next) { return head; }

  let [current, prevVal, newHead, tempHead] = [head, null, null, null];
  while (current) {
    const next = current.next;
    current.next = null;
    if (prevVal !== current.val && next?.val !== current.val ) {
      if (newHead) {
        [tempHead.next, tempHead] = [current, current];
      } else {
        [newHead, tempHead] = [current, current];
      }
    }
    prevVal = current.val;
    current = next;
  }
  return newHead;
};

// create test set
const vals = [1,1,2,3,3,4,4,5,5];
let tempNext = null;
for (let i=1; i<=vals.length; i++) {
  let newNode = new ListNode(vals.at(-i), tempNext);
  tempNext = newNode;
}
// "run test"
let current = tempNext;
printer(current);
const head = deleteDuplicates(tempNext, 0);
printer(head);