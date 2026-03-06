using NUnit.Framework;
using Text;

namespace Text.Tests
{
    /// <summary>
    /// This class contains unit tests for the Str class.
    /// </summary>
    public class StrTests
    {
        /// <summary>
        /// Tests that CamelCase returns 1 for a single word string.
        /// </summary>
        [Test]
        public void CamelCase_SingleWord_ReturnsOne()
        {
            Assert.That(Str.CamelCase("hello"), Is.EqualTo(1));
        }

        /// <summary>
        /// Tests that CamelCase returns 2 for a two word camelCase string.
        /// </summary>
        [Test]
        public void CamelCase_TwoWords_ReturnsTwo()
        {
            Assert.That(Str.CamelCase("helloWorld"), Is.EqualTo(2));
        }

        /// <summary>
        /// Tests that CamelCase returns the correct count for a long camelCase string.
        /// </summary>
        [Test]
        public void CamelCase_ManyWords_ReturnsCorrectCount()
        {
            Assert.That(Str.CamelCase("thisIsALongCamelCaseString"), Is.EqualTo(7));
        }

        /// <summary>
        /// Tests that CamelCase returns 0 for an empty string.
        /// </summary>
        [Test]
        public void CamelCase_EmptyString_ReturnsZero()
        {
            Assert.That(Str.CamelCase(""), Is.EqualTo(0));
        }

        /// <summary>
        /// Tests that CamelCase returns 1 for a single letter string.
        /// </summary>
        [Test]
        public void CamelCase_SingleLetter_ReturnsOne()
        {
            Assert.That(Str.CamelCase("a"), Is.EqualTo(1));
        }
    }
}