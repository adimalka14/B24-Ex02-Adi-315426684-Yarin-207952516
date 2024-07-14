using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Adapter
{
    public class PageAdapter
    {
        public Page Page { get; set; }
        public string Id { get; set; }
        private string m_ImgUrl;

        public string ImgUrl
        {
            get => m_ImgUrl ?? (m_ImgUrl = Page.PictureNormalURL);
            set => m_ImgUrl = value;
        }

        public override string ToString()
        {
            return Page.Name;
        }
    }
}