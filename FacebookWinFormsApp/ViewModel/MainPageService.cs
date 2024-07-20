using BasicFacebookFeatures.Model.NewUser;
using FacebookWrapper;

namespace BasicFacebookFeatures.ViewModel
{
    public class MainPageService
    {
        private readonly UserComposer r_Composer = new UserComposer(new UserBuilder());
        public UserFacade UserFacade { get; private set; }

        public MainPageService()
        {
            FacebookService.s_CollectionLimit = 25;
        }

        public void Init()
        {
            this.UserFacade = r_Composer.CreateUser();
        }
    }
}