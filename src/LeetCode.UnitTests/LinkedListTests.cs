using LeetCode.Problems;
using LeetCode.Problems.Models;

namespace LeetCode.UnitTests;

public class LinkedListTests
{
    [Fact]
    public void DeleteNode1()
    {
        var linkedList = new LinkedList();
        var input = ListNode.Build(new[] { 4, 5, 1, 9 })!;
        LinkedList.DeleteNode(input.next);

        var expected = ListNode.Build(new[] { 4, 1, 9 })!;

        Assert.True(ListNode.IsListEqual(expected, input));
    }

    [Fact]
    public void DeleteNode2()
    {
        var linkedList = new LinkedList();
        var input = ListNode.Build(new[] { 4, 5, 1, 9 })!;
        LinkedList.DeleteNode(input.next.next);

        var expected = ListNode.Build(new[] { 4, 5, 9 })!;

        Assert.True(ListNode.IsListEqual(expected, input));
    }
}
