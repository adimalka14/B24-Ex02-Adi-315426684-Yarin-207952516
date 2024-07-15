using System;
using System.Windows.Forms;
using BasicFacebookFeatures.Services;
using BasicFacebookFeatures.NewUser;
using System.Linq;
using System.Threading;
using BasicFacebookFeatures.Adapter;

namespace BasicFacebookFeatures
{
    public partial class FormMatchFriend : Form
    {
        private readonly MatchFriendService r_MatchFriendService;

        public FormMatchFriend(UserFacade i_UserFacadeProfile)
        {
            InitializeComponent();
            r_MatchFriendService = new MatchFriendService(i_UserFacadeProfile);
            matchFriendServiceBindingSource.DataSource = r_MatchFriendService;
            r_MatchFriendService.DataLoaded += this.OnDataLoaded;
        }

        private void FormMatchFriend_Load(object sender, EventArgs e)
        {
            r_MatchFriendService.FetchData();
        }

        private void OnDataLoaded()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => matchFriendServiceBindingSource.ResetBindings(false)));
            }
            else
            {
                matchFriendServiceBindingSource.ResetBindings(false);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            r_MatchFriendService.SelectedCities = CitiesDataBoundCheckedListBox.CheckedItems.Cast<string>().ToList();
            r_MatchFriendService.SelectedLikedPages = likedPagesDataBoundCheckedListBox.CheckedItems.Cast<PageAdapter>().ToList();
            r_MatchFriendService.SelectedFavoriteTeams = favoriteTeamsDataBoundCheckedListBox.CheckedItems.Cast<PageAdapter>().ToList();
            r_MatchFriendService.GetMatchingFriends();
            userFacadeBindingSource.DataSource = r_MatchFriendService.MatchingFriendList;
            if (!matchingFriendListListBox.Items.Cast<UserFacade>().Any())
            {
                MessageBox.Show("No match friends");
            }
        }

        private void checkBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxFemale.Checked && !checkBoxMale.Checked)
            {
                checkBoxFemale.Checked = true;
            }
        }

        private void checkBoxMale_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxMale.Checked && !checkBoxFemale.Checked)
            {
                checkBoxMale.Checked = true;
            }
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
            toggleCheckAll(buttonCity, CitiesDataBoundCheckedListBox);
        }

        private void buttonLikedPage_Click(object sender, EventArgs e)
        {
            toggleCheckAll(buttonLikedPage, likedPagesDataBoundCheckedListBox);
        }

        private void buttonFavoriteTeams_Click(object sender, EventArgs e)
        {
            toggleCheckAll(buttonFavoriteTeams, favoriteTeamsDataBoundCheckedListBox);
        }

        private void buttonRefreshAll_Click(object sender, EventArgs e)
        {
            OnDataLoaded();
        }
    }
}