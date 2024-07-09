using System;
using System.Windows.Forms;
using CefSharp;
using BasicFacebookFeatures.Services;
using FacebookWrapper;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 25;
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (FacebookServiceSingleton.Instance.LoginResult == null)
            {
                await loginAsync();
            }
        }

        private async Task loginAsync()
        {
            try
            {
                // Show loading message
                using (var loadingForm = new LoadingForm())
                {
                    loadingForm.Show();
                    loadingForm.BringToFront();

                    var loginResult = await FacebookServiceSingleton.Instance.LoginAsync(
                        "883640926898711",
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
                    );

                    loadingForm.Close();

                    if (loginResult == null || !string.IsNullOrEmpty(loginResult.ErrorMessage))
                    {
                        throw new Exception(loginResult?.ErrorMessage ?? "Unknown error occurred during login.");
                    }

                    FormGeneralPage generalPage = new FormGeneralPage(loginResult);
                    generalPage.Show();
                    generalPage.Tag = this;
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Perform the Cef shutdown
            Cef.Shutdown();
        }
    }
}
