using BasicFacebookFeatures.NewUser;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Strategy
{
    public interface IMatchStrategy
    {
        bool Match(UserFacade friend);
    }
}
