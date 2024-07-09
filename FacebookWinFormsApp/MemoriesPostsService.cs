using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicFacebookFeatures.Services
{
    public class MemoriesPostsService
    {
        private readonly User r_UserProfile;

        public MemoriesPostsService(User i_UserProfile)
        {
            r_UserProfile = i_UserProfile;
        }

        public IEnumerable<string> GetLocations()
        {
            var locations = new HashSet<string> { "All locations" };
            foreach (var post in r_UserProfile.Posts)
            {
                if (!string.IsNullOrEmpty(post.Place?.Location.City))
                {
                    locations.Add(post.Place.Location.City);
                }
            }

            return locations;
        }

        public bool CheckDate(Post i_Post, DateTime startDate, DateTime endDate)
        {
            return i_Post.CreatedTime.Value.Date >= startDate.Date &&
                   i_Post.CreatedTime.Value.Date <= endDate.Date;
        }

        public bool CheckLocation(Post i_Post, string i_SelectedLocation)
        {
            return i_Post.Place?.Location?.City == i_SelectedLocation;
        }

        public IEnumerable<Post> GetFilteredPosts(string i_SelectedLocation, DateTime startDate, DateTime endDate)
        {
            return r_UserProfile.Posts.Where(post =>
                (i_SelectedLocation == "All locations" || CheckLocation(post, i_SelectedLocation)) &&
                CheckDate(post, startDate, endDate));
        }
    }
}