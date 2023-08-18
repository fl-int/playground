using LeetCode.Problems.Models;

namespace LeetCode.Problems;

public class LinkedList
{
    /// <summary>
    /// https://leetcode.com/explore/interview/card/top-interview-questions-easy/93/linked-list/553/
    /// </summary>
    public static void DeleteNode(ListNode node)
    {
        if (node.next == node) return;

        var next = node.next;
        node.val = next.val;
        node.next = next.next;
    }
}
