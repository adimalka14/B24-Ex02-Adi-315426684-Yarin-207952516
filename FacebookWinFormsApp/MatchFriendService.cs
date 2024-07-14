using System.Collections.Generic;
using System.Linq;
using BasicFacebookFeatures.Adapter;
using BasicFacebookFeatures.MatchStrategy;
using BasicFacebookFeatures.Strategy;
using BasicFacebookFeatures.NewUser;
using System.Threading;
using System;

namespace BasicFacebookFeatures.Services
{
    public class MatchFriendService
    {
        public UserFacade UserFacadeProfile { get; set; }
        public IEnumerable<string> Cities { get; set; }
        public IEnumerable<UserFacade> MatchingFriendList { get; set; }
        public event Action DataLoaded;

        public MatchFriendService(UserFacade i_UserFacadeProfile)
        {
            UserFacadeProfile = i_UserFacadeProfile;
        }

        public void FetchData()
        {
            new Thread(loadCities).Start();
        }

        private void OnDataLoaded()
        {
            DataLoaded?.Invoke();
        }

        public void loadCities()
        {
            List<string> cities = new List<string>();

            cities.Add(UserFacadeProfile.Location);

            foreach (UserFacade friend in UserFacadeProfile.Friends)
            {
                if (!string.IsNullOrEmpty(friend.Location))
                {
                    cities.Add(friend.Location);
                }
            }

            this.Cities = cities;
            OnDataLoaded();
        }

        public IEnumerable<PageAdapter> GetLikedPages()
        {
            return UserFacadeProfile.LikedPages;
        }

        public IEnumerable<PageAdapter> GetFavoriteTeams()
        {
            return UserFacadeProfile.FavoriteTeams;
        }

        public bool IsValidAgeRange(int minAge, int maxAge)
        {
            return maxAge >= minAge;
        }

        public void GetMatchingFriends(
            bool isMaleChecked,
            bool isFemaleChecked,
            int minAge,
            int maxAge,
            IEnumerable<string> selectedCities,
            IEnumerable<PageAdapter> selectedLikedPages,
            IEnumerable<PageAdapter> selectedFavoriteTeams)
        {
            List<IMatchStrategy> strategies = new List<IMatchStrategy>
            {
                new AgeMatchStrategy(minAge, maxAge),
                new CityMatchStrategy(selectedCities),
                new GenderMatchStrategy(isMaleChecked, isFemaleChecked),
                new LikedPageStrategy(selectedLikedPages),
                new FavoriteTeamsStrategy(selectedFavoriteTeams),
            };
            List<UserFacade> filterFriend = new List<UserFacade>();

            foreach (UserFacade friend in UserFacadeProfile.Friends)
            {
                if (strategies.All(strategy => strategy.Match(friend)))
                {
                    filterFriend.Add(friend);
                }
            }

            MatchingFriendList = filterFriend;
            OnDataLoaded();
        }
    }
}
