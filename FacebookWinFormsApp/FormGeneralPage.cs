using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures.Services;
using Facebook;

namespace BasicFacebookFeatures
{
    public partial class FormGeneralPage : Form
    {
        private readonly GeneralPageService r_GeneralPageService;

        public FormGeneralPage(GeneralPageService i_GeneralPageService)
        {
            InitializeComponent();
            r_GeneralPageService = i_GeneralPageService;
            this.Text = "Facebook App";
        }

        public void LoadData()
        {
            new Thread(LoadPrivateDetails).Start();
            new Thread(LoadUserFriends).Start();
            new Thread(LoadLikedPages).Start();
            // LoadAlbums();
            new Thread(LoadFavoriteTeams).Start();
            new Thread(LoadPosts).Start();
        }

        private void LoadPrivateDetails()
        {
            string pictureProfileData = r_GeneralPageService.GetProfilePictureUrl();
            string userName = r_GeneralPageService.GetUserName();

            pictureProfile.Invoke(new Action(() =>
                this.pictureProfile.ImageLocation = pictureProfileData));

            labelUserName.Invoke(new Action(() =>
               this.labelUserName.Text = userName));

            foreach (var detail in r_GeneralPageService.GetUserDetails())
            {
                listBoxUserDetails.Invoke(new Action(() =>
                listBoxUserDetails.Items.Add(detail)));
            }
        }

        private void LoadUserFriends()
        {
            List<User> users = r_GeneralPageService.GetFriends().ToList();

            listBoxFreinds.Invoke(new Action(() =>
            {
                listBoxFreinds.DisplayMember = "Name";
                listBoxFreinds.DataSource = users;
            }));
        }

        private void LoadLikedPages()
        {
            List<Page> likedPages = r_GeneralPageService.GetLikedPages().ToList();

            listBoxLikedPage.Invoke(new Action(() =>
            {
                listBoxLikedPage.DisplayMember = "Name";
                listBoxLikedPage.DataSource = likedPages;
            }));
        }

        private void LoadFavoriteTeams()
        {
            List<Page> favoriteTeams = r_GeneralPageService.GetFavoriteTeams().ToList();

            listBoxFavoriteTeams.Invoke(new Action(() =>
            {
                listBoxFavoriteTeams.DisplayMember = "Name";
                listBoxFavoriteTeams.DataSource = favoriteTeams;
            }));
        }

        private void LoadAlbums()
        {
            listBoxAlbum.Invoke(new Action(() =>
            {
                listBoxAlbum.DisplayMember = "Name";
                listBoxAlbum.DataSource = r_GeneralPageService.GetAlbums().ToList();
            }));
        }

        private void LoadPosts()
        {
            foreach (string post in r_GeneralPageService.GetPosts())
            {
                listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post)));
            }

            listBoxPosts.Invoke(new Action(() =>
            {
                if (listBoxPosts.Items.Count == 0)
                {
                    MessageBox.Show("No Posts to retrieve :(");
                }
            }));
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

        private void buttonSharePost_Click(object sender, EventArgs e)
        {
            if (textBoxStatus.Text != "")
            {
                try
                {
                    r_GeneralPageService.PostStatus(textBoxStatus.Text);
                    MessageBox.Show("Post successfully shared on Facebook!");
                }
                catch (FacebookApiException ex)
                {
                    MessageBox.Show($"{ex.Message}", "Error posting to Facebook:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You can't share empty post", "Error posting to Facebook:", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void listBoxFreinds_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPictureFromSelectedItem<User>(listBoxFreinds, pictureBoxFreind, (i_User) => i_User.PictureNormalURL);
        }

        private void listBoxLikedPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPictureFromSelectedItem<Page>(listBoxLikedPage, pictureBoxLikedPage, (i_Page) => i_Page.PictureNormalURL);
        }

        private void listBoxAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPictureFromSelectedItem<Album>(listBoxAlbum, pictureBoxAlbums, (i_Album) => i_Album.PictureAlbumURL);
        }

        private void listBoxFavoriteTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPictureFromSelectedItem<Page>(listBoxFavoriteTeams, pictureBoxFavoriteTeams, (i_Page) => i_Page.PictureNormalURL);
        }

        private void buttonMemoriesPosts_Click(object sender, EventArgs e)
        {
            if (r_GeneralPageService.LoggedInUser != null)
            {
                FormMemoriesPosts form = new FormMemoriesPosts(r_GeneralPageService.LoggedInUser);
                new Thread(form.LoadData).Start();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("please wait some seconds, and then try again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonMatchingFriend_Click(object sender, EventArgs e)
        {
            if(r_GeneralPageService.LoggedInUser!=null)
            {
                FormMatchFriend form = new FormMatchFriend(r_GeneralPageService.LoggedInUser);
                new Thread(form.LoadData).Start();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("please wait some seconds, and then try again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}