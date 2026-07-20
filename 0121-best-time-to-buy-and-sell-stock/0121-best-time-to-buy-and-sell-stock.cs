public class Solution {
    public int MaxProfit(int[] prices) {
        int minimumprofit =  prices[0];
        int maxProfit = 0;
        for(int i=0;i<prices.Length;i++){
          if(prices[i]<minimumprofit){
            minimumprofit = prices[i];
             
          }
          int profit =  prices[i] -  minimumprofit;
          if(profit > maxProfit){
             maxProfit = profit;
          }
        }
        return maxProfit;
    }
}