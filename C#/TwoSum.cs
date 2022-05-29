//29/05/2022
//https://leetcode.com/problems/two-sum/

//Question
//Input: nums = [2,7,11,15], target = 9
//Output: [0,1]
//Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

//Runtime: 246 ms, faster than 30.76% of C# online submissions for Two Sum.
//Memory Usage: 43.1 MB, less than 54.45% of C# online submissions for Two Sum.
//Time complexity: O(n)O(n). We traverse the list containing nn elements only once. Each lookup in the table costs only O(1)O(1) time.
//Space complexity: O(n)O(n). The extra space required depends on the number of items stored in the hash table, which stores at most nn elements.

namespace TwoSum{
    public class Solution {
        public static int[] TwoSum(int[] nums, int target) {        
            Dictionary<int, int> map = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++){
                int tmp = target - nums[i];
                int result = 0;
                if(map.TryGetValue(tmp, out result)){
                    return new int[] {result, i};
                }
                map.TryAdd(nums[i], i); 
            }
            return new int[] {-1,-1};
        }
    }
}