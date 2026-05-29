/**
 * @param {number[]} nums
 * @param {number} k
 * @return {number}
 */
var absDifference = function(nums, k) {
    nums.sort((a,b)=>a-b)
let maxSum = 0
let minSum = 0
 
    for(let i=0;i<k;i++){
        minSum += nums[i]
    }
    for(let j=nums.length-1;j>=nums.length-k;j--){
        maxSum += nums[j]
    }
    let res = Math.abs(maxSum - minSum)
    return res
};