using System.Collections.Generic;
using System.Linq;
using BasicFacebookFeatures.NewUser;

namespace BasicFacebookFeatures.Strategy
{
    public class CityMatchStrategy : IMatchStrategy
    {
        private readonly IEnumerable<string> r_SelectedCities;

        public CityMatchStrategy(IEnumerable<string> i_SelectedCities)
        {
            this.r_SelectedCities = i_SelectedCities;
        }

        public bool Match(UserFacade i_Friend)
        {
            return r_SelectedCities.Contains(i_Friend.Location) || !r_SelectedCities.Any();
        }
    }
}