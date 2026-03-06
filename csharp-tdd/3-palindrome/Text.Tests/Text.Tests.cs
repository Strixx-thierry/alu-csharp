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
        public void IsPalindrome_SimplePalindrome_ReturnsTrue()
        {
            Assert.That(Str.IsPalindrome("level"), Is.True);
        }

        [Test]
        public void IsPalindrome_PalindromeWithCaseMismatch_ReturnsTrue()
        {
            Assert.That(Str.IsPalindrome("Racecar"), Is.True);
        }

        [Test]
        public void IsPalindrome_PalindromeWithPunctuationAndSpaces_ReturnsTrue()
        {
            Assert.That(Str.IsPalindrome("A man, a plan, a canal: Panama."), Is.True);
        }

        [Test]
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            Assert.That(Str.IsPalindrome(""), Is.True);
        }

        [Test]
        public void IsPalindrome_NotAPalindrome_ReturnsFalse()
        {
            Assert.That(Str.IsPalindrome("hello"), Is.False);
        }

        [Test]
        public void IsPalindrome_SingleCharacter_ReturnsTrue()
        {
            Assert.That(Str.IsPalindrome("a"), Is.True);
        }

        [Test]
        public void IsPalindrome_OnlySpacesAndPunctuation_ReturnsTrue()
        {
            Assert.That(Str.IsPalindrome(" ,. "), Is.True);
        }
    }
}