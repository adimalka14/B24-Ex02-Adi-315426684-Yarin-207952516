using System;

namespace BasicFacebookFeatures.Adapter
{
    public interface IThreadAdapter
    {
        void Execute(Action i_Action);
    }
}
