using System.Collections.Generic;
using System.Linq;
using BasicFacebookFeatures.Model.Adapter;
using BasicFacebookFeatures.Model.NewUser;

namespace BasicFacebookFeatures.Model.MatchStrategy
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