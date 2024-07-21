using BasicFacebookFeatures.Model.NewUser;

namespace BasicFacebookFeatures.Model.MatchStrategy
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
            return (i_Friend.Gender == UserFacade.eGender.Male && r_IsMaleChecked) ||
                   (i_Friend.Gender == UserFacade.eGender.Female && r_IsFemaleChecked);
        }
    }
}