/**
 * @param {number[]} salary
 * @return {number}
 */
var average = function(salary) {
  const salariesAmount = salary.length;
  if (salariesAmount < 3) {return -1;}

  let min = salary[0];
  let max = salary[0];
  let total = 0;
  for (let numb of salary) {
    total += numb;
    if (numb < min) {min=numb;}
    else if (numb > max) {max=numb;}
  }
  return (total - min - max) / (salariesAmount - 2);
};

console.log(average([4000,3000,1000,2000]));