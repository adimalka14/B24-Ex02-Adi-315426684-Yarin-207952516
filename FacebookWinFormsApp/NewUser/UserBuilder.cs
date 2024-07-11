using BasicFacebookFeatures.Adapter;
using FacebookWrapper;
using System;

namespace BasicFacebookFeatures.NewUser
{
    public class UserBuilder : IUserBuilder
    {
        private readonly string r_appId = "883640926898711"; //myAppId
        private string[] m_properties =
        {
            // requested permissions:
            "email",
            "public_profile",
            "user_age_range",
            "user_birthday",
            "user_events",
            "user_friends",
            "user_gender",
            "user_hometown",
            "user_likes",
            "user_link",
            "user_location",
            "user_photos",
            "user_posts",
            "user_videos"
    };

        private readonly IThreadAdapter r_ThreadAdapter = new ThreadAdapter();

        public LoggedUser CreateUser()
        {
            LoginResult loginResult = FacebookService.Login(r_appId, m_properties);
            if (loginResult!=null)
            {
                LoggedUser newUser = new LoggedUser(loginResult.LoggedInUser);
                return newUser;
            }
            else
            {
                throw new Exception("Login failed");
            }
        }

        public void BuildPrivateDetails(LoggedUser i_User)
        {
            i_User.FirstName = i_User.RealUser.FirstName;
            i_User.LastName = i_User.RealUser.LastName;
            i_User.Birthday = i_User.RealUser.Birthday;
            i_User.Email = i_User.RealUser.Email;
            i_User.PictureLargeUrl = i_User.RealUser.PictureLargeURL;
            i_User.Location = i_User.RealUser.Location.Name;
            i_User.Gender = i_User.RealUser.Gender.ToString();
            i_User.RelationshipStatus = i_User.RealUser.RelationshipStatus.ToString();
        }

        public void BuildUserFriends(LoggedUser i_User)
        {
            i_User.Friends = i_User.RealUser.Friends;
        }
        public void BuildLikedPages(LoggedUser i_User)
        {
            i_User.LikedPages = i_User.RealUser.LikedPages;
        }
        public void BuildFavoriteTeams(LoggedUser i_User)
        {
            i_User.FavoriteTeams = i_User.RealUser.FavofriteTeams;
        }
        public void BuildPosts(LoggedUser i_User)
        {
            i_User.Posts = i_User.RealUser.Posts;
        }
    }
}