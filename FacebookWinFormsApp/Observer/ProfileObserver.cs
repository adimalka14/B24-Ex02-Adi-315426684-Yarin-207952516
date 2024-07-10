using FacebookWrapper.ObjectModel;
using System.Windows.Forms;
using System;
using BasicFacebookFeatures.Observer;

public class ProfileObserver : IObserver
{
    private PictureBox pictureProfile;
    private Label labelUserName;

    public ProfileObserver(PictureBox i_PictureProfile, Label i_LabelUserName)
    {
        pictureProfile = i_PictureProfile;
        labelUserName = i_LabelUserName;
    }

    public void Update(User user)
    {
        if (pictureProfile.InvokeRequired)
        {
            pictureProfile.Invoke(new Action(() =>
            {
                pictureProfile.ImageLocation = user.PictureLargeURL;
            }));
        }
        else
        {
            pictureProfile.ImageLocation = user.PictureLargeURL;
        }

        if (labelUserName.InvokeRequired)
        {
            labelUserName.Invoke(new Action(() =>
            {
                labelUserName.Text = $"{user.FirstName} {user.LastName}";
            }));
        }
        else
        {
            labelUserName.Text = $"{user.FirstName} {user.LastName}";
        }
    }
}