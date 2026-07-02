public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int remaining = target - nums[i];

            if (dict.ContainsKey(remaining))
            {
                return new int[] { dict[remaining], i };
            }
            dict[nums[i]] = i;
        }
        return new int[] { };
    }
}
