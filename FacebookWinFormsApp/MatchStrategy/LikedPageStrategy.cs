using System.Collections.Generic;
using System.Linq;
using BasicFacebookFeatures.Adapter;
using BasicFacebookFeatures.NewUser;
using BasicFacebookFeatures.Strategy;

namespace BasicFacebookFeatures.MatchStrategy
{
    internal class LikedPageStrategy : IMatchStrategy
    {
        private readonly IEnumerable<PageAdapter> r_SelectedLikedPages;

        public LikedPageStrategy(IEnumerable<PageAdapter> i_SelectedLikedPages)
        {
            this.r_SelectedLikedPages = i_SelectedLikedPages;
        }

        public bool Match(UserFacade i_Friend)
        {
            IEnumerable<string> selectedTeamNames= r_SelectedLikedPages.Select(page => page.Id);
            IEnumerable<string> friendTeamNames = i_Friend.LikedPages.Select(page => page.Id);

            return !r_SelectedLikedPages.Any() || friendTeamNames.Intersect(selectedTeamNames).Any();
        }
    }
}