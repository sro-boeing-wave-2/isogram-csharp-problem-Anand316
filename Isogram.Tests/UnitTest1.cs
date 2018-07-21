using System;
using Xunit;
using Isogram;

namespace Isogram.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(Isogram_Problem.Isogram_String(""));
        }

        [Fact]
        public void Test2()
        {
            Assert.True(Isogram_Problem.Isogram_String("isogram"));
        }

        [Fact]
        public void Test3()
        {
            Assert.False(Isogram_Problem.Isogram_String("eleven"));
        }

        [Fact]
        public void Test4()
        {
            Assert.True(Isogram_Problem.Isogram_String("six-year-old"));
        }

        [Fact]
        public void Test5()
        {
            Assert.True(Isogram_Problem.Isogram_String("subdermatoglyphic"));
        }

        [Fact]
        public void Test6()
        {
            Assert.True(Isogram_Problem.Isogram_String("Alphabet"));
        }

        [Fact]
        public void Test7()
        {
            Assert.True(Isogram_Problem.Isogram_String("thumbscrew-japingly"));
        }

        [Fact]
        public void Test8()
        {
            Assert.True(Isogram_Problem.Isogram_String("Mark John"));
        }


    }
}
