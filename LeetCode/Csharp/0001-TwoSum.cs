/**
https://leetcode.com/problems/two-sum/submissions/1711420790
**/

using System.Collections.Generic;

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Thinking that target = nums[i] + y
        // Keys = nums[i] | Values = i 
        var alreadyProcessed = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++){
           if (alreadyProcessed.ContainsKey(target - nums[i])){
            return [i, alreadyProcessed[target - nums[i]]];
           }

           alreadyProcessed.TryAdd(nums[i], i);
        }

        return default;
    }
}