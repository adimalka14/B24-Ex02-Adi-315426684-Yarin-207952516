using BasicFacebookFeatures.NewUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using BasicFacebookFeatures.Adapter;

namespace BasicFacebookFeatures.Services
{
    public class MemoriesPostsService
    {
        private readonly UserFacade r_UserFacadeProfile;
        public IEnumerable<string> Locations { get; set; }
        public IEnumerable<PostAdapter> FilteredPosts { get; set; }
        public event Action DataLoaded;


        public MemoriesPostsService(UserFacade i_UserFacadeProfile)
        {
            r_UserFacadeProfile = i_UserFacadeProfile;
        }

        public void FetchData()
        {
            new Thread(GetLocations).Start();
        }
        private void OnDataLoaded()
        {
            DataLoaded?.Invoke();
        }

        public void GetLocations()
        {
            List<string> locations = new List<string> { "All locations" };
            foreach (PostAdapter post in r_UserFacadeProfile.Posts)
            {
                if (!string.IsNullOrEmpty(post.Location))
                {
                    locations.Add(post.Location);
                }
            }

            this.Locations=locations;
            OnDataLoaded();
        }

        public bool CheckDate(PostAdapter i_Post, DateTime startDate, DateTime endDate)
        {
            return i_Post.CreatedTime >= startDate.Date &&
                   i_Post.CreatedTime <= endDate.Date;
        }

        public bool CheckLocation(PostAdapter i_Post, IEnumerable<string> i_SelectedLocation)
        {
            return  i_SelectedLocation.Contains(i_Post.Location);
        }

        public void GetFilteredPosts(IEnumerable<string> i_SelectedLocation, DateTime startDate, DateTime endDate)
        {
            new Thread(()=>
            {
                FilteredPosts =
                    r_UserFacadeProfile.Posts.Where(post => 
                        (i_SelectedLocation.Contains("All locations")
                         || CheckLocation(post, i_SelectedLocation)) && CheckDate(post, startDate, endDate)).ToList();
                OnDataLoaded();
            }).Start();
        }
    }
}