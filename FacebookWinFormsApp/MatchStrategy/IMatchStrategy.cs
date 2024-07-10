using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Strategy
{
    public interface IMatchStrategy
    {
        bool Match(User friend);
    }
}
