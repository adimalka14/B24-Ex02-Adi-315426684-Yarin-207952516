using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;
using BasicFacebookFeatures.Services;
using BasicFacebookFeatures.NewUser;
using System.ComponentModel;
using System.Linq;
using BasicFacebookFeatures.Adapter;
using System.Collections.Generic;

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



        //private void loadCities()
        //{
        //    string[] cities = r_MatchFriendService.Cities.ToArray();
        //    checkedListBoxCity.Invoke(new Action(() => checkedListBoxCity.Items.AddRange(cities)));
        //}

        //private void loadLikedPage()
        //{

        //    List<PageAdapter> likedPage = r_MatchFriendService.GetLikedPages().ToList();

        //    checkedListBoxLikedPage.Invoke(new Action(() =>
        //    {
        //        checkedListBoxLikedPage.DataSource = likedPage;
        //        checkedListBoxLikedPage.DisplayMember = "Name";
        //    }));
        //}

        //private void loadFavoriteTeams()
        //{
        //    List<PageAdapter> favoriteTeams = r_MatchFriendService.GetFavoriteTeams().ToList();

        //    checkedListBoxFavoriteTeams.Invoke(new Action(() =>
        //    {
        //        checkedListBoxFavoriteTeams.DataSource = favoriteTeams;
        //        checkedListBoxFavoriteTeams.DisplayMember = "Name";
        //    }));
        //}

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (r_MatchFriendService.IsValidAgeRange(hScrollBarMinAge.Value, hScrollBarMaxAge.Value))
            {

                IEnumerable<string> selectedCities = CitiesDataBoundCheckedListBox.CheckedItems.Cast<string>().ToList();
                IEnumerable<PageAdapter> selectedLikedPages = likedPagesDataBoundCheckedListBox.CheckedItems.Cast<PageAdapter>().ToList();
                IEnumerable<PageAdapter> selectedFavoriteTeams = favoriteTeamsDataBoundCheckedListBox.CheckedItems.Cast<PageAdapter>().ToList();

                r_MatchFriendService.GetMatchingFriends(
                        checkBoxMale.Checked,
                        checkBoxFemale.Checked,
                        hScrollBarMinAge.Value,
                        hScrollBarMaxAge.Value,
                        selectedCities,
                        selectedLikedPages,
                        selectedFavoriteTeams);

                //this.Invoke((MethodInvoker)delegate
                //{
                //    listBoxMatchFriends.Items.Clear();
                //    listBoxMatchFriends.DisplayMember = "Name";

                //    foreach (var friend in matchingFriends)
                //    {
                //        listBoxMatchFriends.Items.Add(friend);
                //    }

                if (!matchingFriendListListBox.Items.Cast<UserFacade>().Any())
                {
                    MessageBox.Show("No match friends");
                }
                //});
            }
            else
            {
                MessageBox.Show("Max age must be greater than min age.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hScrollBarMaxAge.Value = 120;
                hScrollBarMinAge.Value = 0;
            }
        }

        private void hScrollBarMinAge_Scroll(object sender, ScrollEventArgs e)
        {
            labelMinAgeValue.Text = hScrollBarMinAge.Value.ToString();
        }

        private void hScrollBarMaxAge_Scroll(object sender, ScrollEventArgs e)
        {
            labelMaxAgeValue.Text = hScrollBarMaxAge.Value.ToString();
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

        //private void listBoxMatchFriends_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    User choosenUser = listBoxMatchFriends.SelectedItem as User;

        //    if (choosenUser != null)
        //    {
        //        r_threadAdapter.Execute(() => showSelectedFriendPrivateDetails(choosenUser));
        //    }
        //}

        private void showSelectedFriendPrivateDetails(User i_ChoosenUser)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => showSelectedFriendPrivateDetails(i_ChoosenUser)));
            }
            else
            {
                pictureProfile.ImageLocation = i_ChoosenUser.PictureLargeURL;
                this.labelUserName.Text = $"{i_ChoosenUser.FirstName} {i_ChoosenUser.LastName}";
                listBoxUserDetails.Items.Clear();
                listBoxUserDetails.Items.Add("Birthday: " + i_ChoosenUser.Birthday);
                listBoxUserDetails.Items.Add("Gender: " + i_ChoosenUser.Gender);
                listBoxUserDetails.Items.Add("Email: " + i_ChoosenUser.Email);
                listBoxUserDetails.Items.Add("Relationship: " + i_ChoosenUser.RelationshipStatus);
                listBoxUserDetails.Items.Add("Location: " + i_ChoosenUser.Location?.Name);
            }
        }

        private void buttonRefreshAll_Click(object sender, EventArgs e)
        {
            OnDataLoaded();
        }
    }
}