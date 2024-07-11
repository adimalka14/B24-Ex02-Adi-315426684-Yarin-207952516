using BasicFacebookFeatures.NewUser;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using BasicFacebookFeatures.NewPost;

namespace BasicFacebookFeatures.Services
{
    public class MemoriesPostsService
    {
        private readonly LoggedUser r_UserProfile;

        public MemoriesPostsService(LoggedUser i_UserProfile)
        {
            r_UserProfile = i_UserProfile;
        }

        public IEnumerable<string> GetLocations()
        {
            var locations = new HashSet<string> { "All locations" };
            foreach (PostProxy post in r_UserProfile.Posts)
            {
                if (!string.IsNullOrEmpty(post.Location))
                {
                    locations.Add(post.Location);
                }
            }

            return locations;
        }

        public bool CheckDate(PostProxy i_Post, DateTime startDate, DateTime endDate)
        {
            return i_Post.CreatedTime >= startDate.Date &&
                   i_Post.CreatedTime <= endDate.Date;
        }

        public bool CheckLocation(PostProxy i_Post, string i_SelectedLocation)
        {
            return i_Post.Location == i_SelectedLocation;
        }

        public IEnumerable<PostProxy> GetFilteredPosts(string i_SelectedLocation, DateTime startDate, DateTime endDate)
        {
            return r_UserProfile.Posts.Where(post =>
                (i_SelectedLocation == "All locations" || CheckLocation(post, i_SelectedLocation)) &&
                CheckDate(post, startDate, endDate));
        }
    }
}