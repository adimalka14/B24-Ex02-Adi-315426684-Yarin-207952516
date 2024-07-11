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

        private readonly IThreadAdapter r_ThreadAdapter;

        public UserBuilder(IThreadAdapter i_ThreadAdapter)
        {
            r_ThreadAdapter = i_ThreadAdapter;
        }

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

    }
}
