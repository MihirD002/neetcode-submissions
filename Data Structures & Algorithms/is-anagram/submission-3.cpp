class Solution
{
public:
    bool isAnagram(string s, string t)
    {
        if (s.length() != t.length())
            return false;

        int count[26] = {0};

        for (char letter : s)
        {
            count[letter - 'a']++;
        }

        for (char letter : t)
        {
            count[letter - 'a']--;
        }

        for (int x : count)
        {
            if (x != 0)
                return false;
        }
        return true;
    }
};
