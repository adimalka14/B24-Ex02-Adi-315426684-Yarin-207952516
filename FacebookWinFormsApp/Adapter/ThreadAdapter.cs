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
                    // Handle the exception or log it
                    Console.WriteLine($"Exception caught: {ex.Message}");
                    // אפשר לשקול להעביר את החריגה הלאה או לטפל בה בדרכים נוספות
                }
            });
            newThread.Start();
        }
    }
}