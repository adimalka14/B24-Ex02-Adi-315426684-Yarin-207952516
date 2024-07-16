using BasicFacebookFeatures.Model.NewUser;

namespace BasicFacebookFeatures.Model.MatchStrategy
{
    public interface IMatchStrategy
    {
        bool Match(UserFacade i_Friend);
    }
}