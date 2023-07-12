public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int startindex = 0;
        do
        {
            for (int i = 1; i < nums.Length; i++)
            {
                if (startindex!=i && nums[startindex] + nums[i] == target)
                {
                    return new int[] { startindex, i };
                }
            }
            startindex++;
        } while (startindex < nums.Length);
        return null;
}
}