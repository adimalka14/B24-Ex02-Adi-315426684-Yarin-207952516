using BasicFacebookFeatures.Services;
using System;

namespace BasicFacebookFeatures.NewPost
{
    public class TextPostProxy : PostProxy
    {
        public string statusText { get; set; }
        public string privacy { get; set; }

        internal TextPostProxy()
        {
        }

        public override string ToString()
        {
            return base.RealPost.Message;
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
