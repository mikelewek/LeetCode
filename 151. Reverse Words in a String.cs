public class Solution {
    public string ReverseWords(string s) {
        string[] words = s.Split(' ');
        StringBuilder output = new StringBuilder();
        for(int i = words.Length - 1; i >= 0; --i)
        {
            if (words[i] != "")
            {
                output.Append(words[i] + " ");
            }
        }

        return output.ToString().Trim();
    }
}
