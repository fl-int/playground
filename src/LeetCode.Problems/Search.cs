namespace LeetCode.Problems;

public class Search
{
    /// <summary>
    /// https://leetcode.com/problems/binary-search/
    /// </summary>
    public int BinarySearch(int[] nums, int target)
    {
        if (nums.Length == 0) return -1;

        return SearchByMid(nums, target, 0, nums.Length - 1);
    }

    private int SearchByMid(int[] nums, int target, int startIndex, int endIndex)
    {
        if (startIndex == endIndex) return nums[startIndex] == target ? startIndex : -1;

        var mid = (startIndex + endIndex) / 2;

        if (nums[mid] == target) return mid;
        else if (nums[mid] > target) return SearchByMid(nums, target, startIndex, mid);
        else return SearchByMid(nums, target, mid + 1, endIndex);
    }
}
