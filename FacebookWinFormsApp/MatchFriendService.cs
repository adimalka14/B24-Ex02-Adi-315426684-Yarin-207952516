using System;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using BasicFacebookFeatures.MatchStrategy;
using BasicFacebookFeatures.Strategy;
using BasicFacebookFeatures.NewUser;

namespace BasicFacebookFeatures.Services
{
    public class MatchFriendService
    {
        private readonly LoggedUser r_UserProfile;

        public MatchFriendService(LoggedUser i_UserProfile)
        {
            r_UserProfile = i_UserProfile;
        }

        public IEnumerable<string> GetCities()
        {
            var cities = new HashSet<string> { r_UserProfile.Location};
            foreach (var friend in r_UserProfile.Friends)
            {
                if (!string.IsNullOrEmpty(friend.Location?.Name))
                {
                    cities.Add(friend.Location.Name);
                }
            }

            return cities;
        }

        public IEnumerable<Page> GetLikedPages()
        {
            return r_UserProfile.LikedPages;
        }

        public IEnumerable<Page> GetFavoriteTeams()
        {
            return r_UserProfile.FavoriteTeams;
        }

        public bool IsValidAgeRange(int minAge, int maxAge)
        {
            return maxAge >= minAge;
        }

        public IEnumerable<User> GetMatchingFriends(
            bool isMaleChecked,
            bool isFemaleChecked,
            int minAge,
            int maxAge,
            IEnumerable<string> selectedCities,
            IEnumerable<Page> selectedLikedPages,
            IEnumerable<Page> selectedFavoriteTeams)
        {
            List<IMatchStrategy> strategies = new List<IMatchStrategy>
            {
                new AgeMatchStrategy(minAge, maxAge),
                new CityMatchStrategy(selectedCities),
                new GenderMatchStrategy(isMaleChecked, isFemaleChecked),
                new LikedPageStrategy(selectedLikedPages),
                new FavoriteTeamsStrategy(selectedFavoriteTeams),
            };

            foreach (User friend in r_UserProfile.Friends)
            {
                if (strategies.All(strategy => strategy.Match(friend)))
                {
                    yield return friend;
                }
            }
        }
    }
}
