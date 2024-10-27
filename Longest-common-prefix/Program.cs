public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0) return "";

        // Ініціалізуємо префікс першим рядком
        string prefix = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            // Скорочуємо префікс, доки він не стане спільним з поточним рядком
            while (strs[i].IndexOf(prefix) != 0)
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (prefix == "") return ""; // якщо префікс став порожнім, вихід
            }
        }

        return prefix;
    }
}
