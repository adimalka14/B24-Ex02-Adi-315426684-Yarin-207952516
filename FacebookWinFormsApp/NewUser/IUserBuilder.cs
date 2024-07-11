namespace BasicFacebookFeatures.NewUser
{
    public interface IUserBuilder
    {
        LoggedUser CreateUser();
        void BuildPrivateDetails(LoggedUser i_User);
        void BuildUserFriends(LoggedUser i_User);
        void BuildLikedPages(LoggedUser i_User);
        void BuildFavoriteTeams(LoggedUser i_User);
        void BuildPosts(LoggedUser i_User);
    }
}
