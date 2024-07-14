using System;
using System.Windows.Forms;
using BasicFacebookFeatures.NewUser;
using BasicFacebookFeatures.Services;
using BasicFacebookFeatures.Adapter;
using System.Collections.Generic;
using System.Linq;

namespace BasicFacebookFeatures
{
    public partial class FormMemoriesPosts : Form
    {
        private readonly MemoriesPostsService r_MemoriesPostsService;

        public FormMemoriesPosts(UserFacade i_UserFacadeProfile)
        {
            InitializeComponent();
            r_MemoriesPostsService = new MemoriesPostsService(i_UserFacadeProfile);
            memoriesPostsServiceBindingSource.DataSource = r_MemoriesPostsService;
            r_MemoriesPostsService.DataLoaded += this.OnDataLoaded;
        }

        private void FormMemoriesPosts_Load(object sender, EventArgs e)
        {
            r_MemoriesPostsService.FetchData();
        }
        
        private void OnDataLoaded()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => memoriesPostsServiceBindingSource.ResetBindings(false)));
            }
            else
            {
                memoriesPostsServiceBindingSource.ResetBindings(false);
            }
        }

        private void buttonShowMemories_Click(object sender, EventArgs e)
        {
            IEnumerable<string> selectedLocation = locationsDataBoundCheckedListBox.CheckedItems.Cast<string>().ToList();
            r_MemoriesPostsService.GetFilteredPosts(
                selectedLocation,
                dateTimePickerStart.Value,
                dateTimePickerFinish.Value);

            if (filteredPostsListBox.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve.");
            }
        }

        private void filteredPostsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PostAdapter selectedPost = filteredPostsListBox.SelectedItem as PostAdapter;

            textBoxSelectedMemory.Text = selectedPost?.ToString() ?? "";
            dateTime.Text = selectedPost?.CreatedTime.ToString() ?? "";
            pictureBox1.ImageLocation = selectedPost?.Post.PictureURL ?? "https://images.app.goo.gl/1fiGGkwrp8ToEiRW8";
        }
        private void toggleCheckAll(Button i_Button, CheckedListBox i_CheckedListBox)
        {
            bool checkAll = i_Button.Text == "Check all";

            for (int i = 0; i < i_CheckedListBox.Items.Count; i++)
            {
                i_CheckedListBox.SetItemChecked(i, checkAll);
            }

            i_Button.Text = checkAll ? "Uncheck all" : "Check all";
        }

        private void buttonCity_Click(object sender, EventArgs e)
        {
            toggleCheckAll(buttonCity, locationsDataBoundCheckedListBox);
        }
    }
}