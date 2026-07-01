public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            int remaining = target - numbers[i];
            int num = numbers[i];
            if (dict.ContainsKey(remaining))
            {
                return [ dict[remaining]+1, i+1];
            }
            dict[numbers[i]] = i;
        }
        return [];
    }
}