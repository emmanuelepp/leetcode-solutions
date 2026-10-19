// Time: O((m+n) log(m+n))
// Space: O(log(m+n))
// Problem No: 88
public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {

        for (int i = 0; i < nums2.Length; i++)
        {
            nums1[m + i] = nums2[i];
        }

        Array.Sort(nums1);
    }
}