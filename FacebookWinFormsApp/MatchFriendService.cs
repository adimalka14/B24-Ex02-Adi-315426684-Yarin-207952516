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
        public bool IsMaleChecked { get; set; } = true;
        public bool IsFemaleChecked { get; set; } = false;
        public int MinAge { get; set; }
        public int MaxAge { get; set; } = 120;
        public IEnumerable<string> SelectedCities { get; set; }
        public IEnumerable<PageAdapter> SelectedLikedPages { get; set; }
        public IEnumerable<PageAdapter> SelectedFavoriteTeams { get; set; }

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

            cities.Add(UserFacadeProfile?.Location);

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

        public void GetMatchingFriends()
        {
            List<UserFacade> filterFriend = new List<UserFacade>();
            List<IMatchStrategy> strategies = new List<IMatchStrategy>
            {
                new AgeMatchStrategy(MinAge, MaxAge),
                new CityMatchStrategy(SelectedCities),
                new GenderMatchStrategy(IsMaleChecked, IsFemaleChecked),
                new LikedPageStrategy(SelectedLikedPages),
                new FavoriteTeamsStrategy(SelectedFavoriteTeams),
            };

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