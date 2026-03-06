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
        public void CamelCase_SingleWord_ReturnsOne()
        {
            Assert.That(Str.CamelCase("hello"), Is.EqualTo(1));
        }

        [Test]
        public void CamelCase_TwoWords_ReturnsTwo()
        {
            Assert.That(Str.CamelCase("helloWorld"), Is.EqualTo(2));
        }

        [Test]
        public void CamelCase_ManyWords_ReturnsCorrectCount()
        {
            Assert.That(Str.CamelCase("thisIsALongCamelCaseString"), Is.EqualTo(7));
        }

        [Test]
        public void CamelCase_EmptyString_ReturnsZero()
        {
            Assert.That(Str.CamelCase(""), Is.EqualTo(0));
        }

        [Test]
        public void CamelCase_SingleLetter_ReturnsOne()
        {
            Assert.That(Str.CamelCase("a"), Is.EqualTo(1));
        }
    }
}