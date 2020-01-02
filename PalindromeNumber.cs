public class Solution {
    public bool IsPalindrome(int x) {
        string reverseX = string.Empty;
            string stringX = x.ToString();

            for (var i = 1; i <= stringX.Length; i++)
            {
                reverseX += stringX[stringX.Length - i];
            }

            if (stringX == reverseX)
            {
                return true;
            }

            return false;
    }
}
