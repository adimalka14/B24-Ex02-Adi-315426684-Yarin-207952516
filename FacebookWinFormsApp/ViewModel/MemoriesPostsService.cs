﻿using System;
using System.Collections.Generic;
using System.Linq;
using BasicFacebookFeatures.Model;
using BasicFacebookFeatures.Model.Adapter;
using BasicFacebookFeatures.Model.NewUser;

namespace BasicFacebookFeatures.ViewModel
{
    public class MemoriesPostsService
    {
        private readonly UserFacade r_UserFacadeProfile;
        public IEnumerable<string> Locations { get; set; }
        public DateTime StratTime { get; set; }
        public DateTime EndTime { get; set; }
        public IEnumerable<string> CheckedLocations { get; set; }
        public IEnumerable<PostAdapter> FilteredPosts { get; set; }
        public readonly NotifyThread r_NotifyThread = new NotifyThread();

        public MemoriesPostsService(UserFacade i_UserFacadeProfile)
        {
            r_UserFacadeProfile = i_UserFacadeProfile;
            InitializeDateRange();
        }

        private void InitializeDateRange()
        {
            StratTime = new DateTime(2004, 2, 4);
            EndTime = DateTime.Now;
        }

        public void FetchData()
        {
            r_NotifyThread.SafeExecute(GetLocations);
        }

        public void GetLocations()
        {
            List<string> locations = new List<string> { "All locations" };

            if (r_UserFacadeProfile.Posts == null)
            {
                throw new Exception("Please wait and try again later");
            }

            foreach (PostAdapter post in r_UserFacadeProfile.Posts)
            {
                if (!string.IsNullOrEmpty(post.Location))
                {
                    locations.Add(post.Location);
                }
            }

            this.Locations = locations;
        }


        public bool CheckDate(PostAdapter i_Post)
        {
            return i_Post.CreatedTime >= StratTime.Date &&
                   i_Post.CreatedTime <= EndTime.Date;
        }

        public bool CheckLocation(PostAdapter i_Post)
        {
            return CheckedLocations.Contains(i_Post.Location);
        }

        public void GetFilteredPosts()
        {
            FilteredPosts =
                r_UserFacadeProfile.Posts.Where(post =>
                    (CheckedLocations.Contains("All locations")
                     || CheckLocation(post)) && CheckDate(post)).ToList();
        }
    }
}