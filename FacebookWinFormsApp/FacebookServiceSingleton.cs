using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Services
{
    public sealed class FacebookServiceSingleton
    {
        private static readonly Lazy<FacebookServiceSingleton> lazy =
            new Lazy<FacebookServiceSingleton>(() => new FacebookServiceSingleton());

        public static FacebookServiceSingleton Instance { get { return lazy.Value; } }

        private FacebookServiceSingleton() { }

        public LoginResult LoginResult { get; private set; }

        public async Task<LoginResult> LoginAsync(string appId, params string[] permissions)
        {
            return await Task.Run(() =>
            {
                try
                {
                    LoginResult = FacebookService.Login(appId, permissions);
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to login to Facebook.", ex);
                }

                return LoginResult;
            });
        }
    }
}
