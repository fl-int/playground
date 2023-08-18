using LeetCode.Problems;

namespace LeetCode.UnitTests;

public class ArraysTests
{
    [Fact]
    public void RemoveDuplicates0()
    {
        var arrays = new Arrays();
        var input = Array.Empty<int>();
        var actual = arrays.RemoveDuplicates(input);

        Assert.Equal(0, actual);
        Assert.Empty(input);
    }

    [Fact]
    public void RemoveDuplicates1()
    {
        var arrays = new Arrays();
        var input = new[] { 1, 1, 2 };
        var actual = arrays.RemoveDuplicates(input);

        Assert.Equal(2, actual);
        Assert.Equal(1, input[0]);
        Assert.Equal(2, input[1]);
    }

    [Fact]
    public void RemoveDuplicates2()
    {
        var arrays = new Arrays();
        var input = new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        var actual = arrays.RemoveDuplicates(input);

        Assert.Equal(5, actual);
        Assert.Equal(0, input[0]);
        Assert.Equal(1, input[1]);
        Assert.Equal(2, input[2]);
        Assert.Equal(3, input[3]);
        Assert.Equal(4, input[4]);
    }

    [Fact]
    public void MaxProfit0()
    {
        var arrays = new Arrays();
        var input = Array.Empty<int>();
        var actual = arrays.MaxProfit(input);

        Assert.Equal(0, actual);
        Assert.Empty(input);
    }

    [Fact]
    public void MaxProfit1()
    {
        var arrays = new Arrays();
        var input = new[] { 7, 1, 5, 3, 6, 4 };
        var actual = arrays.MaxProfit(input);

        Assert.Equal(7, actual);
    }

    [Fact]
    public void MaxProfit2()
    {
        var arrays = new Arrays();
        var input = new[] { 1, 2, 3, 4, 5 };
        var actual = arrays.MaxProfit(input);

        Assert.Equal(4, actual);
    }

    [Fact]
    public void MaxProfit3()
    {
        var arrays = new Arrays();
        var input = new[] { 7, 6, 4, 3, 1 };
        var actual = arrays.MaxProfit(input);

        Assert.Equal(0, actual);
    }

    [Fact]
    public void ContainsDuplicate0()
    {
        var arrays = new Arrays();
        var input = Array.Empty<int>();
        var actual = arrays.ContainsDuplicate(input);

        Assert.False(actual);
    }

    [Fact]
    public void ContainsDuplicate1()
    {
        var arrays = new Arrays();
        var input = new[] { 1, 2, 3, 1 };
        var actual = arrays.ContainsDuplicate(input);

        Assert.True(actual);
    }

    [Fact]
    public void ContainsDuplicate2()
    {
        var arrays = new Arrays();
        var input = new[] { 1, 2, 3, 4 };
        var actual = arrays.ContainsDuplicate(input);

        Assert.False(actual);
    }

    [Fact]
    public void ContainsDuplicate3()
    {
        var arrays = new Arrays();
        var input = new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
        var actual = arrays.ContainsDuplicate(input);

        Assert.True(actual);
    }

    [Fact]
    public void PlusOne0()
    {
        var arrays = new Arrays();
        var input = Array.Empty<int>();
        var actual = arrays.PlusOne(input);

        Assert.Empty(actual);
    }

    [Fact]
    public void PlusOne1()
    {
        var arrays = new Arrays();
        var input = new[] { 1, 2, 3, 1 };
        var actual = arrays.PlusOne(input);

        Assert.Equal(4, actual.Length);
        Assert.Equal(1, actual[0]);
        Assert.Equal(2, actual[1]);
        Assert.Equal(3, actual[2]);
        Assert.Equal(2, actual[3]);
    }

    [Fact]
    public void PlusOne2()
    {
        var arrays = new Arrays();
        var input = new[] { 4, 3, 2, 1 };
        var actual = arrays.PlusOne(input);

        Assert.Equal(4, actual.Length);
        Assert.Equal(4, actual[0]);
        Assert.Equal(3, actual[1]);
        Assert.Equal(2, actual[2]);
        Assert.Equal(2, actual[3]);
    }

    [Fact]
    public void PlusOne3()
    {
        var arrays = new Arrays();
        var input = new[] { 9 };
        var actual = arrays.PlusOne(input);

        Assert.Equal(2, actual.Length);
        Assert.Equal(1, actual[0]);
        Assert.Equal(0, actual[1]);
    }

    [Fact]
    public void MoveZeroes0()
    {
        var arrays = new Arrays();
        var input = Array.Empty<int>();
        arrays.MoveZeroes(input);

        Assert.Empty(input);
    }

    [Fact]
    public void MoveZeroes1()
    {
        var arrays = new Arrays();
        var input = new[] { 0, 1, 0, 3, 12 };
        arrays.MoveZeroes(input);

        Assert.Equal(5, input.Length);
        Assert.Equal(new[] { 1, 3, 12, 0, 0 }, input);
        Assert.NotEqual(new[] { 0, 1, 0, 3, 12 }, input);
    }

    [Fact]
    public void IsValidSudoku0()
    {
        var arrays = new Arrays();
        var input = new[]
        {
            new[] { '5', '3', '.',  '.', '7', '.',  '.', '.', '.' },
            new[] { '6', '.', '.',  '1', '9', '5',  '.', '.', '.' },
            new[] { '.', '9', '8',  '.', '.', '.',  '.', '6', '.' },

            new[] { '8', '.', '.',  '.', '6', '.',  '.', '.', '3' },
            new[] { '4', '.', '.',  '8', '.', '3',  '.', '.', '1' },
            new[] { '7', '.', '.',  '.', '2', '.',  '.', '.', '6' },

            new[] { '.', '6', '.',  '.', '.', '.',  '2', '8', '.' },
            new[] { '.', '.', '.',  '4', '1', '9',  '.', '.', '5' },
            new[] { '.', '.', '.',  '.', '8', '.',  '.', '7', '9' },
        };

        var isValid = arrays.IsValidSudoku(input);

        Assert.True(isValid);
    }

    [Fact]
    public void IsValidSudoku1()
    {
        var arrays = new Arrays();
        var input = new[]
        {
            new[] { '8', '3', '.', '.', '7', '.', '.', '.', '.' },
            new[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
            new[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
            new[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
            new[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
            new[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
            new[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
            new[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
            new[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' },
        };

        var isValid = arrays.IsValidSudoku(input);

        Assert.False(isValid);
    }

    [Fact]
    public void IsValidSudoku2()
    {
        var arrays = new Arrays();
        var input = new[]
        {
            new[] { '.', '.', '.', '.', '5', '.', '.', '1', '.' },
            new[] { '.', '4', '.', '3', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '.', '.', '.', '3', '.', '.', '1' },
            new[] { '8', '.', '.', '.', '.', '.', '.', '2', '.' },
            new[] { '.', '.', '2', '.', '7', '.', '.', '.', '.' },
            new[] { '.', '1', '5', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '.', '.', '.', '2', '.', '.', '.' },
            new[] { '.', '2', '.', '9', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '4', '.', '.', '.', '.', '.', '.' },
        };

        var isValid = arrays.IsValidSudoku(input);

        Assert.False(isValid);
    }

    [Fact]
    public void RotateImage_Test1()
    {
        var arrays = new Arrays();
        var matrix = new[]
        {
            new[] { 1, 2 },
            new[] { 3, 4 },
        };
        var expected = new[]
        {
            new[] { 3, 1 },
            new[] { 4, 2 }
        };
        arrays.Rotate(matrix);

        for (var i = 0; i < matrix.Length; i++)
        {
            var m = matrix[i];
            var e = expected[i];

            Assert.True(e.SequenceEqual(m));
        }
    }

    [Fact]
    public void RotateImage_Test2()
    {
        var arrays = new Arrays();
        var matrix = new[]
        {
            new[] { 1, 2, 3 },
            new[] { 4, 5, 6 },
            new[] { 7, 8, 9 }
        };
        var expected = new[]
        {
            new[] { 7, 4, 1 },
            new[] { 8, 5, 2 },
            new[] { 9, 6, 3 }
        };
        arrays.Rotate(matrix);

        for (var i = 0; i < matrix.Length; i++)
        {
            var m = matrix[i];
            var e = expected[i];

            Assert.True(e.SequenceEqual(m));
        }
    }

    [Fact]
    public void RotateImage_Test3()
    {
        var arrays = new Arrays();
        var matrix = new[]
        {
            new[] { 5, 1, 9, 11 },
            new[] { 2, 4, 8, 10 },
            new[] { 13, 3, 6, 7 },
            new[] { 15, 14, 12, 16 },
        };
        var expected = new[]
        {
            new[] { 15, 13, 2, 5 },
            new[] { 14, 3, 4, 1 },
            new[] { 12, 6, 8, 9 },
            new[] { 16, 7, 10, 11 }
        };
        arrays.Rotate(matrix);

        for (var i = 0; i < matrix.Length; i++)
        {
            var m = matrix[i];
            var e = expected[i];

            Assert.True(e.SequenceEqual(m));
        }
    }
}
