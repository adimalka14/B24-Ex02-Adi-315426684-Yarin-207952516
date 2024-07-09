using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using BasicFacebookFeatures.Services;

namespace BasicFacebookFeatures
{
    public partial class FormMemoriesPosts : Form
    {
        private readonly MemoriesPostsService r_MemoriesPostsService;

        public FormMemoriesPosts(User i_UserProfile)
        {
            InitializeComponent();
            r_MemoriesPostsService = new MemoriesPostsService(i_UserProfile);
        }

        //private void formMemoriesPosts_Load(object sender, EventArgs e)
        //{
        //    comboBoxLocation.Items.AddRange(r_MemoriesPostsService.GetLocations().ToArray());
        //    comboBoxLocation.SelectedItem = "All locations";
        //}

        public void LoadData()
        {
            string[] locations = r_MemoriesPostsService.GetLocations().ToArray();

            comboBoxLocation.Invoke(new Action(() =>
                {
                    comboBoxLocation.Items.AddRange(locations);
                    comboBoxLocation.SelectedItem = "All locations";

                }
            ));

        }

        private void listBoxFoundedMemories_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post selectedPost = listBoxFoundedMemories.SelectedItem as Post;

            textBoxSelectedMemory.Text = selectedPost?.Message;
            dateTime.Text = selectedPost.CreatedTime.ToString() ?? DateTime.Now.ToString();
            pictureBox1.ImageLocation = selectedPost?.PictureURL;
        }

        private void buttonShowMemories_Click(object sender, EventArgs e)
        {
            string selectedLocation = comboBoxLocation.SelectedItem.ToString();
            var filteredPosts = r_MemoriesPostsService.GetFilteredPosts(
                selectedLocation,
                dateTimePickerStart.Value,
                dateTimePickerFinish.Value);

            listBoxFoundedMemories.Items.Clear();
            listBoxFoundedMemories.DisplayMember = "Type";
            foreach (var post in filteredPosts)
            {
                listBoxFoundedMemories.Items.Add(post);
            }

            if (listBoxFoundedMemories.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve.");
            }
        }
    }
}