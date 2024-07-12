using System;
using System.Linq;
using System.Windows.Forms;
using BasicFacebookFeatures.NewUser;
using BasicFacebookFeatures.Services;
using System.Collections.Generic;
using BasicFacebookFeatures.Adapter;

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
            PostAdapter selectedPost = listBoxFoundedMemories.SelectedItem as PostAdapter;

            textBoxSelectedMemory.Text = selectedPost?.ToString()??"";
            dateTime.Text = selectedPost?.CreatedTime.ToString()??"";
            pictureBox1.ImageLocation = selectedPost?.Post.PictureURL?? "https://images.app.goo.gl/1fiGGkwrp8ToEiRW8";
            
        }

        private void buttonShowMemories_Click(object sender, EventArgs e)
        {
            string selectedLocation = comboBoxLocation.SelectedItem.ToString();
            List<PostAdapter>  filteredPosts = r_MemoriesPostsService.GetFilteredPosts(
                selectedLocation,
                dateTimePickerStart.Value,
                dateTimePickerFinish.Value).ToList();

            listBoxFoundedMemories.DataSource = null;
            listBoxFoundedMemories.Items.Clear();
            listBoxFoundedMemories.DataSource = filteredPosts;

            if (listBoxFoundedMemories.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve.");
            }
        }
    }
}