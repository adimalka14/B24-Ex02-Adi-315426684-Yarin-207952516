using BasicFacebookFeatures.Services;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.NewPost
{
    public abstract class PostProxy
    {
        public Post RealPost { get; set; }
        public abstract void Display();
        public abstract void PostToFacebook(GeneralPageService service);
    }
}
