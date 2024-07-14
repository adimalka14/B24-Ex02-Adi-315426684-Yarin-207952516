using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Threading;
using BasicFacebookFeatures.NewUser;
using BasicFacebookFeatures.Adapter;
using System;

namespace BasicFacebookFeatures.Services
{
    public class GeneralPageService
    {
        public UserFacade InUserFacade { get; set; }
        public readonly UserComposer r_Composer = new UserComposer(new UserBuilder());
        public event Action DataLoaded;


        public void FetchData()
        {
            new Thread(() => FetchPrivateDetails()).Start();
            new Thread(() => FetchUserFriends()).Start();
            new Thread(() => FetchLikedPages()).Start();
            new Thread(() => FetchFavoriteTeams()).Start();
            new Thread(() => FetchPosts()).Start();
        }

        public void FetchPrivateDetails()
        {
            r_Composer.UserPrivateDetails(InUserFacade);
            OnDataLoaded();
        }

        public void FetchUserFriends()
        {
            r_Composer.UserFriends(InUserFacade);
            OnDataLoaded();
        }
        public void FetchLikedPages()
        {
            r_Composer.LikedPages(InUserFacade);
            OnDataLoaded();
        }
        public void FetchFavoriteTeams()
        {
            r_Composer.FavoriteTeams(InUserFacade);
            OnDataLoaded();
        }
        public void FetchPosts()
        {
            r_Composer.Posts(InUserFacade);
            OnDataLoaded();
        }

        private void OnDataLoaded()
        {
            DataLoaded?.Invoke();
        }

        public string GetUserName()
        {
            return $"{InUserFacade.FirstName} {InUserFacade.LastName}";
        }

        public string GetProfilePictureUrl()
        {
            return InUserFacade.PictureLargeUrl;
        }

        public IEnumerable<string> GetUserDetails()
        {
            yield return "Birthday: " + InUserFacade.Birthday;
            yield return "Gender: " + InUserFacade.Gender;
            yield return "Email: " + InUserFacade.Email;
            yield return "Relationship: " + InUserFacade.RelationshipStatus;
            yield return "Location: " + InUserFacade.Location;
        }

        public IEnumerable<UserFacade> GetFriends()
        {
            return InUserFacade.Friends;
        }

        public IEnumerable<PageAdapter> GetLikedPages()
        {
            return InUserFacade.LikedPages;
        }

        public IEnumerable<PageAdapter> GetFavoriteTeams()
        {
            return InUserFacade.FavoriteTeams;
        }

        public IEnumerable<PostAdapter> GetPosts()
        {
            return InUserFacade.Posts;
        }

        public void PostStatus(string statusText)
        {
            InUserFacade.RealUser.PostStatus(statusText);
        }
    }
}
