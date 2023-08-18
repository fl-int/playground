using LeetCode.Problems;

namespace LeetCode.UnitTests;

public class SearchTests
{
    [Fact]
    public void BinarySearch1()
    {
        var search = new Search();
        var input = Array.Empty<int>();
        var actual = search.BinarySearch(input, 0);

        Assert.Equal(-1, actual);
        Assert.Empty(input);
    }

    [Fact]
    public void BinarySearch2()
    {
        var search = new Search();
        var input = new[] { -1, 0, 3, 5, 9, 12 };
        var actual = search.BinarySearch(input, 9);

        Assert.Equal(4, actual);
    }

    [Fact]
    public void BinarySearch3()
    {
        var search = new Search();
        var input = new[] { 1, 0, 3, 5, 9, 12 };
        var actual = search.BinarySearch(input, 2);

        Assert.Equal(-1, actual);
    }
}
