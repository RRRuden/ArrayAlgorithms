using NUnit.Framework;
namespace ArrayAlgorithms.Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(new int[] { 5, 1, 5, 6 }, new int[] { 1, 5, 5, 6 })]
        [TestCase(new int[] { 5, 4, 3, 2, 1, 0 }, new int[] { 0, 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 1, 1 }, new int[] { 1, 1, 1 })]
        public void QuickSortTest(int[] array, int[] expectedResult)
        {
            Sorter.QuickSort(array);
            Assert.AreEqual(expectedResult, array);
        }
        [TestCase(new int[] { 5, 1, 5, 6, 0 }, new int[] { 1, 5, 5, 6, 0 }, 0, 1)]
        [TestCase(new int[] { 5, 4, 3, 2, 1, 0 }, new int[] { 5, 4, 1, 2, 3, 0 }, 2, 4)]
        [TestCase(new int[] { 5, 4, 3, 2, 1, 0 }, new int[] { 5, 4, 3, 0, 1, 2 }, 3, 5)]
        public void QuickSortWithBorderTest(int[] array, int[] expectedResult, int start, int end)
        {
            Sorter.QuickSort(array, start, end);
            Assert.AreEqual(expectedResult, array);
        }

        [Test]
        public void SwitchTest()
        {
            var array = new int[] { 5, 1, 5, 6 };
            array.Switch(1, 3);
            Assert.AreEqual(new int[] { 5, 6, 5, 1 }, array);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 5, 7 }, 5, 4)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 5, 7 }, 3, 2)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 5, 7 }, 10, -1)]
        public void BinarySearchTest(int[] array, int element, int expectedIndex)
        {
            Assert.AreEqual(expectedIndex, Searcher.BinarySearch(array, element));
        }
    }
}