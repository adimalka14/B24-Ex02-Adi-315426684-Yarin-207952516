using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    // $G$ DSN-999 (-3) setting display name every time a method is called is redundant.
    // $G$ DSN-999 (-20) UI and Logic must be seperated.
    public partial class FormGeneralPage : Form
    {
        private readonly User r_LoggedInUser;

        public FormGeneralPage(FacebookWrapper.LoginResult i_LoginResult)
        {
            InitializeComponent();
            r_LoggedInUser = i_LoginResult.LoggedInUser;
        }

        private void formGeneralPage_Load(object sender, EventArgs e)
        {
            privateDetailsFetch();
            userFriendsFetch();
            likedPagesFetch();
            //albumsFetch();
            favoriteTeamsFetch();
            PostsFetch();
        }

        private void privateDetailsFetch()
        {
            // $G$ DSN-001 (-5) Exiting login screen throws an exception which is not caught.
                this.Text = $"Logged in as {r_LoggedInUser.Name}";
                pictureProfile.ImageLocation = r_LoggedInUser.PictureLargeURL;
                this.labelUserName.Text = $"{r_LoggedInUser.FirstName} {r_LoggedInUser.LastName}";
                listBoxUserDetails.Items.Clear();
                listBoxUserDetails.Items.Add("Birthday: " + r_LoggedInUser.Birthday);
                listBoxUserDetails.Items.Add("Gender: " + r_LoggedInUser.Gender);
                listBoxUserDetails.Items.Add("Email: " + r_LoggedInUser.Email);
                listBoxUserDetails.Items.Add("Relationship: " + r_LoggedInUser.RelationshipStatus);
                listBoxUserDetails.Items.Add("Location: " + r_LoggedInUser.Location?.Name);
        }

        private void userFriendsFetch()
        {
            listBoxFreinds.DisplayMember = "Name";
            listBoxFreinds.DataSource = r_LoggedInUser.Friends;
        }

        private void likedPagesFetch()
        {
            listBoxLikedPage.DisplayMember = "Name";
            listBoxLikedPage.DataSource = r_LoggedInUser.LikedPages;
        }

        private void favoriteTeamsFetch()
        {
            listBoxFavoriteTeams.DisplayMember = "Name";
            listBoxFavoriteTeams.DataSource = r_LoggedInUser.FavofriteTeams;
        }

        private void albumsFetch()
        {
            listBoxAlbum.DisplayMember = "Name";
            listBoxAlbum.DataSource = r_LoggedInUser.Albums;
        }

        private void PostsFetch()
        {
            listBoxPosts.Items.Clear();
            foreach (Post post in r_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    listBoxPosts.Items.Add($"[{post.Type}]");
                }
            }

            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Do you want logout?", "logout", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
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
                    r_LoggedInUser.PostStatus(textBoxStatus.Text);
                    MessageBox.Show("Post successfully shared on Facebook!");
                }
                catch (FacebookApiException ex)
                {
                    MessageBox.Show($" {ex.Message}", "Error posting to Facebook:", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You can't share empty post", "Error posting to Facebook:", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
            FormMemoriesPosts form = new FormMemoriesPosts(r_LoggedInUser);
            form.ShowDialog();
        }

        private void buttonMatchingFriend_Click(object sender, EventArgs e)
        {
            FormMatchFriend form = new FormMatchFriend(r_LoggedInUser);
            form.ShowDialog();
        }
    }
}