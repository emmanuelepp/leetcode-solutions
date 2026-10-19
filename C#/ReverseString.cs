//O(n)
//O(1)
// Problem No: 344
public class Solution
{
    public void ReverseString(char[] s)
    {

        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            (s[left], s[right]) = (s[right--], s[left++]);
        }

    }
}