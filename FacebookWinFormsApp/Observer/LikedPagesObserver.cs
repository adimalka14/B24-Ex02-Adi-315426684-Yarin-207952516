using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Observer
{
    public class LikedPagesObserver : IObserver
    {
        private ListBox listBoxLikedPages;
        private PictureBox pictureBoxLikedPage;

        public LikedPagesObserver(ListBox i_ListBoxLikedPages, PictureBox i_PictureBoxLikedPage)
        {
            listBoxLikedPages = i_ListBoxLikedPages;
            pictureBoxLikedPage = i_PictureBoxLikedPage;
        }

        public void Update(User user)
        {
            var likedPages = user.LikedPages;

            listBoxLikedPages.Invoke(new Action(() =>
            {
                listBoxLikedPages.Items.Clear();
                listBoxLikedPages.DisplayMember = "Name";
                foreach (var page in likedPages)
                {
                    listBoxLikedPages.Items.Add(page);
                }
            }));
        }
    }

}
