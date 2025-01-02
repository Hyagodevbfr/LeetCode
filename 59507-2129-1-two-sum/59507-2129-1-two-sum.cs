public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var numDict = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];

            if(numDict.ContainsKey(complement)){
                return new int[]{numDict[complement], i};
            }

            numDict[nums[i]] = i;
        }

        return null;
    }

}