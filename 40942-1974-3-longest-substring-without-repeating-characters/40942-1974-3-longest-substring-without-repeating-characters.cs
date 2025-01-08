public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left = 0;
        int right =0;
        int maxLength = 0;
        HashSet<char> charSet = [];
        
        while(right < s.Length)
        {
            if(!charSet.Contains(s[right]))
            {
                charSet.Add(s[right]);
                right++;
                maxLength = Math.Max(maxLength, right - left);
            }
            else
            {
                charSet.Remove(s[left]);
                left++;
            }
        }
        return maxLength;
    }
}