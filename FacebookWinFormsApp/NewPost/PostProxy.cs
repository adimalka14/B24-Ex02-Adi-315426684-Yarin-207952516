using System;
using BasicFacebookFeatures.Services;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.NewPost
{
    public abstract class PostProxy
    {
        public Post RealPost { get; set; }
        public string Text { get; set; }
        public string Location { get; set; }
        public DateTime CreatedTime { get; set; }

        public override string ToString()
        {
            return this.Text;
        }

        public abstract void Display();
        public abstract void PostToFacebook(GeneralPageService service);
    }
}
