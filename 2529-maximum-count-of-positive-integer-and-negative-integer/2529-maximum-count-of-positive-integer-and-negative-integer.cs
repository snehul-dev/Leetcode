public class Solution {
    public int MaximumCount(int[] nums) {
      int neg = 0;
      int pos = 0;
        for(int i = 0;i<nums.Length;i++){
            if(nums[i]< 0){
                neg++;
            }else if(nums[i]>0){
                pos++;
            }

        }

        if(neg > pos){
            return neg;
        }else{
            return pos;
        }
        
    }
}