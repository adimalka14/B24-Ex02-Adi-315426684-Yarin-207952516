using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Linq;

namespace BasicFacebookFeatures.NewUser
{
    public class LoggedUser
    {
        public  User RealUser { get; set; }
        private string m_firstName;
        private string m_lastName;
        private string m_birthday;
        private string m_gender;
        private string m_email;
        private string m_relationshipStatus;
        private string m_location;
        private string m_pictureLargeURL;
        private IEnumerable<User> m_friends;
        private IEnumerable<Page> m_likedPages;
        private IEnumerable<Page> m_favoriteTeams;
        private IEnumerable<Post> m_posts;

        public LoggedUser(User realUser)
        {
            RealUser = realUser;
        }

        public string FirstName
        {
            get
            {
                if (m_firstName == null)
                {
                    m_firstName = RealUser.FirstName;
                }
                return m_firstName;
            }
        }

        public string LastName
        {
            get
            {
                if (m_lastName == null)
                {
                    m_lastName = RealUser.LastName;
                }
                return m_lastName;
            }
        }

        public string Birthday
        {
            get
            {
                if (m_birthday == null)
                {
                    m_birthday = RealUser.Birthday;
                }
                return m_birthday;
            }
        }

        public string Gender
        {
            get
            {
                if (m_gender == null)
                {
                    m_gender = RealUser.Gender.ToString();
                }
                return m_gender;
            }
        }

        public string Email
        {
            get
            {
                if (m_email == null)
                {
                    m_email = RealUser.Email;
                }
                return m_email;
            }
        }

        public string RelationshipStatus
        {
            get
            {
                if (m_relationshipStatus == null)
                {
                    m_relationshipStatus = RealUser.RelationshipStatus.ToString();
                }
                return m_relationshipStatus;
            }
        }

        public string Location
        {
            get
            {
                if (m_location == null)
                {
                    m_location = RealUser.Location.Name;
                }
                return m_location;
            }
        }

        public string PictureLargeURL
        {
            get
            {
                if (m_pictureLargeURL == null)
                {
                    m_pictureLargeURL = RealUser.PictureLargeURL;
                }
                return m_pictureLargeURL;
            }
        }

        public IEnumerable<User> Friends
        {
            get
            {
                if (m_friends == null)
                {
                    m_friends = RealUser.Friends.Cast<User>();
                }
                return m_friends;
            }
        }

        public IEnumerable<Page> LikedPages
        {
            get
            {
                if (m_likedPages == null)
                {
                    m_likedPages = RealUser.LikedPages;
                }
                return m_likedPages;
            }
        }

        public IEnumerable<Page> FavoriteTeams
        {
            get
            {
                if (m_favoriteTeams == null)
                {
                    m_favoriteTeams = RealUser.FavofriteTeams;
                }
                return m_favoriteTeams;
            }
        }

        public IEnumerable<Post> Posts
        {
            get
            {
                if (m_posts == null)
                {
                    m_posts = RealUser.Posts;
                }
                return m_posts;
            }
        }
    }
}
