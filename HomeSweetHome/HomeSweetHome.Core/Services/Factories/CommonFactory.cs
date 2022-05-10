using System.Threading;

namespace HomeSweetHome.Core.Services.Factories
{
    public static class CommonFactory
    {
        private static volatile int _memberId;

        public static int GenerateId()
        {
            return Interlocked.Increment(ref _memberId);
        }
    }
}
