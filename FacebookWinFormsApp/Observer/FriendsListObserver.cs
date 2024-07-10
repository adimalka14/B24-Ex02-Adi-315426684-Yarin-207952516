using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Observer
{
    public class FriendsListObserver : IObserver
    {
        private ListBox listBoxFriends;
        private PictureBox pictureBoxFriend;

        public FriendsListObserver(ListBox i_ListBoxFriends, PictureBox i_PictureBoxFriend)
        {
            listBoxFriends = i_ListBoxFriends;
            pictureBoxFriend = i_PictureBoxFriend;
        }

        public void Update(User user)
        {
            var friends = user.Friends.ToList();

            listBoxFriends.Invoke(new Action(() =>
            {
                listBoxFriends.DisplayMember = "Name";
                listBoxFriends.DataSource = null;  // Clear existing data source
                listBoxFriends.DataSource = friends;
            }));
        }
    }
}