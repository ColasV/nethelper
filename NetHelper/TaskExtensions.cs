using System.Threading.Tasks;

namespace NetHelper
{
    public static class TaskExtensions
    {
        public static async Task SwallowException(this Task task)
        {
            try
            {
                await task;
            }
            catch
            {
                // ignore
            }
        }

    }
}
