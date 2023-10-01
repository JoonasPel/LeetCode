/**
 * @param {string[]} strs
 * @return {string[][]}
 */
var groupAnagrams = function(strs) {
  const alphabetHash = {
    a: 1899104, b: 2755540, c: 3374564, d: 4146457,
    e: 5246546, f: 6528245, g: 7235675, h: 8745645,
    i: 9824646, j: 1114654, k: 2277343, l: 3395744,
    m: 4145645, n: 5585645, o: 6225645, p: 7437435,
    q: 8777567, r: 9235645, s: 4314645, t: 5375649,
    u: 6995345, v: 7643424, w: 8374645, x: 9885453,
    y: 1934566, z: 3547451
  };
  
  const hasher = (str) => {
    let hash = 0;
    for (let ch of str) {
      hash += alphabetHash[ch];
    }
    return hash
  };

  let result = new Map();
  for (let word of strs) {
    let key = hasher(word);
    if (result.get(key) === undefined) {
      result.set(key, [word])
    } else {
      result.get(key).push(word);   
    }
  }
  return Array.from(result.values());
};

console.log(groupAnagrams(["eat","tea","tan","ate","nat","bat"]));