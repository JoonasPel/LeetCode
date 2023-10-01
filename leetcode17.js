/**
 * @param {string} digits
 * @return {string[]}
 */
var letterCombinations = function(digits) {
    const chars = new Map();
    chars.set('2', ['a', 'b', 'c']);
    chars.set('3', ['d', 'e', 'f']);
    chars.set('4', ['g', 'h', 'i']);
    chars.set('5', ['j', 'k', 'l']);
    chars.set('6', ['m', 'n', 'o']);
    chars.set('7', ['p', 'q', 'r', 's']);
    chars.set('8', ['t', 'u', 'v']);
    chars.set('9', ['w', 'x', 'y', 'z']);

    // initialize result array by calculating how many combinations there will be
    let combinations = 1;
    for (let digit of digits) {
      if (digit === '7' || digit === '9') {
        combinations *= 4;
      } else {
        combinations *= 3;
      }
    }
    
    let result = new Array(combinations).fill('');
    let factor = combinations;
    let x;
    let y = -1;
    for (let digit of digits) {
      y++;
      
      if (digit === '7' || digit === '9') {
        factor /= 4;
        x = 4;
      } else {
        factor /= 3;
        x = 3;
      }
      let index = -1;
      for (let character of chars.get(digit)) {
        index++;
        index += (y*x);
        for (let i=0; i<combinations/x; i++) {
          result[index+(factor*i)] = result[index+(factor*i)] + character;
          
        }

      }
    }


};

console.log(letterCombinations("23"));