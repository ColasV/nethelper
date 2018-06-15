using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NetHelper;
using Xunit;

namespace NetHelperTests
{
    public class EnumerableExtensionsTests
    {
        [Fact]
        public void IsNullOrEmptyReturnExpectedValue()
        {
            IEnumerable<string> enumerable = null;

            Assert.True(enumerable.IsNullOrEmpty());

            Assert.True(new List<string>().IsNullOrEmpty());

            Assert.False((new List<string> { string.Empty}).IsNullOrEmpty());

        }
    }
}
