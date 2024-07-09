using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicFacebookFeatures.Services
{
    public class MatchFriendService
    {
        private readonly User r_UserProfile;

        public MatchFriendService(User i_UserProfile)
        {
            r_UserProfile = i_UserProfile;
        }

        public IEnumerable<string> GetCities()
        {
            var cities = new HashSet<string> { r_UserProfile.Location?.Name };
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
            return r_UserProfile.LikedPages.Cast<Page>();
        }

        public IEnumerable<Page> GetFavoriteTeams()
        {
            return r_UserProfile.FavofriteTeams.Cast<Page>();
        }

        public bool IsValidAgeRange(int minAge, int maxAge)
        {
            return maxAge >= minAge;
        }

        public bool CheckGender(User.eGender userGender, bool isMaleChecked, bool isFemaleChecked)
        {
            return (userGender == User.eGender.male && isMaleChecked) ||
                   (userGender == User.eGender.female && isFemaleChecked);
        }

        public bool CheckAge(string birthday, int minAge, int maxAge)
        {
            DateTime birthDate = DateTime.ParseExact(birthday, "MM/dd/yyyy", null);
            int age = DateTime.Today.Year - birthDate.Year;
            return age <= maxAge && age >= minAge;
        }

        public bool CheckCity(string friendCity, IEnumerable<string> selectedCities)
        {
            return selectedCities.Contains(friendCity) || !selectedCities.Any();
        }

        public bool CheckLikedPages(List<Page> friendLikedPages, IEnumerable<Page> selectedLikedPages)
        {
            return !selectedLikedPages.Any() || friendLikedPages.Intersect(selectedLikedPages).Any();
        }

        public bool CheckFavoriteTeams(List<Page> friendFavoriteTeams, IEnumerable<Page> selectedFavoriteTeams)
        {
            return !selectedFavoriteTeams.Any() || friendFavoriteTeams.Intersect(selectedFavoriteTeams).Any();
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
            foreach (var friend in r_UserProfile.Friends)
            {
                if (CheckGender(friend.Gender.Value, isMaleChecked, isFemaleChecked) &&
                    CheckAge(friend.Birthday, minAge, maxAge) &&
                    CheckCity(friend.Location?.Name, selectedCities) &&
                    CheckLikedPages(friend.LikedPages.ToList(), selectedLikedPages) &&
                    CheckFavoriteTeams(friend.FavofriteTeams.ToList(), selectedFavoriteTeams))
                {
                    yield return friend;
                }
            }
        }
    }
}
