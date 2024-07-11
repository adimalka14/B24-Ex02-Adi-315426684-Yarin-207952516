using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using BasicFacebookFeatures.NewPost;
using BasicFacebookFeatures.NewUser;

namespace BasicFacebookFeatures.Services
{
    public class GeneralPageService
    {
        public LoggedUser LoggedInUser { get; set; }

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
            yield return "Location: " + LoggedInUser.Location;
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
            return LoggedInUser.FavoriteTeams;
        }

        public IEnumerable<PostProxy> GetPosts()
        {
            PostFactory postFactory = new PostFactory();

            foreach (Post post in LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    
                    yield return postFactory.CreatePost("text", post); 
                }
                else if (post.Caption != null)
                {
                    yield return postFactory.CreatePost("image", post);
                }
            }
        }

        public void PostStatus(string statusText, string placeID = null, string pictureURL = null, string taggedFriendIDs = null, string link = null, string privacyParameterValue = null)
        {
            LoggedInUser.RealUser.PostStatus(statusText, placeID, pictureURL, taggedFriendIDs, link, privacyParameterValue);
        }
    }
}
