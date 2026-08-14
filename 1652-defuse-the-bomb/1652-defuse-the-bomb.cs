public class Solution {
    public int[] Decrypt(int[] code, int k) {
        int n = code.Length;
        int[] result = new int[n];
        for(int i=0;i<n;i++){
            if(k == 0){
                result[i] = 0;
            }
            else if (k > 0){
                      int sum = 0;
                for(int j =1;j<=k;j++){
                    sum+=code[(i+j)%n];
                }
                result[i] = sum;
            }else if (k<0){
                var count = 0;
                for(int x = 1;x <= -k;x++ ){
                   count+=code[(i-x + n)%n];
                }
                result[i] = count;
            }
        }
        return result;
    }
}