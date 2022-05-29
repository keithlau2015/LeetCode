//29/05/2022
//Runtime: 246 ms, faster than 30.76% of C# online submissions for Two Sum.
//Memory Usage: 43.1 MB, less than 54.45% of C# online submissions for Two Sum.

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

    public static void Main(string[] args){
        int[] testCase = {2,7,11,15};
        int target = 26;

        bool isFirst = true;
        Console.Write("Output: [");
        foreach (var item in TwoSum(testCase, target))
        {
            if(isFirst){
                isFirst = false;
            }
            else{
                Console.Write(", ");
            }
            Console.Write($"{item}");
        }
        Console.WriteLine("]");
    }
}