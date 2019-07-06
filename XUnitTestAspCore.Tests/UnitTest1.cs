using System;
using Xunit;

namespace XUnitTestAspCore.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int i = 1;

            Assert.Equal(i, 1);
        }
    }
}
