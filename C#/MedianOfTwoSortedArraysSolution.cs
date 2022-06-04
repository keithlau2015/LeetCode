//29/05/2022
//https://leetcode.com/problems/median-of-two-sorted-arrays/

//Question
//Input: nums1 = [1,3], nums2 = [2]
//Output: 2.00000
//Explanation: merged array = [1,2,3] and median is 2.

//Runtime: 178 ms, faster than 16.55% of C# online submissions for Median of Two Sorted Arrays.
//Memory Usage: 39.8 MB, less than 53.00% of C# online submissions for Median of Two Sorted Arrays.

public class MedianOfTwoSortedArraysSolution {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
            int[] combined = nums1.Concat(nums2).ToArray();
            Array.Sort(combined);
            if(nums1.Length == nums2.Length){
                int index1 = (int)((nums1.Length + nums2.Length)/2 + 0.5);
                int index2 = (int)((nums1.Length + nums2.Length)/2 - 0.5);
                return (double)(combined[index1]+combined[index2])/2;
            }
            else if(nums1.Length == 0)
            {
                if(nums2.Length % 2 == 0){
                    int index1 = (int)((nums2.Length)/2 + 0.5);
                    int index2 = (int)((nums2.Length)/2 - 0.5);
                    return (double)(combined[index1]+combined[index2])/2;
                }
                else{
                    return (double)(combined[nums2.Length/2]);
                }
            }
            else if(nums2.Length == 0){
                if(nums1.Length % 2 == 0){
                    int index1 = (int)((nums1.Length)/2 + 0.5);
                    int index2 = (int)((nums1.Length)/2 - 0.5);
                    return (double)(combined[index1]+combined[index2])/2;
                }
                else{
                    return (double)(combined[nums1.Length/2]);
                }
            }
            else{
                if(combined.Length % 2 == 0){
                    int index1 = (int)((combined.Length)/2 + 0.5);
                    int index2 = (int)((combined.Length)/2 - 0.5);
                    return (double)(combined[index1]+combined[index2])/2;
                }
                else{
                    return (double)combined[(nums1.Length + nums2.Length)/2];
                }
            }
        }
    }