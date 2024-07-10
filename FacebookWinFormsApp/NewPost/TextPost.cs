using BasicFacebookFeatures.Services;
using System;

namespace BasicFacebookFeatures.NewPost
{
    public class TextPost : NewPost
    {
        private string statusText;
        private string privacy;

        internal TextPost(string statusText, string privacy = null)
        {
            this.statusText = statusText;
            this.privacy = privacy;
        }

        public override void Display()
        {
            Console.WriteLine("Displaying Text Post: " + statusText);
        }

        public override void PostToFacebook(GeneralPageService service)
        {
            service.PostStatus(statusText, privacyParameterValue: privacy);
        }
    }
}
