using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicFacebookFeatures.Services
{
    public class GeneralPageService
    {
        private readonly User r_LoggedInUser;

        public GeneralPageService(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
        }

        public User GetLoggedInUser()
        {
            return r_LoggedInUser;
        }

        public string GetUserName()
        {
            return $"{r_LoggedInUser.FirstName} {r_LoggedInUser.LastName}";
        }

        public string GetProfilePictureUrl()
        {
            return r_LoggedInUser.PictureLargeURL;
        }

        public IEnumerable<string> GetUserDetails()
        {
            yield return "Birthday: " + r_LoggedInUser.Birthday;
            yield return "Gender: " + r_LoggedInUser.Gender;
            yield return "Email: " + r_LoggedInUser.Email;
            yield return "Relationship: " + r_LoggedInUser.RelationshipStatus;
            yield return "Location: " + r_LoggedInUser.Location?.Name;
        }

        public IEnumerable<User> GetFriends()
        {
            return r_LoggedInUser.Friends.Cast<User>();
        }

        public IEnumerable<Page> GetLikedPages()
        {
            return r_LoggedInUser.LikedPages.Cast<Page>();
        }

        public IEnumerable<Page> GetFavoriteTeams()
        {
            return r_LoggedInUser.FavofriteTeams.Cast<Page>();
        }

        public IEnumerable<Album> GetAlbums()
        {
            return r_LoggedInUser.Albums.Cast<Album>();
        }

        public IEnumerable<string> GetPosts()
        {
            foreach (Post post in r_LoggedInUser.Posts)
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
            r_LoggedInUser.PostStatus(i_Status);
        }
    }
}
