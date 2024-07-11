using System;
using System.Windows.Forms;
using BasicFacebookFeatures.Adapter;
using BasicFacebookFeatures.Services;
using BasicFacebookFeatures.NewUser;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private GeneralPageService r_GeneralPageService = new GeneralPageService();
        private IThreadAdapter r_ThreadAdapter = new ThreadAdapter();
        FormGeneralPage generalPage = null;

        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 25;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");
            generalPage = new FormGeneralPage(r_GeneralPageService, r_ThreadAdapter);
            r_ThreadAdapter.Execute(Init);
            generalPage.Show();
            generalPage.Tag = this;
            Hide();
        }

        public void Init()
        {
            UserComposer composer = new UserComposer(new UserBuilder(r_ThreadAdapter)); // pattern Builder

            try
            {
                LoggedUser user;
                user = composer.CreateUser();
                r_GeneralPageService.LoggedInUser = user;
                generalPage.LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void autoLoginAndLoadData()
        //{
        //    string accessToken = "EAAMjqqZBOihcBOxW9fwDdwTb9E21mkTaHu9bpzgio1YI8lyZBfOsb8ZAr1aAl59SNuIeHsyjy4bMj3eNowYoTGp02Bz2ZAPxuyYnnZBhw8c3mKZBaxhlkgZBKXqHa6piB4DjuR6cDpT19fbPFhEvhZB3xW01K0BhUcP2ZChUn3QKGsv6hHBkin41StunTPQZDZD";
        //    LoginResult loginResult = FacebookService.Connect(accessToken);
        //    r_GeneralPageService.LoggedInUser = loginResult.LoggedInUser;
        //    generalPage.LoadData();
        //}

        //private void login()
        //{
        //    LoginResult loginResult = FacebookService.Login(
        //        "883640926898711",
        //            // requested permissions:
        //            "email",
        //            "public_profile",
        //            "user_age_range",
        //            "user_birthday",
        //            "user_events",
        //            "user_friends",
        //            "user_gender",
        //            "user_hometown",
        //            "user_likes",
        //            "user_link",
        //            "user_location",
        //            "user_photos",
        //            "user_posts",
        //            "user_videos");

        //    r_GeneralPageService.LoggedInUser = loginResult.LoggedInUser;
        //    generalPage.LoadData();
        //}


        //private void login()
        //{
        // try
        //{
        //// Show loading message
        //using (var loadingForm = new LoadingForm())
        //{
        //    loadingForm.Show();
        //    loadingForm.BringToFront();

        //    var loginResult = await FacebookServiceSingleton.Instance.LoginAsync(
        //        "883640926898711",
        //        // requested permissions:
        //        "email",
        //        "public_profile",
        //        "user_age_range",
        //        "user_birthday",
        //        "user_events",
        //        "user_friends",
        //        "user_gender",
        //        "user_hometown",
        //        "user_likes",
        //        "user_link",
        //        "user_location",
        //        "user_photos",
        //        "user_posts",
        //        "user_videos"
        //    );

        //    loadingForm.Close();

        //new Thread(autoLogin).Start();

        //if (r_loginResult == null || !string.IsNullOrEmpty(r_loginResult.ErrorMessage))
        //{
        //    throw new Exception(r_loginResult?.ErrorMessage ?? "Unknown error occurred during login.");
        //}

        //FormGeneralPage generalPage = new FormGeneralPage(r_loginResult);
        //generalPage.Show();
        //generalPage.Tag = this;
        //Hide();
        // }
        // }
        //catch (Exception ex)
        //{
        //   MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //  }
        //}
    }
}
