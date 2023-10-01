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
 * @param {number} x
 * @return {ListNode}
 */
var partition = function(head, x) {
  if (!head || !head.next) { return head; }

  let [earlierSmall, earlierLarge, firstLarge, firstSmall] = [null, null, null, null];
  let current = head;

  while (current) {
    const tempNext = current.next;
    current.next = null;
    if (current.val < x) {
      if (earlierSmall === null) {
        [firstSmall, earlierSmall] = [current, current];
      } else {
        [earlierSmall.next, earlierSmall] = [current, current];
      }
    } else {
      if (firstLarge === null) {
        [firstLarge, earlierLarge] = [current, current];
      } else {
        [earlierLarge.next, earlierLarge] = [current, current];
      }
    }
    current = tempNext;
  }
  // notice cases where there was only small or large values
  if (firstLarge && firstSmall) { 
    earlierSmall.next = firstLarge; 
  }
  return firstSmall ? firstSmall : firstLarge;
};

// create test set
const vals = [1,1];
let tempNext = null;
for (let i=1; i<=vals.length; i++) {
  let newNode = new ListNode(vals.at(-i), tempNext);
  tempNext = newNode;
}
// "run test"
let current = tempNext;
printer(current);
const head = partition(tempNext, 0);
printer(head);
