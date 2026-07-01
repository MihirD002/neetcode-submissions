public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();
        foreach (int i in nums)
        {
            if (dict.ContainsKey(i))
            {
                dict[i]++;
            }
            else
            {
                dict.Add(i, 1);
            }
        }
        return [.. dict.
        OrderByDescending(pair => pair.Value).
        Take(k).
        Select(pair=>pair.Key)];
    }
}