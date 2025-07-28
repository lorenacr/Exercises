/*
* https://leetcode.com/problems/median-of-two-sorted-arrays/submissions/1714660344
*/
public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if (nums1.Length > nums2.Length)
            return FindMedianSortedArrays(nums2, nums1);

        int lengthOfFirst = nums1.Length;
        int lengthOfSecond = nums2.Length;

        int low = 0;
        int high = lengthOfFirst;

        while (low <= high)
        {
            int partitionFirst = (low + high) / 2;
            int partitionSecond = (lengthOfFirst + lengthOfSecond + 1) / 2 - partitionFirst;

            // Elements in partition borders
            int maxLeftFirst = (partitionFirst == 0) ? int.MinValue : nums1[partitionFirst - 1];
            int minRightFirst = (partitionFirst == lengthOfFirst) ? int.MaxValue : nums1[partitionFirst];

            int maxLeftSecond = (partitionSecond == 0) ? int.MinValue : nums2[partitionSecond - 1];
            int minRightSecond = (partitionSecond == lengthOfSecond) ? int.MaxValue : nums2[partitionSecond];

            // Checks whether partition is valid
            if (maxLeftFirst <= minRightSecond && maxLeftSecond <= minRightFirst)
            {
                // Case where total number of elements is even
                if ((lengthOfFirst + lengthOfSecond) % 2 == 0)
                {
                    return (Math.Max(maxLeftFirst, maxLeftSecond) + Math.Min(minRightFirst, minRightSecond)) / 2.0;
                }
                else // Total number of elementsis odd
                {
                    return Math.Max(maxLeftFirst, maxLeftSecond);
                }
            }
            else if (maxLeftFirst > minRightSecond)
            {
                // We are too far to the right in the first array
                high = partitionFirst - 1;
            }
            else
            {
                // We are too far to the left in the first array
                low = partitionFirst + 1;
            }
        }

        throw new ArgumentException("Input arrays are not sorted or invalid.");
    }
}



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
