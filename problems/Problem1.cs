
namespace leetcode.problems
{
    internal static class Problem1
    {
        public static string MergeAlternately(string word1, string word2)
        {
            string result = "";
            int minWord = Math.Min(word1.Length, word2.Length);

            for (int i = 0; i < minWord; i++)
            {
                result += word1[i].ToString() + word2[i].ToString();
            }
            if (word1.Length > minWord)
            {
                result += word1.Substring(minWord);
                return result;
            }
            else if (word2.Length > minWord)
            {
                result += word2.Substring(minWord);
                return result;
            }
            return result;

        }
    }
}
