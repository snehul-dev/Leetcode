public class Solution {
    public int MaxProduct(int[] nums) {
        Array.Sort(nums);
        int Largest = nums[nums.Length-1];
        int SecondLargest = nums[nums.Length-2];
        return (Largest-1)* (SecondLargest-1);
    }
}