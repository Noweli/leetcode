using FluentAssertions;

namespace LeetCode.Tests;

[TestFixture]
public class LeetCode1Tests
{
    [TestCase(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [TestCase(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [TestCase(new[] { 3, 3 }, 6, new[] { 0, 1 })]
    public void TwoSum_ReturnExpected(int[] nums, int target, int[] expected)
    {
        //Act
        var result = LeetCode1.TwoSum(nums, target);

        //Assert
        result.Should().BeEquivalentTo(expected);
    }
}