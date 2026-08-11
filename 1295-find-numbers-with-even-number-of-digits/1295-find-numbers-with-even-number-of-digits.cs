public class Solution {
    public int FindNumbers(int[] nums) {
        int count = 0;
     
        for(int i =0;i<nums.Length;i++){
            var digit = 0;
            while(nums[i]>0){
                
                nums[i] = nums[i]/10;
                digit++;
            }
            if(digit % 2 ==0){
                count++;
            }
       
        }
        return count;
    }
}