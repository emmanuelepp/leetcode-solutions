package main

//O(N)
//O(1)
// Problem No: 27
func removeElement(nums []int, val int) int {

	if len(nums) == 0 {
		return 0
	}

	n := 0

	for i := 0; i < len(nums); i++ {
		if nums[i] != val {
			nums[n] = nums[i]
			n++
		}
	}

	return n
}
