using System;
using System.Collections;
using Xunit;

namespace BrailleDots.Tests
{
    public class UnitTest1
    {
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
