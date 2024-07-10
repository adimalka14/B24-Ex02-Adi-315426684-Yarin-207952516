using System;
using System.Threading;

namespace BasicFacebookFeatures.Adapter
{
    public class ThreadAdapter : IThreadAdapter
    {
        public void Execute(Action i_Action)
        {
            Thread newThread = new Thread(new ThreadStart(i_Action));
            newThread.Start();
        }
    }
}