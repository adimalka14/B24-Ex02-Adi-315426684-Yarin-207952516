using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace BasicFacebookFeatures.NewUser
{
    public class LoggedUser
    {
        public  User RealUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string RelationshipStatus { get; set; }
        public string Location { get; set; }
        public string PictureLargeUrl { get; set; }
        public IEnumerable<User> Friends { get; set; }
        public IEnumerable<Page> LikedPages { get; set; }
        public IEnumerable<Page> FavoriteTeams { get; set; }
        public IEnumerable<Post> Posts { get; set; }

        public LoggedUser(User realUser)
        {
            RealUser = realUser;
        }
    }
}