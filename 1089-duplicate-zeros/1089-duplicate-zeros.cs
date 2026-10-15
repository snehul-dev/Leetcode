public class Solution {
    public void DuplicateZeros(int[] arr) {
         int limit = arr.Length;
        int[] newArr = new int[limit];

       int j = 0;

        for(int i=0;i<limit;i++){
            newArr[j] = arr[i];
            j++;
            if(arr[i] == 0 && j<limit){
                newArr[j] = 0;
                j++;
            }

            if(j>=limit){
                break;
            }
        }

        for (int i = 0; i < limit; i++)
        {
            arr[i] = newArr[i];
        }
    }
}