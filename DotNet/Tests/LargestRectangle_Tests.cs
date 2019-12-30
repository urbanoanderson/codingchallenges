using NUnit.Framework;

namespace Challenges.LargestRectangle
{
    public class LargestRectangle_Tests
    {
        [TestCase(new int[] { 1 }, 1)]
        [TestCase(new int[] { 1, 2 }, 2)]
        [TestCase(new int[] { 2, 2 }, 4)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 9)]
        [TestCase(new int[] { 2, 10, 2 }, 10)]
        public void Tests(int[] h, long expected)
        {
            long result = LargestRectangle.GetMaxArea(h);
            Assert.IsTrue(result == expected);
        }
    }
}