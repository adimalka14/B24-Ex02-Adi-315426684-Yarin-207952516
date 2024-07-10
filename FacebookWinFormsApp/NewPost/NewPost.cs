using BasicFacebookFeatures.Services;

namespace BasicFacebookFeatures.NewPost
{
    public abstract class NewPost
    {
        public abstract void Display();
        public abstract void PostToFacebook(GeneralPageService service);
    }
}
