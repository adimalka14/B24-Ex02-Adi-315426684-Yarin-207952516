namespace BasicFacebookFeatures.Model.NewUser
{
    public interface IUserBuilder
    {
        UserFacade CreateUser();
        void BuildPrivateDetails(UserFacade i_UserFacade);
        void BuildUserFriends(UserFacade i_UserFacade);
        void BuildLikedPages(UserFacade i_UserFacade);
        void BuildFavoriteTeams(UserFacade i_UserFacade);
        void BuildPosts(UserFacade i_UserFacade);
    }
}
