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
        /// Tests that UniqueChar returns 0 for a string where the first character is unique.
        /// </summary>
        [Test]
        public void UniqueChar_FirstCharUnique_ReturnsZero()
        {
            Assert.That(Str.UniqueChar("leetcode"), Is.EqualTo(0));
        }

        /// <summary>
        /// Tests that UniqueChar returns the correct index for a string where a middle character is unique.
        /// </summary>
        [Test]
        public void UniqueChar_MiddleCharUnique_ReturnsIndex()
        {
            Assert.That(Str.UniqueChar("loveleetcode"), Is.EqualTo(2));
        }

        /// <summary>
        /// Tests that UniqueChar returns the correct index for a string where the last character is unique.
        /// </summary>
        [Test]
        public void UniqueChar_LastCharUnique_ReturnsIndex()
        {
            Assert.That(Str.UniqueChar("aabbc"), Is.EqualTo(4));
        }

        /// <summary>
        /// Tests that UniqueChar returns -1 for a string with no unique characters.
        /// </summary>
        [Test]
        public void UniqueChar_NoUniqueChar_ReturnsMinusOne()
        {
            Assert.That(Str.UniqueChar("aabbcc"), Is.EqualTo(-1));
        }

        /// <summary>
        /// Tests that UniqueChar returns -1 for an empty string.
        /// </summary>
        [Test]
        public void UniqueChar_EmptyString_ReturnsMinusOne()
        {
            Assert.That(Str.UniqueChar(""), Is.EqualTo(-1));
        }

        /// <summary>
        /// Tests that UniqueChar returns 0 for a single character string.
        /// </summary>
        [Test]
        public void UniqueChar_SingleChar_ReturnsZero()
        {
            Assert.That(Str.UniqueChar("a"), Is.EqualTo(0));
        }
    }
}