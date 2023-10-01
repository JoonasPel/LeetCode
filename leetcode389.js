/**
 * @param {string} s
 * @param {string} t
 * @return {character}
 */
var findTheDifference = function(s, t) {
  const alphabetHash = {
    a: 1, b: 8, c: 15, d: 21,
    e: 2, f: 9, g: 16, h: 22,
    i: 3, j: 10, k: 17, l: 23,
    m: 4, n: 11, o: 18, p: 24,
    q: 5, r: 12, s: 19, t: 25,
    u: 6, v: 13, w: 20, x: 26,
    y: 7, z: 14
  };
  const alphabetHashViceVersa = {
    1: 'a', 2: 'e', 3: 'i', 4: 'm',
    5: 'q', 6: 'u', 7: 'y', 8: 'b',
    9: 'f', 10: 'j', 11: 'n', 12: 'r',
    13: 'v', 14: 'z', 15: 'c', 16: 'g',
    17: 'k', 18: 'o', 19: 's', 20: 'w',
    21: 'd', 22: 'h', 23: 'l', 24: 'p',
    25: 't', 26: 'x'
  };
  const hasher = (str) => {
    return Array.from(str).reduce((acc, currCh) =>
      acc + alphabetHash[currCh], 0);
  };
  return alphabetHashViceVersa[hasher(t) - hasher(s)];
};

console.log(findTheDifference(s = "abcd", t = "abcdj"));