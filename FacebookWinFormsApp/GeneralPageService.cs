using System;
using System.Collections.Generic;
using System.Linq;
using BasicFacebookFeatures.Adapter;
using BasicFacebookFeatures.NewUser;

namespace BasicFacebookFeatures.Services
{
    public class GeneralPageService
    {
        public UserFacade InUserFacade { get; set; }
        public readonly UserComposer r_Composer = new UserComposer(new UserBuilder());
        //public event Action DataLoaded;
        public readonly NotifyThread r_NotifyThread = new NotifyThread();

        public void FetchData()
        {
            r_NotifyThread.SafeExecute(FetchPrivateDetails);
            r_NotifyThread.SafeExecute(FetchUserFriends);
            r_NotifyThread.SafeExecute(FetchLikedPages);
            r_NotifyThread.SafeExecute(FetchFavoriteTeams);
            r_NotifyThread.SafeExecute(FetchPosts);

            //new Thread(() => FetchPrivateDetails()).Start();
            //new Thread(() => FetchUserFriends()).Start();
            //new Thread(() => FetchLikedPages()).Start();
            //new Thread(() => FetchFavoriteTeams()).Start();
            //new Thread(() => FetchPosts()).Start();
        }

        public void FetchPrivateDetails()
        {
            r_Composer.UserPrivateDetails(InUserFacade);
            //OnDataLoaded();
        }

        public void FetchUserFriends()
        {
            r_Composer.UserFriends(InUserFacade);
            //OnDataLoaded();
        }
        public void FetchLikedPages()
        {
            r_Composer.LikedPages(InUserFacade);
            //OnDataLoaded();
        }
        public void FetchFavoriteTeams()
        {
            r_Composer.FavoriteTeams(InUserFacade);
            //OnDataLoaded();
        }
        public void FetchPosts()
        {
            r_Composer.Posts(InUserFacade);
            //OnDataLoaded();
        }

        //private void OnDataLoaded()
        //{
        //    DataLoaded?.Invoke();
        //}

        public void PostStatus(string statusText)
        {
            List<PostAdapter> list = InUserFacade.Posts.ToList();
            list.Add(new PostAdapter{Description = $"{InUserFacade.FirstName} {InUserFacade.LastName} : {statusText}",CreatedTime = DateTime.Now,Location = "Zanoah"});
            InUserFacade.Posts = list;
            InUserFacade.RealUser.PostStatus(statusText);
        }
    }
}
