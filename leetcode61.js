function ListNode(val, next) {  
  this.val = (val===undefined ? 0 : val)
  this.next = (next===undefined ? null : next)
};

const printer = (current) => {
  while (current) {
    process.stdout.write(current.val.toString() + "->")
    current = current.next;
  }
  process.stdout.write(current + "\n");
};

/**
 * @param {ListNode} head
 * @param {number} k
 * @return {ListNode}
 */
var rotateRight = function(head, k) {
  if (!head || !head.next) { return head; }

  let current = head;
  nodeCount = 0;
  while (current) {
    nodeCount++;
    current = current.next;
  }
  let realK = nodeCount < k ? k % nodeCount : k;
  if (realK === 0 || realK === nodeCount) { return head; }

  let [originalHead, newHead, prev] = [head, null, null];
  const IdxtoSplit = nodeCount - realK;
  let nodeIdx = -1;
  current = head;
  while (current) {
    nodeIdx++;
    if (nodeIdx === IdxtoSplit) { 
      prev.next = null;
      newHead = current;
    }
    prev = current;
    current = current.next;
  }
  prev.next = originalHead;

  return newHead;
};

const autotest = () => {
  // create test set
  const vals = [1,2,3,4];
  let tempNext = null;
  for (let i=1; i<=vals.length; i++) {
    let newNode = new ListNode(vals.at(-i), tempNext);
    tempNext = newNode;
  }
  // "run test"
  let current = tempNext;
  printer(current);
  const head = rotateRight(tempNext, 4);
  printer(head);
};
autotest();