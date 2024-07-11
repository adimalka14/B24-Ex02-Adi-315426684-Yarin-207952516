using System;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.NewPost
{
    public class PostFactory
    {
        public PostProxy CreatePost(string type,Post i_RealPost)
        {
            switch (type.ToLower())
            {
                case "text":
                    return new TextPostProxy{RealPost = i_RealPost, Location = i_RealPost.Place?.Location.City,
                        CreatedTime = i_RealPost.CreatedTime.Value.Date,Text = i_RealPost.Message };
                case "image":
                    return new ImagePostProxy {RealPost = i_RealPost, Location = i_RealPost.Place?.Location.City,
                        CreatedTime = i_RealPost.CreatedTime.Value.Date, Text = i_RealPost.Caption };
                default:
                    throw new ArgumentException("Invalid post type.");
            }
        }

        public  PostProxy CreateNewPost(string type, string i_Content, string i_PictureUrl = null, string i_Privacy = null)
        {
            switch (type.ToLower())
            {
                case "text":
                    return new TextPostProxy { statusText = i_Content, privacy = i_Privacy };
                case "image":
                    return new ImagePostProxy { imageUrl = i_PictureUrl, caption = i_Content, privacy = i_Privacy };
                default:
                    throw new ArgumentException("Invalid post type.");
            }
        }
    }
}