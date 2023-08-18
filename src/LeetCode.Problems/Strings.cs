namespace LeetCode.Problems;

public class Strings
{
    /// <summary>
    /// https://leetcode.com/explore/interview/card/top-interview-questions-easy/127/strings/879/
    /// </summary>
    public void ReverseString(char[] s)
    {
        var j = s.Length - 1;
        for (int i = 0; i < s.Length / 2; i++, j--)
        {
            s[j] = (char)((short)s[j] + (short)s[i]);
            s[i] = (char)((short)s[j] - (short)s[i]);
            s[j] = (char)((short)s[j] - (short)s[i]);
        }
    }

    /// <summary>
    /// https://leetcode.com/explore/interview/card/top-interview-questions-easy/127/strings/881/
    /// </summary>
    public int FirstUniqChar(string s)
    {
        ushort aPos = 'a';
        var charIndex = new int['z' - aPos + 1];
        for (int i = 0; i < charIndex.Length; i++)
        {
            charIndex[i] = -2;
        }

        for (int i = 0; i < s.Length; i++)
        {
            var p = s[i] - aPos;
            if (charIndex[p] == -2)
            {
                charIndex[p] = i;
            }
            else if (charIndex[s[i] - aPos] != -1)
            {
                charIndex[p] = -1;
            }
        }

        var min = s.Length;
        foreach (int indexOf in charIndex)
        {
            if (indexOf > -1)
            {
                min = Math.Min(min, indexOf);
            }
        }

        return min == s.Length ? -1 : min;
    }

    /// <summary>
    /// https://leetcode.com/explore/interview/card/top-interview-questions-easy/127/strings/884/
    /// </summary>
    public int MyAtoi(string s)
    {
        const string digits = "0123456789";
        var result = 0;
        var isPositive = true;
        var enumerator = s.GetEnumerator();
        var hasNext = enumerator.MoveNext();

        while (hasNext && enumerator.Current == ' ')
        {
            hasNext = enumerator.MoveNext();
        }

        while (hasNext && (enumerator.Current == '-' || enumerator.Current == '+'))
        {
            isPositive = enumerator.Current == '+';
            hasNext = enumerator.MoveNext();
            break;
        }

        try
        {
            while (hasNext && digits.Contains(enumerator.Current))
            {
                var nextDigit = byte.Parse(enumerator.Current.ToString());
                checked
                {
                    result *= 10;
                    result += nextDigit;
                }

                hasNext = enumerator.MoveNext();
            }
        }
        catch (OverflowException)
        {
            return isPositive ? int.MaxValue : int.MinValue;
        }

        if (!isPositive)
        {
            result = 0 - result;
        }

        return result;
    }

    /// <summary>
    /// https://leetcode.com/explore/interview/card/top-interview-questions-easy/127/strings/885/
    /// </summary>
    public int StrStr(string haystack, string needle)
    {
        if (needle.Length > haystack.Length || needle.Length == 0) return -1;

        for (int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            if (haystack[i] == needle[0])
            {
                if (needle.Length == 1) return i;
                for (int j = 1; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        break;
                    }
                    else if (j == needle.Length - 1)
                    {
                        return i;
                    }
                }
            }
        }

        return -1;
    }
}
