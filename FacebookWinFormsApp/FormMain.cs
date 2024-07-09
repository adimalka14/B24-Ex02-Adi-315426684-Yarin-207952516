using System;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures.Services;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private GeneralPageService r_GeneralPageService = new GeneralPageService();
        FormGeneralPage generalPage = null;


        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 25;
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");
            generalPage = new FormGeneralPage(r_GeneralPageService);
            new Thread(autoLoginAndLoadData).Start();
            generalPage.Show();
            generalPage.Tag = this;
            Hide();
        }

        private void autoLoginAndLoadData()
        {
            string accessToken = "EAAMjqqZBOihcBOZBeJESwWpQLiiXH97WFw486x8fmH6q6nUdlnjsjZC6ldOSa9cyoWZCKXPpYiBtjHLskS77edsRjleDsRT5etpKNEMgFSeQTH4YwaT1fp3nLRnXZBUfWZC4SOC3f0K51OMZCMt3QRDjN3Om8HX5GnW2tKTXoIjXKOTXitoiZAMh6ogVhwZDZD";
            LoginResult loginResult = FacebookService.Connect(accessToken);
            r_GeneralPageService.LoggedInUser = loginResult.LoggedInUser;
            generalPage.LoadData();
        }

        private void login()
        {
            try
            {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
