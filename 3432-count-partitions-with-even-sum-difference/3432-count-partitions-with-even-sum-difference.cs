public class Solution {
    public int CountPartitions(int[] nums) {
        int total = 0;
        foreach(int num in nums){
            total+=num;

        }
        if(total%2 == 0){
            return nums.Length-1;
        }
        return 0;
    }
}