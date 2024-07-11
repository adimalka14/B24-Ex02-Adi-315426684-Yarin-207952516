using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using BasicFacebookFeatures.Strategy;

namespace BasicFacebookFeatures.MatchStrategy
{
    internal class FavoriteTeamsStrategy : IMatchStrategy
    {
        private IEnumerable<Page> m_SelectedTeams;

        public FavoriteTeamsStrategy(IEnumerable<Page> i_SelectedTeams)
        {
            this.m_SelectedTeams = i_SelectedTeams;
        }

        public bool Match(User friend)
        {
            IEnumerable<string> selectedTeamNames = m_SelectedTeams.Select(team => team.Id);
            IEnumerable<string> friendTeamNames = friend.FavofriteTeams.Select(team => team.Id);

            return !m_SelectedTeams.Any() || friendTeamNames.ToList().Intersect(selectedTeamNames).Any();
        }
    }
}
