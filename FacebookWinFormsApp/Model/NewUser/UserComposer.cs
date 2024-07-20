namespace BasicFacebookFeatures.Model.NewUser
{
    public class UserComposer
    {
        private IUserBuilder Builder { get; }

        public UserComposer(IUserBuilder i_Builder)
        {
            this.Builder = i_Builder;
        }

        public UserFacade CreateUser()
        {
            return Builder.CreateUser();
        }

        public void UserPrivateDetails(UserFacade i_UserFacade)
        {
            Builder.BuildPrivateDetails(i_UserFacade);
        }

        public void UserFriends(UserFacade i_UserFacade)
        {
            Builder.BuildUserFriends(i_UserFacade);
        }

        public void LikedPages(UserFacade i_UserFacade)
        {
            Builder.BuildLikedPages(i_UserFacade);
        }

        public void FavoriteTeams(UserFacade i_UserFacade)
        {
            Builder.BuildFavoriteTeams(i_UserFacade);
        }

        public void Posts(UserFacade i_UserFacade)
        {
            Builder.BuildPosts(i_UserFacade);
        }
    }
}
