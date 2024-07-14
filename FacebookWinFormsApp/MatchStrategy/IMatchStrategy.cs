using BasicFacebookFeatures.NewUser;

namespace BasicFacebookFeatures.Strategy
{
    public interface IMatchStrategy
    {
        bool Match(UserFacade i_Friend);
    }
}