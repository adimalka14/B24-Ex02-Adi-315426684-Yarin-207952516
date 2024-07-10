using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures.Services;
using BasicFacebookFeatures.NewPost;
using Facebook;
using BasicFacebookFeatures.Adapter;
using BasicFacebookFeatures.Observer;

namespace BasicFacebookFeatures
{
    public partial class FormGeneralPage : Form
    {
        private readonly GeneralPageService r_GeneralPageService;
        private readonly IThreadAdapter r_threadAdapter;
        private UserNotifier userNotifier = new UserNotifier();


        public FormGeneralPage(GeneralPageService i_GeneralPageService, IThreadAdapter i_ThreadAdapter)
        {
            InitializeComponent();
            r_GeneralPageService = i_GeneralPageService;
            r_threadAdapter = i_ThreadAdapter;
            this.Text = "Facebook App";
            userNotifier.Attach(new ProfileObserver(pictureProfile, labelUserName));
            userNotifier.Attach(new FriendsListObserver(listBoxFreinds, pictureBoxFreind));
            userNotifier.Attach(new LikedPagesObserver(listBoxLikedPage, pictureBoxLikedPage));
            buttonRefreshAll.Click += buttonRefreshAll_Click;
        }

        public void LoadData()
        {
            r_threadAdapter.Execute(LoadPrivateDetails);
            r_threadAdapter.Execute(LoadUserFriends);
            r_threadAdapter.Execute(LoadLikedPages);
            r_threadAdapter.Execute(LoadFavoriteTeams);
            r_threadAdapter.Execute(LoadPosts);
        }

        private void LoadPrivateDetails()
        {
            userNotifier.User = r_GeneralPageService.LoggedInUser;

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
            foreach (PostProxy post in r_GeneralPageService.GetPosts())
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
            NewPost.PostProxy postProxy = null;
            PostFactory factory = new PostFactory();

            if (tabControlTextPost.SelectedTab == TextPost)
            {
                string text = textBoxText.Text; 
                postProxy = factory.CreateNewPost("text", text);
            }
            else if (tabControlTextPost.SelectedTab == imagePost)
            {
                string imageUrl = textBoxImgUrl.Text; 
                string caption = textBoxImgCaption.Text; 
                postProxy = factory.CreateNewPost("image", caption, imageUrl);
            }

            if (postProxy != null)
            {
                try
                {
                    postProxy.PostToFacebook(r_GeneralPageService);
                    MessageBox.Show("Post was sent successfully!");
                }
                catch (FacebookApiException ex)
                {
                    MessageBox.Show($"{ex.Message}", "Error posting to Facebook:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid post type and fill all required fields.");
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
                r_threadAdapter.Execute(form.LoadData);
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
                FormMatchFriend form = new FormMatchFriend(r_GeneralPageService.LoggedInUser, r_threadAdapter);
                r_threadAdapter.Execute(form.LoadData);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("please wait some seconds, and then try again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRefreshAll_Click(object sender, EventArgs e)
        {
            userNotifier.User = r_GeneralPageService.LoggedInUser;
        }
    }
}