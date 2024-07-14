using System.Runtime.InteropServices;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Adapter
{
    public class PageAdapter
    {
        public Page Page { get; set; }
        public string Id { get; set; }
        private string m_ImgUrl;

        public override string ToString()
        {
            return Page.Name;
        }

        public string ImgUrl
        {
            get
            {
                if (m_ImgUrl == null)
                {
                    m_ImgUrl = Page.PictureNormalURL;
                }

                return m_ImgUrl;
            }

            set => m_ImgUrl = value;
        }
    }
}
