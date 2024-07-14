using BasicFacebookFeatures.NewUser;

namespace BasicFacebookFeatures.Strategy
{
    public class GenderMatchStrategy : IMatchStrategy
    {
        private readonly bool r_IsMaleChecked;
        private readonly bool r_IsFemaleChecked;

        public GenderMatchStrategy(bool i_IsMaleChecked, bool i_IsFemaleChecked)
        {
            this.r_IsMaleChecked = i_IsMaleChecked;
            this.r_IsFemaleChecked = i_IsFemaleChecked;
        }

        public bool Match(UserFacade i_Friend)
        {
            return (i_Friend.Gender == UserFacade.eGender.male && r_IsMaleChecked) ||
                   (i_Friend.Gender == UserFacade.eGender.female && r_IsFemaleChecked);
        }
    }
}