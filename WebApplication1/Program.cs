using System;
class Solution {
    public int Reverse(int x) {
        if (x == int.MaxValue || x == int.MinValue) {
            return 0;
        } else {
            if (x<0) {
                x = x*(-1);
                int k = x.ToString().Length;
            }
        }
        return x;
    }
}

public class Program {
    public static void Main() {
        Solution solution = new Solution();
        solution.Reverse(-123);
    }
}