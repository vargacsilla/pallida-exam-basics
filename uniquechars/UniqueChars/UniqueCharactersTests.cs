using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueChars
{
    [TestFixture]
    class UniqueCharactersTests
    {
        [Test]
        public void UniqueCharactersTest_WhenDifferentLetters_ReturnSame()
        {
            string input = "abcd";
            List<char> expected = new List<char>() { 'a', 'b', 'c', 'd' };

            var output = Program.UniqueCharacters(input);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void UniqueCharactersTest_WhenDuplicateLetters_ReturnRest()
        {
            string input = "abbcd";
            List<char> expected = new List<char>() { 'a', 'c', 'd' };

            var output = Program.UniqueCharacters(input);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void UniqueCharactersTest_WhenNull_ReturnNull()
        {
            string input = null;
            var expected = new List<char>();

            var output = Program.UniqueCharacters(input);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void UniqueCharactersTest_WhenAllSame_ReturnEmpty()
        {
            string input = "aaaa";
            var expected = new List<char>();

            var output = Program.UniqueCharacters(input);

            Assert.AreEqual(expected, output);
        }
    }
}
