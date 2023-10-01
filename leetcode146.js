function ListNode(val, next) {  
  this.val = val;
  this.next = (next===undefined ? null : next)
};

/**
 * @param {number} capacity
 */
var LRUCache = function(capacity) {
  this.size = 0;
  this.capacity = capacity;
  this.data = new Map();
  this.lruPseudoHead = new ListNode(-1, null);
  this.lruTail = null;
};

/** 
 * @param {number} key
 * @return {number}
 */
LRUCache.prototype.get = function(key) {
  let value = this.data.get(key);
  if (value) {
    const newTail = new ListNode(key, null); 
    this.lruTail.next = newTail;
    this.lruTail = newTail;
  }
  return value ? value : -1;
};

/** 
 * @param {number} key 
 * @param {number} value
 * @return {void}
 */
LRUCache.prototype.put = function(key, value) {
  this.data.set(key, value);
  this.size++;
  if (!this.lruTail) { 
    const newTail = new ListNode(key, null); 
    this.lruTail = newTail
    this.lruPseudoHead.next = newTail;
  } else { 
    const newTail = new ListNode(key, null);
    this.lruTail.next = newTail;
    this.lruTail = newTail;
  }
  if (this.size > this.capacity) {
    const keyToBeDeleted = this.lruPseudoHead?.next?.val;
    this.data.delete(keyToBeDeleted);
    this.lruPseudoHead.next = this.lruPseudoHead.next.next;
    this.size--;
  }
};


var cache = new LRUCache(2);
cache.put("1", 1);
cache.put("2", 2);
cache.get("1");
cache.put("3", 3);
console.log(cache.get("2"));



/** 
 * Your LRUCache object will be instantiated and called as such:
 * var obj = new LRUCache(capacity)
 * var param_1 = obj.get(key)
 * obj.put(key,value)
 */