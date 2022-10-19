namespace chapter1;
class CH1o1
{
    public static bool hasDuplicateChars(string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            for (int j = i + 1; j < text.Length; j++)
            {
                if (text[i] == text[j])
                {
                    return true;
                }
            }
        }
        return false;
    }
}