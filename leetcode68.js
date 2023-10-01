/**
 * @param {string[]} words
 * @param {number} maxWidth
 * @return {string[]}
 */
var fullJustify = function(words, maxWidth) {
  let result = [];
  const totalWords = words.length;
  
  let wordIndex = 0;
  while (wordIndex < totalWords) {
    let tempRow = [];
    let tempLength = 0;
    let wordCount = 0;
    while (wordIndex < totalWords) {
      const word = words[wordIndex];
      const len = word.length;
      if (tempLength + len < maxWidth + 1) {
        tempLength += len + 1;
        tempRow.push(word);
        wordCount++;
        wordIndex++;
      } else { break; } 
    }

    // stringifier
    if (wordCount === 1) {
      const spacesNeeded = maxWidth - (tempLength - 1);
      const word = tempRow[0] + ' '.repeat(spacesNeeded);
      result.push(word);
    } else {
      let [spacesNeeded, evenSpacesAmount, leftOverSpaces] = [0, 1, 0];
      if (wordIndex !== totalWords) {
        spacesNeeded = maxWidth - (tempLength - wordCount);
        evenSpacesAmount = Math.floor(spacesNeeded / (wordCount-1));
        leftOverSpaces = spacesNeeded % (wordCount-1);
      }
      let tempString = '';
      let i = -1;
      for (let word of tempRow) {
        i++;
        tempString += word;
        if (i < wordCount-1) {
          tempString += ' '.repeat(evenSpacesAmount);
          if (leftOverSpaces > 0) {
            leftOverSpaces--;
            tempString += ' ';
          }
        }
      }
      if (wordIndex === totalWords) {
        tempString += ' '.repeat(maxWidth - tempString.length);
      }
      result.push(tempString);
    }
  }
  return result;
};

console.log(fullJustify(["Science","is","what","we","understand","well","enough","to","explain","to","a","computer.","Art","is","everything","else","we","do"], 20));
console.log(fullJustify(["What","must","be","acknowledgment","shall","be"], maxWidth = 16));
console.log(fullJustify(["This", "is", "an", "example", "of", "text", "justification."], maxWidth = 16));