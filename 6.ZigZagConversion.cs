public class Solution {
    public string Convert(string s, int numRows) {
        if(s.Length <= 2 || s.Length <= numRows || numRows == 1) {
            return s;
        }
        StringBuilder[] lines = new StringBuilder[numRows];
        for(int i = 0; i < numRows; i++) {
            lines[i] = new StringBuilder();
        }
        int idx = -1;
        int inc = 1;
        foreach(char c in s) {
            idx += inc;
            lines[idx].Append(c);
            if(idx == 0) {
                inc = 1;
            }else if(idx == numRows - 1) {
                inc = -1;
            }
        }
        StringBuilder ret = new StringBuilder();
        foreach(var ele in lines) {
            ret.Append(ele);
        }
        return ret.ToString();
    }
}
