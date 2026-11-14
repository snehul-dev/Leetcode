public class Solution {
    public int MaxScore(string s) {
        int left = 0;
        int right = 0;
        int maxSum = 0;
        

       foreach(char c in s){
        if(c == '1'){
            right++;
        }

       
       }
               for(int i = 0 ;i<s.Length-1;i++){
            if(s[i] == '0'){
                left++;
            }else{
                right--;
            }

            int sum = left+right;
             maxSum = Math.Max(maxSum,sum);
        }
        return maxSum;
    }
}