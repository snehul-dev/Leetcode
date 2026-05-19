/**
 * @param {number} num
 * @return {number}
 */
var addDigits = function(num) {
   while(num>=10){
    let sum = 0;
    let numbers = num.toString().split("")

    for(let digit of numbers){
        sum+=Number(digit)
    }
    num = sum
   }
   return num
};