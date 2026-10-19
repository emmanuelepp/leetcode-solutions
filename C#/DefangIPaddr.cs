//O(n)
//O(n)
// Problem No: 1108
public class Solution
{
    public string DefangIPaddr(string address)
    {
        if (string.IsNullOrWhiteSpace(address)) return "";

        return string.Join(".", address).Replace(".", "[.]");
    }
}