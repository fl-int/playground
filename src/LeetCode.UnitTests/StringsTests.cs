using LeetCode.Problems;

namespace LeetCode.UnitTests;

public class StringsTests
{
    [Fact]
    public void ReverseString1()
    {
        var strings = new Strings();
        var s = "".ToCharArray();
        strings.ReverseString(s);

        Assert.Empty(s);
    }

    [Fact]
    public void ReverseString2()
    {
        var strings = new Strings();
        var s = "Hello".ToCharArray();
        strings.ReverseString(s);

        Assert.Equal(5, s.Length);
        Assert.Equal("olleH", new(s));
    }

    [Fact]
    public void ReverseString3()
    {
        var strings = new Strings();
        var s = "Hannah".ToCharArray();
        strings.ReverseString(s);

        Assert.Equal(6, s.Length);
        Assert.Equal("hannaH", new(s));
    }

    [Fact]
    public void FirstUniqChar1()
    {
        var strings = new Strings();
        var actual = strings.FirstUniqChar("");

        Assert.Equal(-1, actual);
    }

    [Fact]
    public void FirstUniqChar2()
    {
        var strings = new Strings();
        var actual = strings.FirstUniqChar("leetcode");

        Assert.Equal(0, actual);
    }

    [Fact]
    public void FirstUniqChar3()
    {
        var strings = new Strings();
        var actual = strings.FirstUniqChar("loveleetcode");

        Assert.Equal(2, actual);
    }

    [Fact]
    public void FirstUniqChar4()
    {
        var strings = new Strings();
        var actual = strings.FirstUniqChar("aabb");

        Assert.Equal(-1, actual);
    }

    [Fact]
    public void MyAtoi1()
    {
        var strings = new Strings();
        var actual = strings.MyAtoi("   ");

        Assert.Equal(0, actual);
    }

    [Fact]
    public void MyAtoi2()
    {
        var strings = new Strings();
        var actual = strings.MyAtoi("42");

        Assert.Equal(42, actual);
    }

    [Fact]
    public void MyAtoi3()
    {
        var strings = new Strings();
        var actual = strings.MyAtoi("   -42");

        Assert.Equal(-42, actual);
    }

    [Fact]
    public void MyAtoi4()
    {
        var strings = new Strings();
        var actual = strings.MyAtoi("4193 with words");

        Assert.Equal(4193, actual);
    }

    [Fact]
    public void MyStrStr1()
    {
        var strings = new Strings();
        var actual = strings.StrStr("sadbutsad", "sad");

        Assert.Equal(0, actual);
    }

    [Fact]
    public void MyStrStr2()
    {
        var strings = new Strings();
        var actual = strings.StrStr("leetcode", "leeto");

        Assert.Equal(-1, actual);
    }

    [Fact]
    public void MyStrStr3()
    {
        var strings = new Strings();
        var actual = strings.StrStr("leetcode", "");

        Assert.Equal(-1, actual);
    }

    [Fact]
    public void MyStrStr4()
    {
        var strings = new Strings();
        var actual = strings.StrStr("  ", "");

        Assert.Equal(-1, actual);
    }
}
