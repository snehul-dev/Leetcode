public class Solution {
    public int PivotIndex(int[] nums) {
        int totalSum  = 0;

        for(int i = 0 ;i < nums.Length;i++){
            totalSum += nums[i];
        }

        int leftSum = 0;
        for(int i = 0;i<nums.Length;i++){
           int rightSum = totalSum - leftSum - nums[i];

           if(leftSum == rightSum){
              return i;
           }
           leftSum+=nums[i];
        }

        return -1;
    }
}