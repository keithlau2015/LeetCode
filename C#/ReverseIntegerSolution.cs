//04/06/2022
//https://leetcode.com/problems/reverse-integer/

//Question
//Input: x = 123
//Output: 321

//Input: x = -123
//Output: -321

//Input: x = 120
//Output: 21

//Input: x = 1534236469
//Output: 0

//Runtime: 21 ms, faster than 93.78% of C# online submissions for Reverse Integer.
//Memory Usage: 27 MB, less than 20.54% of C# online submissions for Reverse Integer
public class ReverseIntegerSolution {
    public int Reverse(int x) {
        string tmp = x.ToString();
        bool isNegative = false;
        if(x < 0){
            tmp = tmp.Substring(1);
            isNegative = true;
        }
        char[] tmpCharArray = tmp.ToCharArray();
        Array.Reverse(tmpCharArray);
        tmp = new string(tmpCharArray);
        int result = 0;
        int.TryParse(tmp, out result);
        if(isNegative)
            result *= -1;
        return result;
    }
}