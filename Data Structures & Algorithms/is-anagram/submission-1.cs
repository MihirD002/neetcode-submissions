public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var count = new int[26];

        foreach (char letter in s)
        {
            count[letter - 'a']++;
        }
        foreach (char letter in t)
        {
            count[letter - 'a']--;
        }

        foreach (int x in count)
        {
            if(x != 0)
            {
                return false;
            }
        }
        return true;
    }
}
