using System;
using System.Windows.Forms;
using BasicFacebookFeatures.ViewModel;
using FacebookWrapper;

namespace BasicFacebookFeatures.View
{
    public partial class FormUserPage : Form
    {
        private readonly UserPageService r_UserPageService;
        private readonly object lockObject = new object();

        public FormUserPage(UserPageService i_UserPageService)
        {
            InitializeComponent();
            r_UserPageService = i_UserPageService;
            generalPageServiceBindingSource.DataSource = r_UserPageService;
            r_UserPageService.r_NotifyThread.Finish += OnDataLoaded;
            r_UserPageService.r_NotifyThread.ErrorOccurred += showError;
        }

        private void FormUserPage_Load(object sender, EventArgs e)
        {
            r_UserPageService.FetchData();
        }

        private void OnDataLoaded()
        {
            lock (lockObject)
            {
                this.Invoke(new Action(() =>
                {
                    if (r_UserPageService.InUserFacade?.Friends != null)
                    {
                        userFacadeBindingSource.DataSource = r_UserPageService.InUserFacade.Friends;
                        userFacadeBindingSource.ResetBindings(false);
                    }

                    if (r_UserPageService.InUserFacade?.FavoriteTeams != null)
                    {
                        favoriteTeamsbindingSource.DataSource = r_UserPageService.InUserFacade.FavoriteTeams;
                    }

                    if (r_UserPageService.InUserFacade?.LikedPages != null)
                    {
                        likedPagesBindingSource.DataSource = r_UserPageService.InUserFacade.LikedPages;
                    }

                    generalPageServiceBindingSource.ResetBindings(false);
                }));
            }
        }

        private void showError(Exception ex)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => showError(ex)));
            }
            else
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FormMatchFriend form = new FormMatchFriend(r_UserPageService.InUserFacade);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"please wait some seconds, and then try again. {ex.Message}", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSharePost_Click(object sender, EventArgs e)
        {
            try
            {
                r_UserPageService.PostStatus(textBoxText.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want logout?", "logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                FacebookService.Logout();
                var formMain = (FormMain)Tag;
                formMain.Show();
                Close();
            }
            else
            {
                this.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (r_UserPageService.InUserFacade != null)
            {
                FormMemoriesPosts form = new FormMemoriesPosts(r_UserPageService.InUserFacade);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("please wait some seconds, and then try again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRefreshAll_Click(object sender, EventArgs e)
        {
            generalPageServiceBindingSource.ResetBindings(false);
        }
    }
}