using System;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Model.Adapter
{
    public class PostAdapter
    {
        public Post Post { get; set; }
        public string Location { get; set; }
        public DateTime CreatedTime { get; set; }
        public string Description { get; set; }
        private string m_ImgUrl;

        public string ImgUrl
        {
            get => m_ImgUrl ?? (m_ImgUrl = Post?.PictureURL) ??
                (m_ImgUrl = "https://media-cldnry.s-nbcnews.com/image/upload/t_fit-1500w,f_auto,q_auto:best/newscms/2018_24/2462811/180612-memory-ideas-tricks-devices-ac-451p.jpg");
            set => m_ImgUrl = value;
        }

        public override string ToString()
        {
            return this.Description;
        }
    }
}