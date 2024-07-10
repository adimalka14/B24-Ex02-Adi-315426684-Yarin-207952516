using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Linq;

namespace BasicFacebookFeatures.Strategy
{
    public class CityMatchStrategy : IMatchStrategy
    {
        private IEnumerable<string> selectedCities;

        public CityMatchStrategy(IEnumerable<string> selectedCities)
        {
            this.selectedCities = selectedCities;
        }

        public bool Match(User friend)
        {
            return selectedCities.Contains(friend.Location?.Name) || !selectedCities.Any();
        }
    }
}
