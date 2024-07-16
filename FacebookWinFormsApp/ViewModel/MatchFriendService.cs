using System;
using System.Collections.Generic;
using System.Linq;
using BasicFacebookFeatures.Model;
using BasicFacebookFeatures.Model.Adapter;
using BasicFacebookFeatures.Model.MatchStrategy;
using BasicFacebookFeatures.Model.NewUser;

namespace BasicFacebookFeatures.ViewModel
{
    public class MatchFriendService
    {
        public UserFacade UserFacadeProfile { get; set; }
        public IEnumerable<string> Cities { get; set; }
        public IEnumerable<UserFacade> MatchingFriendList { get; set; }
        public bool IsMaleChecked { get; set; } = true;
        public bool IsFemaleChecked { get; set; } = true;
        public int MinAge { get; set; }
        public int MaxAge { get; set; } = 120;
        public IEnumerable<string> SelectedCities { get; set; }
        public IEnumerable<PageAdapter> SelectedLikedPages { get; set; }
        public IEnumerable<PageAdapter> SelectedFavoriteTeams { get; set; }
        public readonly NotifyThread r_NotifyThread = new NotifyThread();

        public MatchFriendService(UserFacade i_UserFacadeProfile)
        {
            UserFacadeProfile = i_UserFacadeProfile;
        }

        public void FetchData()
        {
            r_NotifyThread.SafeExecute(loadCities);
        }

        private void loadCities()
        {
            List<string> cities = new List<string>();

            cities.Add(UserFacadeProfile?.Location);

            if (UserFacadeProfile?.Friends == null)
            {
                throw new Exception("please wait and try again later");
            }

            foreach (UserFacade friend in UserFacadeProfile.Friends)
            {
                if (!string.IsNullOrEmpty(friend.Location))
                {
                    cities.Add(friend.Location);
                }
            }

            this.Cities = cities;
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
        }
    }
}