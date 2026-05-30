/**
 * @param {number[]} arr
 * @return {number}
 */
var findLucky = function(arr) {
    let obj = {}
  for(let num of arr){
    obj[num] = (obj[num]||0)+1
  }
  let result = -1
  for(let key in obj){
    if(Number(key) == obj[key]){
      
        result = Math.max(result,obj[key])
    }
  }
  return result 
};