public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
         int left = 0;
        int sum = 0;
        int minLength = int.MaxValue;

        for (int right = 0; right < nums.Length; right++)
        {
            sum += nums[right];

            while (sum >= target)
            {
                int length = right - left + 1;

                minLength = Math.Min(minLength, length);

                sum -= nums[left];
                left++;
            }
        }

        return minLength == int.MaxValue ? 0 : minLength;
    }
}