using NUnit.Framework;
using System.Collections.Generic;
using MyMath;

namespace MyMath.Tests
{
    /// <summary>
    /// This class contains unit tests for the Operations class.
    /// </summary>
    public class OperationsTests
    {
        /// <summary>
        /// Tests that Max returns the maximum integer from a list of positive integers.
        /// </summary>
        [Test]
        public void Max_ListOfPositiveIntegers_ReturnsMax()
        {
            List<int> nums = new List<int> { 1, 5, 3, 9, 2 };
            int result = Operations.Max(nums);
            Assert.That(result, Is.EqualTo(9));
        }

        /// <summary>
        /// Tests that Max returns the maximum integer from a list of negative integers.
        /// </summary>
        [Test]
        public void Max_ListOfNegativeIntegers_ReturnsMax()
        {
            List<int> nums = new List<int> { -1, -5, -3, -9, -2 };
            int result = Operations.Max(nums);
            Assert.That(result, Is.EqualTo(-1));
        }

        /// <summary>
        /// Tests that Max returns the maximum integer from a list of mixed integers.
        /// </summary>
        [Test]
        public void Max_MixedIntegers_ReturnsMax()
        {
            List<int> nums = new List<int> { -1, 5, 0, -9, 2 };
            int result = Operations.Max(nums);
            Assert.That(result, Is.EqualTo(5));
        }

        /// <summary>
        /// Tests that Max returns zero when the list is empty.
        /// </summary>
        [Test]
        public void Max_EmptyList_ReturnsZero()
        {
            List<int> nums = new List<int>();
            int result = Operations.Max(nums);
            Assert.That(result, Is.EqualTo(0));
        }

        /// <summary>
        /// Tests that Max returns zero when the list is null.
        /// </summary>
        [Test]
        public void Max_NullList_ReturnsZero()
        {
            int result = Operations.Max(null);
            Assert.That(result, Is.EqualTo(0));
        }

        /// <summary>
        /// Tests that Max returns the element when the list has a single element.
        /// </summary>
        [Test]
        public void Max_SingleElement_ReturnsElement()
        {
            List<int> nums = new List<int> { 42 };
            int result = Operations.Max(nums);
            Assert.That(result, Is.EqualTo(42));
        }
    }
}