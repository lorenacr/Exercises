/**
* https://leetcode.com/problems/longest-substring-without-repeating-characters/submissions/1712200192
*/
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var maxLength = 0;
        var hashSet = new HashSet<char>();
        var duplicatedIndex = 0;

        for (int i = 0; i < s.Length; i++){
            while(hashSet.Contains(s[i])){
                hashSet.Remove(s[duplicatedIndex++]);
            }

            hashSet.Add(s[i]);
            maxLength = Math.Max(hashSet.Count, maxLength);
        }

        return maxLength;
    }
}


/**
* https://leetcode.com/problems/longest-substring-without-repeating-characters/submissions/1712181095
*/
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var maxLength = 0;
        var charDictionary = new Dictionary<char, int>();

        var temporaryLength = 0;
        for (int i = 0; i < s.Length; i++){
            var added = charDictionary.TryAdd(s[i], i);
            if (added == true){
                temporaryLength++;
            }
            else {
                i = charDictionary[s[i]];
                temporaryLength = 0;
                charDictionary.Clear();
                continue;
            }

            if (temporaryLength > maxLength) {
                maxLength = temporaryLength;
            }
        }

        return maxLength;
    }
}
