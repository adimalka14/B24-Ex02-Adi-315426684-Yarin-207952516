using FacebookWrapper.ObjectModel;
using System;
using BasicFacebookFeatures.NewUser;

namespace BasicFacebookFeatures.Strategy
{
    public class AgeMatchStrategy : IMatchStrategy
    {
        private int minAge;
        private int maxAge;

        public AgeMatchStrategy(int minAge, int maxAge)
        {
            this.minAge = minAge;
            this.maxAge = maxAge;
        }

        public bool Match(UserFacade friend)
        {
            DateTime birthDate = DateTime.ParseExact(friend.Birthday, "MM/dd/yyyy", null);
            int age = DateTime.Today.Year - birthDate.Year;

            return age >= minAge && age <= maxAge;
        }
    }
}
