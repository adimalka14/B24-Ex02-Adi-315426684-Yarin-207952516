using BasicFacebookFeatures.NewUser;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public class MainPageService
    {
        public readonly UserComposer r_Composer = new UserComposer(new UserBuilder());
        public UserFacade i_UserFacade;

        public MainPageService()
        {
            FacebookService.s_CollectionLimit = 25;
        }

        public void Init()
        {
            i_UserFacade = r_Composer.CreateUser();
        }
    }
}