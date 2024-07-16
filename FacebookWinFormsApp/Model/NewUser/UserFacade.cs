using System.Collections.Generic;
using BasicFacebookFeatures.Model.Adapter;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Model.NewUser
{
    public class UserFacade
    {
        public  User RealUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public eGender Gender { get; set; }
        public string Email { get; set; }
        public string RelationshipStatus { get; set; }
        public string Location { get; set; }
        public IEnumerable<UserFacade> Friends { get; set; }
        public IEnumerable<PageAdapter> LikedPages { get; set; }
        public IEnumerable<PageAdapter> FavoriteTeams { get; set; }
        public IEnumerable<PostAdapter> Posts { get; set; }
        private string m_PictureLargeUrl;

        public UserFacade(User realUser)
        {
            RealUser = realUser;
        }
        
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public string PictureLargeUrl
        {
            get
            {
                if (m_PictureLargeUrl == null)
                {
                    m_PictureLargeUrl = RealUser.PictureLargeURL;
                }

                return m_PictureLargeUrl;
            }

            set => m_PictureLargeUrl = value;
        }

        public enum eGender
        {
            female = 0,
            male = 1,
            None = 2
        }
    }
}