using FacebookWrapper.ObjectModel;
using System;

namespace BasicFacebookFeatures.Adapter
{
    public class PostAdapter
    {
        public Post Post { get; set; }
        public string Location { get; set; }
        public DateTime CreatedTime { get; set; }

        public override string ToString()
        {
            string stringResult;
            if (Post.Message != null)
            {
                stringResult = string.Format($"{Post.From?.Name ?? "-"}: [{Post.Type}] {Post.Message}");
            }
            else if (Post.Caption != null)
            {
                stringResult = string.Format($"{Post.From?.Name ?? "-"}: [{Post.Type}] {Post.Caption}");
            }
            else
            {
                stringResult = string.Format($"{Post.From?.Name ?? "-"}: [{Post.Type}]");
            }

            return stringResult;
        }
    }
}