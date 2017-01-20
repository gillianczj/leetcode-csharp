public class Solution {
    public int Reverse(int x) {
        if(x / 10 == 0) {
            return x;
        }
        bool isNeg = x < 0 ? true : false;
        long y = Math.Abs((long)x);
        long ret = 0;
        while(y > 0) {
            long temp = y % 10;
            ret = ret * 10 + temp;
            y /= 10;
        }
        ret = isNeg ? -ret : ret;
        if(ret > Int32.MaxValue || ret < Int32.MinValue) {
            return 0;
        }
        return ret;
    }
}
