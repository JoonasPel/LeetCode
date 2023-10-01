/**
 * @param {number[]} citations
 * @return {number}
 */
var hIndex = function(citations) {
  citations.sort((a,b)=>b-a);

  for (var i=0; i<citations.length;) {
    i++;
    if (!(citations[i-1] >= i)) {
      i--;
      break;
    }
  }

  return i;
};

console.log(hIndex([3,0,6,1,5,4,3,3,4,5,5,11]));