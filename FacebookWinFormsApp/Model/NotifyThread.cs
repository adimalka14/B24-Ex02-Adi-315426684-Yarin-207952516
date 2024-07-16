﻿using System;
using System.Threading;

namespace BasicFacebookFeatures.Model
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
                    onFinish();
                }
                catch (Exception ex)
                {
                    onErrorOccurred(ex);
                }
            }).Start();
        }

        protected virtual void onFinish()
        {
            Finish?.Invoke();
        }

        protected virtual void onErrorOccurred(Exception ex)
        {
            ErrorOccurred?.Invoke(ex);
        }
    }
}