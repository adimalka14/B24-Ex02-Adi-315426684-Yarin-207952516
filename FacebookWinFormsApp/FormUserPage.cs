using System;
using System.Windows.Forms;
using BasicFacebookFeatures.Adapter;
using BasicFacebookFeatures.NewUser;
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
            r_GeneralPageService.DataLoaded += this.OnDataLoaded;
        }

        private void FormUserPage_Load(object sender, EventArgs e)
        {
            r_GeneralPageService.FetchData();
        }

        private void OnDataLoaded()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => generalPageServiceBindingSource.ResetBindings(false)));
            }
            else
            {
                generalPageServiceBindingSource.ResetBindings(false);
            }
        }


        private void buttonRefreshAll_Click(object sender, EventArgs e)
        {
            generalPageServiceBindingSource.ResetBindings(false);

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

        private void loadPictureFromSelectedItem<T>(ListBox i_ListBox, PictureBox i_PictureBox, Func<T, string> i_GetUrlFunc)
        {
            if (i_ListBox.SelectedItems.Count == 1 && i_ListBox.SelectedItem is T selectedItem)
            {
                string pictureUrl = i_GetUrlFunc(selectedItem);
                if (pictureUrl != null)
                {
                    i_PictureBox.LoadAsync(pictureUrl);
                }
            }
        }

        private void likedPagesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPictureFromSelectedItem<PageAdapter>(likedPagesListBox, pictureBoxLikedPage, (i_Page) => i_Page.ImgUrl);
        }

        private void friendsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPictureFromSelectedItem<UserFacade>(friendsListBox, pictureBoxFreind, (i_User) => i_User.PictureLargeUrl);
        }

        private void favoriteTeamsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPictureFromSelectedItem<PageAdapter>(favoriteTeamsListBox, pictureBoxFavoriteTeams, (i_Page) => i_Page.ImgUrl);
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
                //r_threadAdapter.Execute(form.LoadData);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("please wait some seconds, and then try again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}