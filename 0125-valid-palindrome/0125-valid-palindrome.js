/**
 * @param {string} s
 * @return {boolean}
 */
var isPalindrome = function(s) {
    let word = s.split(",").join("").toLowerCase().replace(/[^a-z0-9]/g,"")
   let revese =  word.split("").reverse().join("")

   if(word===revese){
    return true
   }
   else{
    return false
   }
};