using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using BasicFacebookFeatures.Model.Adapter;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Model.NewUser
{
    public class UserBuilder : IUserBuilder
    {
        private readonly string r_appId = "883640926898711";//////myAppId
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

        public UserFacade CreateUser()
        {
            LoginResult loginResult = FacebookService.Login(r_appId, m_properties);
            UserFacade newUserFacade;

            if (loginResult.LoggedInUser!=null)
            {
                newUserFacade = new UserFacade(loginResult.LoggedInUser);
            }
            else
            {
                throw new Exception("Login failed");
            }

            return newUserFacade;
        }

        public void BuildPrivateDetails(UserFacade i_UserFacade)
        {
            i_UserFacade.FirstName = i_UserFacade.RealUser.FirstName;
            i_UserFacade.LastName = i_UserFacade.RealUser.LastName;
            i_UserFacade.Birthday = i_UserFacade.RealUser.Birthday;
            i_UserFacade.Email = i_UserFacade.RealUser.Email;
            i_UserFacade.PictureLargeUrl = i_UserFacade.RealUser.PictureLargeURL;
            i_UserFacade.Location = i_UserFacade.RealUser.Location.Name;
            i_UserFacade.Gender = i_UserFacade.RealUser.Gender.HasValue
                ? (UserFacade.eGender)i_UserFacade.RealUser.Gender.Value
                : UserFacade.eGender.None;
            i_UserFacade.RelationshipStatus = i_UserFacade.RealUser.RelationshipStatus.ToString();
        }

        public void BuildUserFriends(UserFacade i_UserFacade)
        {
            List<UserFacade> friends = new List<UserFacade>();

            foreach (User friend in i_UserFacade.RealUser.Friends)
            {
                UserFacade friendFacade = new UserFacade(friend)
                {
                    FirstName = friend.FirstName ?? string.Empty,
                    LastName = friend.LastName ?? string.Empty,
                    Birthday = friend.Birthday ?? string.Empty,
                    Email = friend.Email ?? string.Empty,
                    Location = friend.Location?.Name ?? string.Empty,
                    Gender = friend.Gender.HasValue ? (UserFacade.eGender)friend.Gender.Value : UserFacade.eGender.None,
                    RelationshipStatus = friend.RelationshipStatus.HasValue ? friend.RelationshipStatus.Value.ToString() : string.Empty,
                };

                new Thread(() => friendFacade.LikedPages = getLikedPages(friend)).Start();
                new Thread(() => friendFacade.FavoriteTeams = getFavoriteTeams(friend)).Start();
                new Thread(() => friendFacade.Posts = getPosts(friend)).Start();
                friends.Add(friendFacade);
            }

            i_UserFacade.Friends = friends;
        }

        public void BuildLikedPages(UserFacade i_UserFacade)
        {
            i_UserFacade.LikedPages = getLikedPages(i_UserFacade.RealUser);
        }

        public void BuildFavoriteTeams(UserFacade i_UserFacade)
        {
            i_UserFacade.FavoriteTeams = getFavoriteTeams(i_UserFacade.RealUser);
        }

        public void BuildPosts(UserFacade i_UserFacade)
        {
            i_UserFacade.Posts = getPosts(i_UserFacade.RealUser);
        }

        private List<PageAdapter> getLikedPages(User i_User)
        {
            return i_User.LikedPages?.Select(page => new PageAdapter { Page = page, Id = page.Id }).ToList() ?? new List<PageAdapter>();
        }

        private List<PageAdapter> getFavoriteTeams(User i_User)
        {
            return i_User.FavofriteTeams?.Select(page => new PageAdapter { Page = page, Id = page.Id }).ToList() ?? new List<PageAdapter>();
        }

        private List<PostAdapter> getPosts(User i_User)
        {
            return i_User.Posts?.Select(post => new PostAdapter
            {
                Post = post,
                Location = post.Place?.Location.City,
                CreatedTime = post.CreatedTime?.Date ?? DateTime.MinValue,
                Description = getText(post)
            }).ToList() ?? new List<PostAdapter>();
        }

        private string getText(Post i_Post)
        {
            string stringResult;

            if (i_Post.Message != null)
            {
                stringResult = string.Format($"{i_Post.From?.Name ?? "-"}: [{i_Post.Type}] {i_Post.Message}");
            }
            else if (i_Post.Caption != null)
            {
                stringResult = string.Format($"{i_Post.From?.Name ?? "-"}: [{i_Post.Type}] {i_Post.Caption}");
            }
            else
            {
                stringResult = string.Format($"{i_Post.From?.Name ?? "-"}: [{i_Post.Type}]");
            }

            return stringResult;
        }
    }
}