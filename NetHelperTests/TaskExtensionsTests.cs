using System;
using System.Threading.Tasks;
using NetHelper;
using Xunit;

namespace NetHelperTests
{
    public class TaskExtensionsTests
    {
        [Fact]
        public async Task SwalllowExceptionShouldNotThrow()
        {
            var task = Task.FromException(new Exception());
            await task.SwallowException();
        }
    }
}
