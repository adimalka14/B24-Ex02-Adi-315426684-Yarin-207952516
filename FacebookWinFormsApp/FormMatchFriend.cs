using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormMatchFriend : Form
    {
        // $G$ DSN-003 (-10) UI and Logic must be seperated.
        public readonly User r_UserProfile;

        public FormMatchFriend(User i_UserProfile)
        {
            this.r_UserProfile = i_UserProfile;
            InitializeComponent();
        }

        private void formMatchFriend_Load(object sender, EventArgs e)
        {
            checkedListBoxCity.Items.Add(r_UserProfile.Location?.Name);
            foreach (User friend in r_UserProfile.Friends)
            {
                if (friend.Location != null)
                {
                    checkedListBoxCity.Items.Add(friend.Location.Name);
                }
            }

            checkedListBoxLikedPage.DataSource = r_UserProfile.LikedPages;
            checkedListBoxLikedPage.DisplayMember = "Name";
            checkedListBoxFavoriteTeams.DataSource = r_UserProfile.FavofriteTeams;
            checkedListBoxFavoriteTeams.DisplayMember = "Name";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (checkValidkAgeRange())
            {
                listBoxMatchFriends.Items.Clear();
                listBoxMatchFriends.DisplayMember = "Name";
                Dictionary<User, int> friendsMatchCount = new Dictionary<User, int>();
                foreach (User friend in r_UserProfile.Friends)
                {
                    if (checkGenderFreind(friend.Gender.Value)
                        && checkAgeFreind(friend.Birthday)
                        && checkCityFriend(friend.Location?.Name)
                        && checkLikedPageFriend(friend.LikedPages.ToList())
                        && checkFavoriteTeamsFriend(friend.FavofriteTeams.ToList()))
                    {
                        listBoxMatchFriends.Items.Add(friend);
                    }
                }

                if (listBoxMatchFriends.Items.Count == 0)
                {
                    MessageBox.Show("No match friends");
                }
            }
        }

        private bool checkValidkAgeRange()
        {
            bool vaildRange = hScrollBarMaxAge.Value >= hScrollBarMinAge.Value;

            if (!vaildRange)
            {
                MessageBox.Show("Max age must be greater than min age.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hScrollBarMaxAge.Value = 120;
                hScrollBarMinAge.Value = 0;
            }

            return vaildRange;
        }

        private bool checkGenderFreind(User.eGender i_UserGender)
        {
            bool matchGender = false;

            if (i_UserGender == User.eGender.male && checkBoxMale.Checked == true)
            {
                matchGender = true;
            }
            else if (i_UserGender == User.eGender.female && checkBoxFemale.Checked == true)
            {
                matchGender = true;
            }

            return matchGender;
        }

        private bool checkAgeFreind(string i_FreindBirthday)
        {
            DateTime freindBirthDate = DateTime.ParseExact(i_FreindBirthday, "MM/dd/yyyy", null);
            int friendAge = DateTime.Today.Year - freindBirthDate.Year;

            return friendAge <= hScrollBarMaxAge.Value && friendAge >= hScrollBarMinAge.Value;
        }

        private bool checkCityFriend(string i_FriendCity)
        {
            bool isMatchCity = false;
            int checkedCityCount = checkedListBoxCity.CheckedItems.Count;

            for (int i = 0; i < checkedCityCount; i++)
            {
                string city = checkedListBoxCity.CheckedItems[i].ToString();
                if (i_FriendCity == city)
                {
                    isMatchCity = true;
                    break;
                }
            }

            return isMatchCity || checkedCityCount == 0;
        }

        private bool checkLikedPageFriend(List<Page> i_FriendLikedPages)
        {
            bool isAnyChecked = checkedListBoxLikedPage.CheckedItems.Count > 0;
            bool foundMatch = false;

            foreach (Page checkedItem in checkedListBoxLikedPage.CheckedItems)
            {
                foreach (Page page in i_FriendLikedPages)
                {
                    if (page.Name == checkedItem.Name)
                    {
                        foundMatch = true;
                        break;
                    }
                }

                if (foundMatch)
                {
                    break;
                }
            }

            return foundMatch || !isAnyChecked;
        }

        private bool checkFavoriteTeamsFriend(List<Page> i_FavoriteTeams)
        {
            bool isAnyChecked = checkedListBoxFavoriteTeams.CheckedItems.Count > 0;
            bool foundMatch = false;

            foreach (Page checkedItem in checkedListBoxFavoriteTeams.CheckedItems)
            {
                foreach (Page page in i_FavoriteTeams)
                {
                    if (page.Name == checkedItem.Name)
                    {
                        foundMatch = true;
                        break;
                    }
                }

                if (foundMatch)
                {
                    break;
                }
            }

            return foundMatch || !isAnyChecked;
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
            toggleCheckAll(buttonCity, checkedListBoxCity);
        }

        private void buttonLikedPage_Click(object sender, EventArgs e)
        {
            toggleCheckAll(buttonLikedPage, checkedListBoxLikedPage);
        }

        private void buttonFavoriteTeams_Click(object sender, EventArgs e)
        {
            toggleCheckAll(buttonFavoriteTeams, checkedListBoxFavoriteTeams);
        }

        private void listBoxMatchFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            User choosenUser = listBoxMatchFriends.SelectedItem as User;

            if (choosenUser != null)
            {
                showSelectedFriendPrivateDetails(choosenUser);
            }
        }

        private void showSelectedFriendPrivateDetails(User i_ChoosenUser)
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
}