// Time: O(n)
// Space O(1)

#include <vector>

class Solution {
public:
    std::vector<int> separateDigits(std::vector<int>& nums) {
           
        std::vector<int> arr;

        for(auto n : nums)
        {
            std::vector<int> tmp; 

            while(n > 0)
            {
                int digit = n % 10;

                tmp.insert(tmp.begin(),digit);

                n /= 10;
            }

           arr.insert(arr.end(), tmp.begin(), tmp.end()); 
        }

        return arr;
    }
};