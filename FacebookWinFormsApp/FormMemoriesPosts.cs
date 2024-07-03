using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    // $G$ DSN-002 (-10) UI and Logic must be seperated.
    public partial class FormMemoriesPosts : Form
    {
        private readonly User r_UserProfile;

        public FormMemoriesPosts(User i_UserProfile)
        {
            this.r_UserProfile = i_UserProfile;
            InitializeComponent();
        }

        private void formMemoriesPosts_Load(object sender, EventArgs e)
        {

            comboBoxLocation.Items.Add("All locations");
            comboBoxLocation.SelectedItem = "All locations";
            foreach (Post post in r_UserProfile.Posts)
            {
                if (post.Place?.Location.City != null)
                {
                    comboBoxLocation.Items.Add(post.Place.Location.City);
                }
            }
        }

        private bool checkDate(Post i_Post)
        {
            return i_Post.CreatedTime.Value.Date >= dateTimePickerStart.Value.Date &&
                   i_Post.CreatedTime.Value.Date <= dateTimePickerFinish.Value.Date;
        }

        private bool checkLocation(Post i_Post, string i_SelectedLocation)
        {
            return i_Post.Place?.Location?.City == i_SelectedLocation;
        }

        private void listBoxFoundedMemories_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post selectedPost = listBoxFoundedMemories.SelectedItem as Post;

            textBoxSelectedMemory.Text = selectedPost?.Message;
            label3.Text = selectedPost?.CreatedTime.ToString();
            pictureBox1.ImageLocation = selectedPost?.PictureURL;
        }

        private void buttonShowMemories_Click(object sender, EventArgs e)
        {
            string selectedLocation = comboBoxLocation.SelectedItem.ToString();

            listBoxFoundedMemories.Items.Clear();
            listBoxFoundedMemories.DisplayMember = "Type";
            foreach (Post post in r_UserProfile.Posts)
            {
                if (selectedLocation == "All locations" || checkLocation(post, selectedLocation))
                {
                    if (checkDate(post))
                    {
                        listBoxFoundedMemories.Items.Add(post);
                    }
                }
            }

            if (listBoxFoundedMemories.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve.");
            }
        }
    }
}