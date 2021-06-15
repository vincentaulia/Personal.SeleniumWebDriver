using System.Threading;

namespace Personal.SeleniumWebDriver
{
    internal static class Helpers
    {
        //Brief delay to show browser interactions
        public static void Pause(int secondsToPause = 3000)
        {
            Thread.Sleep(secondsToPause);
        }
    }
}
