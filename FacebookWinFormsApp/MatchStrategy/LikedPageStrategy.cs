using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using BasicFacebookFeatures.Strategy;

namespace BasicFacebookFeatures.MatchStrategy
{
    internal class LikedPageStrategy : IMatchStrategy
    {
        private IEnumerable<Page> m_SelectedLikedPages;

        public LikedPageStrategy(IEnumerable<Page> i_SelectedLikedPages)
        {
            this.m_SelectedLikedPages = i_SelectedLikedPages;
        }

        public bool Match(User friend)
        {
            IEnumerable<string> selectedTeamNames= m_SelectedLikedPages.Select(Page => Page.Name);
            IEnumerable<string> friendTeamNames = friend.LikedPages.Select(Page => Page.Name);

            return !m_SelectedLikedPages.Any() || friendTeamNames.Intersect(selectedTeamNames).Any();
        }
    }
}