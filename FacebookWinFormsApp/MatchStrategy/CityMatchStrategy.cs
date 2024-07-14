using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using BasicFacebookFeatures.NewUser;

namespace BasicFacebookFeatures.Strategy
{
    public class CityMatchStrategy : IMatchStrategy
    {
        private IEnumerable<string> selectedCities;

        public CityMatchStrategy(IEnumerable<string> selectedCities)
        {
            this.selectedCities = selectedCities;
        }

        public bool Match(UserFacade friend)
        {
            return selectedCities.Contains(friend.Location) || !selectedCities.Any();
        }
    }
}
