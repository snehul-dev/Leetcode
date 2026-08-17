public class Solution {
    public int CountCompleteDayPairs(int[] hours) {
        int count = 0;
           for(int i=0;i<hours.Length-1;i++){
              for(int j=i+1;j<hours.Length;j++){
                var sum = hours[i] + hours[j];
                if(sum % 24 == 0){
                count++;
            }
          }
           }
           return count;
    }
}