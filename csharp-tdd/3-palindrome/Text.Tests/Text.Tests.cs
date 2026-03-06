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
        /// Tests that IsPalindrome returns true for a simple palindrome string.
        /// </summary>
        [Test]
        public void IsPalindrome_SimplePalindrome_ReturnsTrue()
        {
            Assert.That(Str.IsPalindrome("level"), Is.True);
        }

        /// <summary>
        /// Tests that IsPalindrome returns true for a palindrome with uppercase characters.
        /// </summary>
        [Test]
        public void IsPalindrome_PalindromeWithCaseMismatch_ReturnsTrue()
        {
            Assert.That(Str.IsPalindrome("Racecar"), Is.True);
        }

        /// <summary>
        /// Tests that IsPalindrome returns true for a palindrome with punctuation and spaces.
        /// </summary>
        [Test]
        public void IsPalindrome_PalindromeWithPunctuationAndSpaces_ReturnsTrue()
        {
            Assert.That(Str.IsPalindrome("A man, a plan, a canal: Panama."), Is.True);
        }

        /// <summary>
        /// Tests that IsPalindrome returns true for an empty string.
        /// </summary>
        [Test]
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            Assert.That(Str.IsPalindrome(""), Is.True);
        }

        /// <summary>
        /// Tests that IsPalindrome returns false for a string that is not a palindrome.
        /// </summary>
        [Test]
        public void IsPalindrome_NotAPalindrome_ReturnsFalse()
        {
            Assert.That(Str.IsPalindrome("hello"), Is.False);
        }

        /// <summary>
        /// Tests that IsPalindrome returns true for a single character string.
        /// </summary>
        [Test]
        public void IsPalindrome_SingleCharacter_ReturnsTrue()
        {
            Assert.That(Str.IsPalindrome("a"), Is.True);
        }

        /// <summary>
        /// Tests that IsPalindrome returns true for a string containing only spaces and punctuation.
        /// </summary>
        [Test]
        public void IsPalindrome_OnlySpacesAndPunctuation_ReturnsTrue()
        {
            Assert.That(Str.IsPalindrome(" ,. "), Is.True);
        }
    }
}