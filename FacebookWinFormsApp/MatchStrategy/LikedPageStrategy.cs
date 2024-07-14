using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using BasicFacebookFeatures.Adapter;
using BasicFacebookFeatures.NewUser;
using BasicFacebookFeatures.Strategy;

namespace BasicFacebookFeatures.MatchStrategy
{
    internal class LikedPageStrategy : IMatchStrategy
    {
        private IEnumerable<PageAdapter> m_SelectedLikedPages;

        public LikedPageStrategy(IEnumerable<PageAdapter> i_SelectedLikedPages)
        {
            this.m_SelectedLikedPages = i_SelectedLikedPages;
        }

        public bool Match(UserFacade friend)
        {
            IEnumerable<string> selectedTeamNames= m_SelectedLikedPages.Select(Page => Page.Id);
            IEnumerable<string> friendTeamNames = friend.LikedPages.Select(Page => Page.Id);

            return !m_SelectedLikedPages.Any() || friendTeamNames.Intersect(selectedTeamNames).Any();
        }
    }
}