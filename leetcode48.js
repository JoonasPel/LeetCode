/**
 * @param {number[][]} matrix
 * @return {void} Do not return anything, modify matrix in-place instead.
 */

const getColumn = (arr, columnIndex) => {
  return arr.map(row => row[columnIndex]);
};

var rotate = function(matrix, clockwise=true) {
  const columnsAmount = matrix.length;
  for (i=0; i<columnsAmount; i++) {
      let column = getColumn(matrix.slice(-columnsAmount), i);
      matrix.unshift(column.reverse());
  };
  matrix.splice(columnsAmount, columnsAmount);
  if (clockwise) {matrix.reverse()}
};