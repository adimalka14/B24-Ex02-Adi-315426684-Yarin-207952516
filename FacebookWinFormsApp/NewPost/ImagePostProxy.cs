using BasicFacebookFeatures.Services;
using System;

namespace BasicFacebookFeatures.NewPost
{
    public class ImagePostProxy : PostProxy
    {
        public string imageUrl { get; set; }
        public string caption { get; set; }
        public string privacy { get; set; }

        internal ImagePostProxy()
        {
        }
        public override void Display()
        {
            Console.WriteLine("Displaying Image Post: " + imageUrl);
        }

        public override void PostToFacebook(GeneralPageService service)
        {
            service.PostStatus(caption, pictureURL: imageUrl, privacyParameterValue: privacy);
        }
    }
}
