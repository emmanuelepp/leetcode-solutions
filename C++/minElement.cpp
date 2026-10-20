// Time: O(n)
// Space: O(1)
// Problem No: 3300

#include <climits>
#include <vector>

class Solution {
public:
    int minElement(std::vector<int>& nums) {

        int min = INT_MAX;

        for(int i = 0; i < nums.size(); i++)
        {
            int n = nums[i];
            int sum = 0;

            while(n > 0)
            {
                int digit = n % 10;
                sum += digit;
                n /= 10;
            }

            if(min > sum) min = sum; 
        }

        return min;
    }
};