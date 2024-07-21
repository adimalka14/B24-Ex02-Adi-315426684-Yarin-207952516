using System;
using System.Collections.Generic;
using System.Linq;
using BasicFacebookFeatures.Model;
using BasicFacebookFeatures.Model.Adapter;
using BasicFacebookFeatures.Model.NewUser;

namespace BasicFacebookFeatures.ViewModel
{
    public class UserPageService
    {
        private readonly UserComposer r_Composer = new UserComposer(new UserBuilder());
        public readonly NotifyThread r_NotifyThread  = new NotifyThread();
        public UserFacade InUserFacade { get; set; }

        public void FetchData()
        {
            r_NotifyThread.SafeExecute(fetchPrivateDetails);
            r_NotifyThread.SafeExecute(fetchUserFriends);
            r_NotifyThread.SafeExecute(fetchLikedPages);
            r_NotifyThread.SafeExecute(fetchFavoriteTeams);
            r_NotifyThread.SafeExecute(fetchPosts);
        }

        private void fetchPrivateDetails()
        {
            r_Composer.UserPrivateDetails(InUserFacade);
        }

        private void fetchUserFriends()
        {
            r_Composer.UserFriends(InUserFacade);
        }

        private void fetchLikedPages()
        {
            r_Composer.LikedPages(InUserFacade);
        }

        private void fetchFavoriteTeams()
        {
            r_Composer.FavoriteTeams(InUserFacade);
        }

        private void fetchPosts()
        {
            r_Composer.Posts(InUserFacade);
        }

        public void PostStatus(string i_StatusText)
        {
            List<PostAdapter> list = InUserFacade.Posts.ToList();

            list.Add(new PostAdapter
            {
                Description = $"{InUserFacade.FirstName} {InUserFacade.LastName} : {i_StatusText}",CreatedTime = DateTime.Now,Location = InUserFacade.Location
            });
            InUserFacade.Posts = list;
            InUserFacade.RealUser.PostStatus(i_StatusText);
        }
    }
}