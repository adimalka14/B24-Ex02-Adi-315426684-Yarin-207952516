namespace BasicFacebookFeatures.NewUser
{
    public class UserComposer
    {
        private IUserBuilder Builder { get; set; }

        public UserComposer(IUserBuilder i_Builder)
        {
            this.Builder = i_Builder;
        }

        public LoggedUser CreateUser()
        {
            return Builder.CreateUser();
        }

        public void UserPrivateDetails(LoggedUser i_User)
        {
            Builder.BuildPrivateDetails(i_User);
        }

        public void UserFriends(LoggedUser i_User)
        {
            Builder.BuildUserFriends(i_User);
        }
        public void LikedPages(LoggedUser i_User)
        {
            Builder.BuildLikedPages(i_User);

        }
        public void FavoriteTeams(LoggedUser i_User)
        {
            Builder.BuildFavoriteTeams(i_User);

        }
        public void Posts(LoggedUser i_User)
        {
            Builder.BuildPosts(i_User);
        }
    }
}
