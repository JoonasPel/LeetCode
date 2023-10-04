
const allGridsValid= (board) => {
  const gridAmount = board.length;
  for (i=0; i<gridAmount; i+=3) {
      for (j=0; j<gridAmount; j+=3){
          let tempRows = board.slice(i, i+3);
          let tempGrid = tempRows.map(row => row.slice(j, j+3));
          let numbersInGrid = tempGrid.map(row => row.filter(val => val != '.'));
          numbersInGrid = numbersInGrid.flat();
          if (new Set(numbersInGrid).size != numbersInGrid.length) {
              return false;
          }     
      }
  };
  return true
};
const allColumnsValid = (board) => {
  const columnsAmount = board.length;
  let tempColumn;
  let tempNumbers;
  for (i=0; i<columnsAmount; i++) {
      tempColumn = board.map(row => row[i]);
      tempNumbers = tempColumn.filter(val => val != '.');
      if (new Set(tempNumbers).size != tempNumbers.length) {
          return false;
      }
  };
  return true;
};
const allRowsValid = (board) => {
  let tempNumbers;
  for (let row of board) {
      tempNumbers = row.filter(val => val != '.');
      if (new Set(tempNumbers).size != tempNumbers.length) {
          return false;
      }
  }
  return true;
};

/**
* @param {character[][]} board
* @return {boolean}
*/
var isValidSudoku = function(board) {
  return allGridsValid(board) &&
      allColumnsValid(board) &&
      allRowsValid(board);
};