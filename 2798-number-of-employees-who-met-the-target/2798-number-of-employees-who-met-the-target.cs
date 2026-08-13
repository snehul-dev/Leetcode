public class Solution {
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target) {
        int sum = 0;
        for(int i =0;i<hours.Length;i++){
            if(hours[i] >= target){
                sum++;
            }
        }
        return sum;
    }
}