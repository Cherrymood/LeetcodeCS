public class Solution1464 {
    public int MaxProduct(int[] nums) {
        
        Array.Sort(nums);
        return (nums[nums.Length - 2]-1)*(nums[nums.Length - 1]-1);
    }
}