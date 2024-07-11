using System;
using System.Threading;

namespace BasicFacebookFeatures.Adapter
{
    public class ThreadAdapter : IThreadAdapter
    {
        public void Execute(Action action)
        {
            Thread newThread = new Thread(() =>
            {
                try
                {
                    action();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception caught: {ex.Message}");
                }
            });
            newThread.Start();
        }
    }
}