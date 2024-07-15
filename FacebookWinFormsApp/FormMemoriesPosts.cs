using System;
using System.Windows.Forms;
using BasicFacebookFeatures.NewUser;
using BasicFacebookFeatures.Services;
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
            r_MemoriesPostsService.r_NotifyThread.Finish += this.OnDataLoaded;
            r_MemoriesPostsService.r_NotifyThread.ErrorOccurred += this.showError;
        }

        private void FormMemoriesPosts_Load(object sender, EventArgs e)
        {
            r_MemoriesPostsService.FetchData();
        }

        private void OnDataLoaded()
        {
            this.Invoke(new Action(() => memoriesPostsServiceBindingSource.ResetBindings(false)));
        }

        private void showError(Exception ex)
        {
            this.Invoke(new Action(() =>
            {
                this.Close();
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }));
        }

        private void buttonShowMemories_Click(object sender, EventArgs e)
        {
            r_MemoriesPostsService.CheckedLocations = locationsDataBoundCheckedListBox.CheckedItems.Cast<string>().ToList();
            r_MemoriesPostsService.GetFilteredPosts();
            postAdapterBindingSource.DataSource = r_MemoriesPostsService?.FilteredPosts;
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