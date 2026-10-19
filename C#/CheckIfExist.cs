//O(n)
//O(1)
// Problem No: 1346
public class Solution
{
    public bool CheckIfExist(int[] arr)
    {
        if (arr.Length == 0) return true;
        HashSet<int> set = new HashSet<int>();

        foreach (int num in arr)
        {
            if (set.Contains(num * 2) || (num % 2 == 0 && set.Contains(num / 2)))
            {
                return true;
            }
            set.Add(num);
        }
        return false;
    }
}
