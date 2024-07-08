using System;
using System.Windows.Forms;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private FacebookWrapper.LoginResult m_LoginResult;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (m_LoginResult == null)
            {
                login();
            }
        }

        private void login()
        {
            m_LoginResult = FacebookService.Login(

                "883640926898711",
                // requested permissions:
                "email",
                "public_profile",
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
                );
            //"EAAMjqqZBOihcBO3nslv4NOjAbZC2B6ZCKCFzw7XxqLVrv07yribeNi27pndbcWrItDItxNXWyY6XQXe3ZCZB9dQyfYOUzYiY4ZAa4wLukNzTauCxwZBOpU9rK3ZAHettCXVLbNOZCgdzL3Vf9S3poRxx1KFZCZBOHUYrOiRhTsjYX640gIaar26WLQByJs68AZDZD"

            //if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            try
            {
                FormGeneralPage generalPage = new FormGeneralPage(m_LoginResult);
                generalPage.Show();
                generalPage.Tag = this;
                Hide();
                m_LoginResult = null;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}