using System;
using BasicFacebookFeatures.NewUser;

namespace BasicFacebookFeatures.Strategy
{
    public class AgeMatchStrategy : IMatchStrategy
    {
        private readonly int r_MinAge;
        private readonly int r_MaxAge;

        public AgeMatchStrategy(int i_MinAge, int i_MaxAge)
        {
            this.r_MinAge = i_MinAge;
            this.r_MaxAge = i_MaxAge;
        }

        public bool Match(UserFacade i_Friend)
        {
            DateTime birthDate = DateTime.ParseExact(i_Friend.Birthday, "MM/dd/yyyy", null);
            int age = DateTime.Today.Year - birthDate.Year;

            return age >= r_MinAge && age <= r_MaxAge;
        }
    }
}