// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable InconsistentNaming
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable NotAccessedField.Global
// ReSharper disable UnusedMember.Global
namespace LeetCode.Problems.Models;

public class ListNode
{
    public ListNode(int x)
    {
        val = x;
    }

    public int val;
    public ListNode? next;

    public static bool IsListEqual(ListNode? left, ListNode? right)
    {
        if (left == null || right == null) return left == right;

        return left.val == right.val && IsListEqual(left.next, right.next);
    }

    public static ListNode? Build(int[] values)
    {
        return Build(values, 0);
    }

    private static ListNode? Build(int[] values, int i)
    {
        if (i == values.Length) return null;

        var node = new ListNode(values[i])
        {
            next = Build(values, i + 1)!,
        };

        return node;
    }
}
