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
    }
}
