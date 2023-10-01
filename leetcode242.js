/**
 * @param {string} s
 * @param {string} t
 * @return {boolean}
 */
var isAnagram = function(s, t) {
  const alphabetHash = {
    a: 194, b: 240, c: 364, d: 457,
    e: 526, f: 645, g: 775, h: 845,
    i: 946, j: 154, k: 243, l: 344,
    m: 455, n: 555, o: 645, p: 735,
    q: 867, r: 945, s: 445, t: 549,
    u: 645, v: 724, w: 845, x: 953,
    y: 166, z: 351
  };
  const hasher = (s) => {
    let hash = 0;
    for (let ch of s) {
      hash += alphabetHash[ch];
    }
    return hash;
  };
  return hasher(t) === hasher(s);
};