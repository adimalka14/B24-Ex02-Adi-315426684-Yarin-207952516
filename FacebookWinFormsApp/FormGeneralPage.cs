﻿using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicFacebookFeatures.Services;
using Facebook;

namespace BasicFacebookFeatures
{
    public partial class FormGeneralPage : Form
    {
        private readonly GeneralPageService r_GeneralPageService;

        public FormGeneralPage(LoginResult i_LoginResult)
        {
            InitializeComponent();
            r_GeneralPageService = new GeneralPageService(i_LoginResult.LoggedInUser);
        }

        private async void FormGeneralPage_Load(object sender, EventArgs e)
        {
            using (var loadingForm = new LoadingForm())
            {
                loadingForm.Show();
                loadingForm.BringToFront();

                await Task.Run(() => LoadData());

                loadingForm.Close();
            }
        }

        private void LoadData()
        {
            LoadPrivateDetails();
            LoadUserFriends();
            LoadLikedPages();
            // LoadAlbums();
            LoadFavoriteTeams();
            LoadPosts();
        }

        private void LoadPrivateDetails()
        {
            this.Invoke(new Action(() =>
            {
                this.Text = $"Logged in as {r_GeneralPageService.GetUserName()}";
                pictureProfile.ImageLocation = r_GeneralPageService.GetProfilePictureUrl();
                this.labelUserName.Text = r_GeneralPageService.GetUserName();
                listBoxUserDetails.Items.Clear();
                foreach (var detail in r_GeneralPageService.GetUserDetails())
                {
                    listBoxUserDetails.Items.Add(detail);
                }
            }));
        }

        private void LoadUserFriends()
        {
            this.Invoke(new Action(() =>
            {
                listBoxFreinds.DisplayMember = "Name";
                listBoxFreinds.DataSource = r_GeneralPageService.GetFriends().ToList();
            }));
        }

        private void LoadLikedPages()
        {
            this.Invoke(new Action(() =>
            {
                listBoxLikedPage.DisplayMember = "Name";
                listBoxLikedPage.DataSource = r_GeneralPageService.GetLikedPages().ToList();
            }));
        }

        private void LoadFavoriteTeams()
        {
            this.Invoke(new Action(() =>
            {
                listBoxFavoriteTeams.DisplayMember = "Name";
                listBoxFavoriteTeams.DataSource = r_GeneralPageService.GetFavoriteTeams().ToList();
            }));
        }

        private void LoadAlbums()
        {
            this.Invoke(new Action(() =>
            {
                listBoxAlbum.DisplayMember = "Name";
                listBoxAlbum.DataSource = r_GeneralPageService.GetAlbums().ToList();
            }));
        }

        private void LoadPosts()
        {
            this.Invoke(new Action(() =>
            {
                listBoxPosts.Items.Clear();
                foreach (var post in r_GeneralPageService.GetPosts())
                {
                    listBoxPosts.Items.Add(post);
                }

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
            FormMemoriesPosts form = new FormMemoriesPosts(r_GeneralPageService.GetLoggedInUser());
            form.ShowDialog();
        }

        private void buttonMatchingFriend_Click(object sender, EventArgs e)
        {
            FormMatchFriend form = new FormMatchFriend(r_GeneralPageService.GetLoggedInUser());
            form.ShowDialog();
        }

        private void pictureProfile_Click(object sender, EventArgs e)
        {
            // Add any required code for handling the picture profile click event
        }
    }
}
