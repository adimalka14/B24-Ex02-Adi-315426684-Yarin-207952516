using System;

namespace BasicFacebookFeatures.NewPost
{
    public class PostFactory
    {
        public static NewPost CreatePost(string type, string content, string pictureUrl = null, string privacy = null)
        {
            switch (type.ToLower())
            {
                case "text":
                    return new TextPost(content, privacy);
                case "image":
                    return new ImagePost(pictureUrl, content, privacy);
                default:
                    throw new ArgumentException("Invalid post type.");
            }
        }
    }
}
