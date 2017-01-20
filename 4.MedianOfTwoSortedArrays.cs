public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int m = nums1.Length;
        int n = nums2.Length;
        int total = m + n;
        if(total / 2 == 1) {
            return helper(nums1, 0, m - 1, nums2, 0, n - 1, total / 2 + 1);
        }else {
            return (helper(nums1, 0, m - 1, nums2, 0, n - 1, total / 2) + helper(nums1, 0, m - 1, nums2, 0, n - 1, total / 2 + 1)) / 2;
        }
    }
    private double helper(int[] nums1, int s1, int e1, int[] nums2, int s2, int e2, int k) {
        int size1 = e1 - s1 + 1;
        int size2 = e2 - s2 + 1;
        if(size1 > size2) {
            return helper(nums2, s2, e2, nums1, s1, e1, k);
        }
        if(size1 == 0) {
            return nums2[s2 + k - 1];
        }else if(k == 1) {
            return Math.Min(nums1[s1], nums2[s2]);
        }else {
            int l1 = Math.Min(k / 2, size1);
            int l2 = k - l1;
            if(nums1[s1 + l1 - 1] <= nums2[s2 + l2 - 1]) {
                return helper(nums1, s1 + l1, e1, nums2, s2, e2, k - l1);
            }else {
                return helper(nums1, s1, e1, nums2, s2 + l2, e2, k - l2);
            }
        }
    }
}
