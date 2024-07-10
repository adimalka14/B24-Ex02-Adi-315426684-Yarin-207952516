using BasicFacebookFeatures.Services;
using System;

namespace BasicFacebookFeatures.NewPost
{
    public class ImagePost : NewPost
    {
        private string imageUrl;
        private string caption;
        private string privacy;

        internal ImagePost(string imageUrl, string caption = null, string privacy = null)
        {
            this.imageUrl = imageUrl;
            this.caption = caption;
            this.privacy = privacy;
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
