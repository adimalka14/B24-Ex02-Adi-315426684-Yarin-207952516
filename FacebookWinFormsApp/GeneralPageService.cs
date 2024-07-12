using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using BasicFacebookFeatures.NewPost;
using BasicFacebookFeatures.NewUser;
using System.Reflection;
using BasicFacebookFeatures.Adapter;

namespace BasicFacebookFeatures.Services
{
    public class GeneralPageService
    {
        public LoggedUser LoggedInUser { get; set; }
        public readonly UserComposer r_Composer = new UserComposer(new UserBuilder());

        public void FetchPrivateDetails()
        {
            r_Composer.UserPrivateDetails(LoggedInUser);
        }

        public void FetchUserFriends()
        {
            r_Composer.UserFriends(LoggedInUser);
        }
        public void FetchLikedPages()
        {
            r_Composer.LikedPages(LoggedInUser);

        }
        public void FetchFavoriteTeams()
        {
            r_Composer.FavoriteTeams(LoggedInUser);

        }
        public void FetchPosts()
        {
            r_Composer.Posts(LoggedInUser);
        }

        public string GetUserName()
        {
            return $"{LoggedInUser.FirstName} {LoggedInUser.LastName}";
        }

        public string GetProfilePictureUrl()
        {
            return LoggedInUser.PictureLargeUrl;
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
            return LoggedInUser.Friends;
        }

        public IEnumerable<Page> GetLikedPages()
        {
            return LoggedInUser.LikedPages;
        }

        public IEnumerable<Page> GetFavoriteTeams()
        {
            return LoggedInUser.FavoriteTeams;
        }

        public IEnumerable<PostAdapter> GetPosts()
        {
            return LoggedInUser.Posts;
        }

        public void PostStatus(string statusText, string placeID = null, string pictureURL = null, string taggedFriendIDs = null, string link = null, string privacyParameterValue = null)
        {
            LoggedInUser.RealUser.PostStatus(statusText, placeID, pictureURL, taggedFriendIDs, link, privacyParameterValue);
        }
    }
}
