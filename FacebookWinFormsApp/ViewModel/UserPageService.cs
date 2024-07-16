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
        public readonly NotifyThread r_NotifyThread = new NotifyThread();
        public UserFacade InUserFacade { get; set; }

        public void FetchData()
        {
            r_NotifyThread.SafeExecute(FetchPrivateDetails);
            r_NotifyThread.SafeExecute(FetchUserFriends);
            r_NotifyThread.SafeExecute(FetchLikedPages);
            r_NotifyThread.SafeExecute(FetchFavoriteTeams);
            r_NotifyThread.SafeExecute(FetchPosts);
        }

        public void FetchPrivateDetails()
        {
            r_Composer.UserPrivateDetails(InUserFacade);
        }

        public void FetchUserFriends()
        {
            r_Composer.UserFriends(InUserFacade);
        }
        public void FetchLikedPages()
        {
            r_Composer.LikedPages(InUserFacade);
        }
        public void FetchFavoriteTeams()
        {
            r_Composer.FavoriteTeams(InUserFacade);
        }
        public void FetchPosts()
        {
            r_Composer.Posts(InUserFacade);
        }

        public void PostStatus(string statusText)
        {
            List<PostAdapter> list = InUserFacade.Posts.ToList();

            list.Add(new PostAdapter
            {
                Description = $"{InUserFacade.FirstName} {InUserFacade.LastName} : {statusText}",CreatedTime = DateTime.Now,Location = InUserFacade.Location
            });
            InUserFacade.Posts = list;
            InUserFacade.RealUser.PostStatus(statusText);
        }
    }
}