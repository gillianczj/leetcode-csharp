public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length < 2) {
            return s.Length;
        }
        int start = -1, len = 0;
        int[] locs = new int[256];
        for(int i = 0; i < 256; i++) {
            locs[i] = -1;
        }
        for(int end = 0; end < s.Lenght; end++) {
            if(locs[s[end]] > start) {
                start = locs[s[end]];
            }
            len = Math.Max(len, end - start);
            locs[s[end]] = end;
        }
        return len;
    }
}
