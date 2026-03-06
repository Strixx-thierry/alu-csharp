using NUnit.Framework;
using Text;

namespace Text.Tests
{
    /// <summary>
    /// This class contains unit tests for the Str class.
    /// </summary>
    public class StrTests
    {
        [Test]
        public void UniqueChar_FirstCharUnique_ReturnsZero()
        {
            Assert.That(Str.UniqueChar("leetcode"), Is.EqualTo(0));
        }

        [Test]
        public void UniqueChar_MiddleCharUnique_ReturnsIndex()
        {
            Assert.That(Str.UniqueChar("loveleetcode"), Is.EqualTo(2));
        }

        [Test]
        public void UniqueChar_LastCharUnique_ReturnsIndex()
        {
            Assert.That(Str.UniqueChar("aabbc"), Is.EqualTo(4));
        }

        [Test]
        public void UniqueChar_NoUniqueChar_ReturnsMinusOne()
        {
            Assert.That(Str.UniqueChar("aabbcc"), Is.EqualTo(-1));
        }

        [Test]
        public void UniqueChar_EmptyString_ReturnsMinusOne()
        {
            Assert.That(Str.UniqueChar(""), Is.EqualTo(-1));
        }

        [Test]
        public void UniqueChar_SingleChar_ReturnsZero()
        {
            Assert.That(Str.UniqueChar("a"), Is.EqualTo(0));
        }
    }
}