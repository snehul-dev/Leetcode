/**
 * @param {string} ransomNote
 * @param {string} magazine
 * @return {boolean}
 */
var canConstruct = function(ransomNote, magazine) {
   for(let char of ransomNote){
      if(magazine.includes(char)){
        magazine = magazine.replace(char,"")
      }else{
        return false
      }
   }
   return true
};