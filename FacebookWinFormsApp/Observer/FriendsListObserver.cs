using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var friends = user.Friends;

            listBoxFriends.Invoke(new Action(() =>
            {
                listBoxFriends.Items.Clear();
                listBoxFriends.DisplayMember = "Name";
                foreach (var friend in friends)
                {
                    listBoxFriends.Items.Add(friend);
                }
            }));
        }
    }
}
