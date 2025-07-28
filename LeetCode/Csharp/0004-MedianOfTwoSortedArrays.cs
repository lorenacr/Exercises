/*
* https://leetcode.com/problems/median-of-two-sorted-arrays/submissions/1712600277
*/

public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        var totalLength = nums1.Length + nums2.Length;
        var mergedArray = new int[totalLength];
        
        nums1.CopyTo(mergedArray, 0);
        nums2.CopyTo(mergedArray, nums1.Length);

        Array.Sort(mergedArray);

        var count = mergedArray.Count();
        var middleIndex = count / 2;

        Console.WriteLine($"count: {count}");
        Console.WriteLine($"middleIndex: {middleIndex}");

        if (count % 2 != 0){
            return mergedArray[middleIndex];
        }
        
        return (double) ((mergedArray[middleIndex - 1] + 
        mergedArray[middleIndex]) / 2m);
    }
}
