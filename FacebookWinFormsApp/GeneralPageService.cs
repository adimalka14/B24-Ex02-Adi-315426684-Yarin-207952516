using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicFacebookFeatures.Services
{
    public class GeneralPageService
    {
        public User LoggedInUser { set; get; }

        public User GetLoggedInUser()
        {
            return LoggedInUser;
        }

        public string GetUserName()
        {
            return $"{LoggedInUser.FirstName} {LoggedInUser.LastName}";
        }

        public string GetProfilePictureUrl()
        {
            return LoggedInUser.PictureLargeURL;
        }

        public IEnumerable<string> GetUserDetails()
        {
            yield return "Birthday: " + LoggedInUser.Birthday;
            yield return "Gender: " + LoggedInUser.Gender;
            yield return "Email: " + LoggedInUser.Email;
            yield return "Relationship: " + LoggedInUser.RelationshipStatus;
            yield return "Location: " + LoggedInUser.Location?.Name;
        }

        public IEnumerable<User> GetFriends()
        {
            return LoggedInUser.Friends.Cast<User>();
        }

        public IEnumerable<Page> GetLikedPages()
        {
            return LoggedInUser.LikedPages.Cast<Page>();
        }

        public IEnumerable<Page> GetFavoriteTeams()
        {
            return LoggedInUser.FavofriteTeams.Cast<Page>();
        }

        public IEnumerable<Album> GetAlbums()
        {
            return LoggedInUser.Albums.Cast<Album>();
        }

        public IEnumerable<string> GetPosts()
        {
            foreach (Post post in LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    yield return post.Message;
                }
                else if (post.Caption != null)
                {
                    yield return post.Caption;
                }
                else
                {
                    yield return $"[{post.Type}]";
                }
            }
        }

        public void PostStatus(string i_Status)
        {
            LoggedInUser.PostStatus(i_Status);
        }
    }
}
