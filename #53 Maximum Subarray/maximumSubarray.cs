public class Solution {
    public int MaxSubArray(int[] nums) {
        for (int i = 1; i < nums.Length; i++)
            if (nums[i - 1] + nums[i] > nums[i])
                nums[i] += nums[i - 1];
        return nums.Max();
    }
}