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

    /// <summary>
    /// Reverse Integer
    /// https://leetcode.com/explore/interview/card/top-interview-questions-easy/127/strings/880/
    /// </summary>
    public int Reverse(int x)
    {
        if (x is int.MinValue or int.MaxValue)
        {
            return 0;
        }

        var array = Math.Abs(x).ToString().ToCharArray();
        for (var i = 0; i < array.Length / 2; i++)
        {
            (array[i], array[^(i + 1)]) = (array[^(i + 1)], array[i]);
        }

        var str = new string(array);
        const string MAX_POS = "2147483647";
        const string MAX_NEG = "2147483648";

        if (str.Length == MAX_POS.Length)
        {
            switch (x)
            {
                case > 0 when str == MAX_POS:
                    return int.MaxValue;
                case > 0 when string.Compare(str, MAX_POS, StringComparison.Ordinal) > 0:
                    return 0;

                case < 0 when str == MAX_NEG:
                    return int.MinValue;
                case < 0 when string.Compare(str, MAX_NEG, StringComparison.Ordinal) > 0:
                    return 0;
            }
        }

        var r = int.Parse(array);

        return x > 0 ? r : -r;
    }

    /// <summary>
    /// https://leetcode.com/explore/interview/card/top-interview-questions-easy/127/strings/882/
    /// </summary>
    public bool IsAnagram(string s, string t)
    {
        const int A_IDX = 'a';
        const int Z_IDX = 'z';
        Span<int> counts = stackalloc int[Z_IDX - A_IDX + 1];
        foreach (var c in s)
        {
            counts[c - A_IDX]++;
        }

        foreach (var c in t)
        {
            counts[c - A_IDX]--;
        }

        foreach (var c in counts)
        {
            if (c != 0) return false;
        }

        return true;
    }

    /// <summary>
    /// https://leetcode.com/explore/interview/card/top-interview-questions-easy/127/strings/883/
    /// </summary>
    public bool IsPalindrome(string s)
    {
        var iLeft = 0;
        var iRight = s.Length - 1;
        while (iLeft < iRight)
        {
            if (!char.IsLetterOrDigit(s[iLeft]))
            {
                iLeft++;
                continue;
            }

            if (!char.IsLetterOrDigit(s[iRight]))
            {
                iRight--;
                continue;
            }

            if (char.ToLower(s[iLeft]) != char.ToLower(s[iRight]))
            {
                return false;
            }

            iLeft++;
            iRight--;
        }

        return true;
    }
}
