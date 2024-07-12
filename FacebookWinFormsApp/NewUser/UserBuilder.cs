using FacebookWrapper;
using System;
using System.Collections.Generic;
using BasicFacebookFeatures.Adapter;
using BasicFacebookFeatures.NewPost;
using FacebookWrapper.ObjectModel;

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

        public LoggedUser CreateUser()
        {
            LoginResult loginResult = FacebookService.Login(r_appId, m_properties);
            LoggedUser newUser;

            if (loginResult.LoggedInUser!=null)
            {
                newUser = new LoggedUser(loginResult.LoggedInUser);
            }
            else
            {
                throw new Exception("Login failed");
            }

            return newUser;
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
            IEnumerable<Post> userPost = i_User.RealUser.Posts;
            List<PostAdapter> adapterPostList = new List<PostAdapter>();

            foreach (Post post in userPost)
            {
                adapterPostList.Add(new PostAdapter{Post = post,
                    Location = post.Place?.Location.City,
                    CreatedTime = post.CreatedTime.Value.Date
                });
            }

            i_User.Posts = adapterPostList;
            //IEnumerable<Post> userPost = i_User.RealUser.Posts;
            //List<PostProxy> proxyPostList = new List<PostProxy>();
            //PostFactory factory = new PostFactory();

            //foreach (Post post in userPost)
            //{
            //    PostProxy newProxyPost = factory.CreatePost(post.Message == null ? "image" : "text", post);
            //    proxyPostList.Add(newProxyPost); 
            //}

            //i_User.Posts = proxyPostList; 
        }
    }
}