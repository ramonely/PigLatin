using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PigLatin
{
    public class TestProgram
    {
        [Theory]
        [InlineData("apple", "appleway")]
        [InlineData("heck", "eckhhay")]
        [InlineData("strong", "ongstray")]
        [InlineData("tommy@email.com", "tommy@email.com")]
        [InlineData("aardvark", "aardvarkway")]
        [InlineData("Tommy", "ommytay")]
        [InlineData("gym", "gym")]
        [InlineData("apple joy gym tommy@email.com strong", "appleway oyjay gym tommy@email.com ongstray")]
        public void TestPigLatinTheory(string word, string expected)
        {
            Program p = new Program();
            string actual = p.ToPigLatin(word);
            Assert.Equal(expected, actual);
        }
    }
}