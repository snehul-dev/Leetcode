public class Solution {
    public char SlowestKey(int[] releaseTimes, string keysPressed) {

        int maxduraton = releaseTimes[0];
        char answer = keysPressed[0];

        for(int i= 1;i<releaseTimes.Length;i++){
            int duration = releaseTimes[i]-releaseTimes[i-1];
            if(duration > maxduraton){
               maxduraton = duration;
                answer = keysPressed[i];
            }else if(maxduraton == duration && keysPressed[i]>answer){
                answer = keysPressed[i];
            }
        }
        return answer;
        
    }
}