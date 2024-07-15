using System;
using System.Windows.Forms;

using BasicFacebookFeatures.Services;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormUserPage : Form
    {
        private readonly GeneralPageService r_GeneralPageService;

        public FormUserPage(GeneralPageService i_GeneralPageService)
        {
            InitializeComponent();
            r_GeneralPageService = i_GeneralPageService;
            generalPageServiceBindingSource.DataSource = r_GeneralPageService;
            r_GeneralPageService.r_NotifyThread.Finish += OnDataLoaded;
            r_GeneralPageService.r_NotifyThread.ErrorOccurred += showError;
        }

        private void FormUserPage_Load(object sender, EventArgs e)
        {
            r_GeneralPageService.FetchData();
        }

        private void OnDataLoaded()
        {
            this.Invoke(new Action(() =>
            {
                    if (r_GeneralPageService.InUserFacade?.Friends != null)
                    {
                        userFacadeBindingSource.DataSource = r_GeneralPageService.InUserFacade.Friends;
                    }
                  
                    if (r_GeneralPageService.InUserFacade?.FavoriteTeams != null)
                    {
                        pageAdapterBindingSource.DataSource = r_GeneralPageService.InUserFacade.FavoriteTeams;
                    }
                    
                    if (r_GeneralPageService.InUserFacade?.LikedPages != null)
                    {
                        pageAdapterBindingSource.DataSource = r_GeneralPageService.InUserFacade.LikedPages;
                    }

                    userFacadeBindingSource.ResetBindings(false);
                    pageAdapterBindingSource.ResetBindings(false);
                    generalPageServiceBindingSource.ResetBindings(false);
            }));
        }

        private void showError(Exception ex)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)));
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
                FormMatchFriend form = new FormMatchFriend(r_GeneralPageService.InUserFacade);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("please wait some seconds, and then try again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSharePost_Click(object sender, EventArgs e)
        {
            try
            {
                r_GeneralPageService.PostStatus(textBoxText.Text);
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
            if (r_GeneralPageService.InUserFacade != null)
            {
                FormMemoriesPosts form = new FormMemoriesPosts(r_GeneralPageService.InUserFacade);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("please wait some seconds, and then try again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    pageAdapterBindingSource.DataSource = r_GeneralPageService.InUserFacade.LikedPages;
                    break;
                case 1:
                    pageAdapterBindingSource.DataSource = r_GeneralPageService.InUserFacade.FavoriteTeams;
                    break;
            }
        }

        private void buttonRefreshAll_Click(object sender, EventArgs e)
        {
            userFacadeBindingSource.ResetBindings(false);
            pageAdapterBindingSource.ResetBindings(false);
            generalPageServiceBindingSource.ResetBindings(false);
        }
    }
}