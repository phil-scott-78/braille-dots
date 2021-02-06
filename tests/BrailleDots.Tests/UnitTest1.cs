using System;
using System.Collections;
using System.Runtime.InteropServices;
using Xunit;

namespace BrailleDots.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("1", '⠁')]
        [InlineData("2", '⠂')]
        [InlineData("3", '⠄')]
        [InlineData("4", '⠈')]
        [InlineData("5", '⠐')]
        [InlineData("6", '⠠')]
        [InlineData("7", '⡀')]
        [InlineData("8", '⢀')]
        [InlineData("235", '⠖')]
        [InlineData("12456", '⠻')]
        [InlineData("12568", '⢳')]
        public void Can_convert_characters(string pattern, char expectedDots)
        {
            Assert.Equal(expectedDots, DotPattern.Get(pattern));
        }
        
        [Fact]
        public void Test1()
        {
            Assert.Equal('⠇', DotPattern.Get("123"));
            Assert.Equal('⠇', DotPattern.Get(new BitArray(new[] {true, true, true, false, false, false, false, false})));
            Assert.Equal('⠇', DotPattern.Get(true, true, true, false, false, false, false, false));
            Assert.Equal('⠇', DotPattern.Get(0b00000111));
            Assert.Equal('⠇', DotPattern.Get(new[,]
            {
                {true, false},
                {true, false},
                {true, false},
                {false, false},
            }));

            Assert.Equal('⣠', DotPattern.Get("678"));
            Assert.Equal('⣠', DotPattern.Get(new BitArray(new[] {false, false, false, false, false, true, true, true})));
            Assert.Equal('⣠', DotPattern.Get(false, false, false, false, false, true, true, true));
            Assert.Equal('⣠', DotPattern.Get(0b11100000));
            Assert.Equal('⣠', DotPattern.Get(new[,]
            {
                {false, false},
                {false, false},
                {false, true},
                {true, true},
            }));
        }
    }
}
