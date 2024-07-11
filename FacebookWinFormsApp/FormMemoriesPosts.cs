using System;
using System.Linq;
using System.Windows.Forms;
using BasicFacebookFeatures.NewPost;
using BasicFacebookFeatures.NewUser;
using FacebookWrapper.ObjectModel;
using BasicFacebookFeatures.Services;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public partial class FormMemoriesPosts : Form
    {
        private readonly MemoriesPostsService r_MemoriesPostsService;

        public FormMemoriesPosts(LoggedUser i_UserProfile)
        {
            InitializeComponent();
            r_MemoriesPostsService = new MemoriesPostsService(i_UserProfile);
        }

        public void LoadData()
        {
            string[] locations = r_MemoriesPostsService.GetLocations().ToArray();

            comboBoxLocation.Invoke(new Action(() =>
                {
                    comboBoxLocation.Items.AddRange(locations);
                    comboBoxLocation.SelectedItem = "All locations";
                }));
        }

        private void listBoxFoundedMemories_SelectedIndexChanged(object sender, EventArgs e)
        {
            PostProxy selectedPost = listBoxFoundedMemories.SelectedItem as PostProxy;

            textBoxSelectedMemory.Text = selectedPost.Text;
            dateTime.Text = selectedPost.CreatedTime.ToString();

            ImagePostProxy imagePost = selectedPost as ImagePostProxy;
            if (imagePost != null)
            {
                pictureBox1.ImageLocation = imagePost.imageUrl;
            }
        }

        private void buttonShowMemories_Click(object sender, EventArgs e)
        {
            string selectedLocation = comboBoxLocation.SelectedItem.ToString();
            List<PostProxy>  filteredPosts = r_MemoriesPostsService.GetFilteredPosts(
                selectedLocation,
                dateTimePickerStart.Value,
                dateTimePickerFinish.Value).ToList();

            listBoxFoundedMemories.Items.Clear();
            listBoxFoundedMemories.DataSource = filteredPosts;

            if (listBoxFoundedMemories.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve.");
            }
        }
    }
}