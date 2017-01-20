public class Solution {
    public int MyAtoi(string str) {
        long ret = 0;
        if(String.IsNullOrEmpty(str)) {
            return (int)ret;
        }
        bool isNeg = false;
        int i = 0;
        while(i < str.Length) {
            if(str[i] == ' ') {
                ++i;
                continue;
            }
            if(str[i] == '-') {
                isNeg = true;
                ++i;
                break;
            }
            if(str[i] == '+') {
                isNeg = false;
                ++i;
                break;
            }
            break;
        }
        while(i < str.Length) {
            if(!Char.IsDigit(str[i])) {
                break;
            }
            ret = ret * 10 + str[i++] - '0';
            if(ret > Int32.MaxValue) {
                return isNeg ? Int32.MinValue : Int32.MaxValue;
            }
        }
        return isNeg ? -(int)ret : (int)ret;
    }
}
