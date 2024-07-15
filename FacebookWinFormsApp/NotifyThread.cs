using System;
using System.Threading;

namespace BasicFacebookFeatures
{
    public delegate void ErrorHandler(Exception ex);

    public class NotifyThread
    {
        public event Action Finish;
        public event ErrorHandler ErrorOccurred;

        public void SafeExecute(Action i_Action)
        {
            new Thread(() =>
            {
                try
                {
                    i_Action.Invoke();
                    Finish?.Invoke();
                }
                catch (Exception ex)
                {
                    ErrorOccurred?.Invoke(ex);
                }
            }).Start();
        }
    }
}