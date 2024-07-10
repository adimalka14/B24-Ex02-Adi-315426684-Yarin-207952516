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

        public bool Match(User friend)
        {
            return (friend.Gender == User.eGender.male && isMaleChecked) ||
                   (friend.Gender == User.eGender.female && isFemaleChecked);
        }
    }
}
