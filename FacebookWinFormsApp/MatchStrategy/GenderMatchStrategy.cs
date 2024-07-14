using BasicFacebookFeatures.NewUser;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Strategy
{
    public class GenderMatchStrategy : IMatchStrategy
    {
        private bool isMaleChecked;
        private bool isFemaleChecked;

        public GenderMatchStrategy(bool isMaleChecked, bool isFemaleChecked)
        {
            this.isMaleChecked = isMaleChecked;
            this.isFemaleChecked = isFemaleChecked;
        }

        public bool Match(UserFacade friend)
        {
            return (friend.Gender == UserFacade.eGender.male && isMaleChecked) ||
                   (friend.Gender == UserFacade.eGender.female && isFemaleChecked);
        }
    }
}