public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] ret = new int[2];
        Hashtable ht = new Hashtable();
        for(int i = 0; i < nums.Length; i++) {
            if(ht.ContainsKey(target - nums[i])) {
                ret[0] = ht[target-nums[i]];
                ret[1] = i;
                return ret;
            }else {
                ht[nums[i]] = i;
            }
        }
        return ret;
    }
}
