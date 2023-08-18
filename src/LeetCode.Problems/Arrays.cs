namespace LeetCode.Problems;

public class Arrays
{
    /// <summary>
    /// https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/727/
    /// </summary>
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;

        var k = 0;
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[k]) continue;
            k++;
            nums[k] = nums[i];
        }

        return k + 1;
    }

    /// <summary>
    /// https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/564/
    /// </summary>
    public int MaxProfit(int[] prices)
    {
        if (prices.Length == 0) return 0;

        var profit = 0;
        var priceBuy = -1;

        for (var i = 0; i < prices.Length - 1; i++)
        {
            if (priceBuy == -1)
            {
                priceBuy = prices[i];
            }

            if (prices[i] > prices[i + 1])
            {
                profit += prices[i] - priceBuy;
                priceBuy = -1;
            }
        }

        if (priceBuy != -1) profit += prices[^1] - priceBuy;

        return profit;
    }

    /// <summary>
    /// https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/578/
    /// </summary>
    public bool ContainsDuplicate(int[] nums)
    {
        if (nums.Length == 0) return false;

        var uniqueValues = new HashSet<int>();
        foreach (var n in nums)
        {
            if (uniqueValues.Contains(n)) return true;
            uniqueValues.Add(n);
        }

        return false;
    }

    /// <summary>
    /// https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/559/
    /// </summary>
    public int[] PlusOne(int[] digits)
    {
        if (digits.Length == 0) return Array.Empty<int>();

        for (var i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }

            digits[i] = 0;
        }


        digits = new int[digits.Length + 1];
        digits[0] = 1;
        return digits;
    }

    /// <summary>
    /// https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/567/
    /// </summary>
    public void MoveZeroes(int[] nums)
    {
        int i = 0, j = 0;
        for (; i < nums.Length; i++)
        {
            if (nums[i] != 0) continue;

            if (j == 0) j = i + 1;
            for (; j < nums.Length; j++)
            {
                if (nums[j] != 0) break;
            }

            if (j == nums.Length) return;
            nums[i] = nums[j];
            nums[j] = 0;
        }
    }

    /// <summary>
    /// https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/769/
    /// </summary>
    public bool IsValidSudoku(char[][] board)
    {
        HashSet<char> uniques = new();
        for (var i = 0; i < 9; i++)
        {
            uniques.Clear();
            for (var j = 0; j < 9; j++)
            {
                if (board[i][j] == '.') continue;
                if (uniques.Contains(board[i][j])) return false;
                uniques.Add(board[i][j]);
            }

            uniques.Clear();
            for (var j = 0; j < 9; j++)
            {
                if (board[j][i] == '.') continue;
                if (uniques.Contains(board[j][i])) return false;
                uniques.Add(board[j][i]);
            }

            uniques.Clear();
            var si = (i % 3) * 3;
            var sj = (i / 3) * 3;
            for (var j = 0; j < 9; j++)
            {
                var ci = si + j % 3;
                var cj = sj + j / 3;

                if (board[ci][cj] == '.') continue;
                if (uniques.Contains(board[ci][cj])) return false;
                uniques.Add(board[ci][cj]);
            }
        }

        return true;
    }

    /// <summary>
    /// Rotate Image
    /// https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/770/
    /// </summary>
    public void Rotate(int[][] matrix)
    {
        var n = matrix.Length - 1;
        var m = (n > 1 ? n : 2) - 1;

        for (var d = 0; d < m; d++)
        {
            for (var i = d; i < n - d; i++)
            {
                var t = matrix[d][i];

                matrix[d][i] = matrix[n - i][d];
                matrix[n - i][d] = matrix[n - d][n - i];
                matrix[n - d][n - i] = matrix[i][n - d];
                matrix[i][n - d] = t;
            }
        }
    }
}
