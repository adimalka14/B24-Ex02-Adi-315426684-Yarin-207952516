using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using BasicFacebookFeatures.Adapter;
using BasicFacebookFeatures.NewUser;
using BasicFacebookFeatures.Strategy;

namespace BasicFacebookFeatures.MatchStrategy
{
    internal class FavoriteTeamsStrategy : IMatchStrategy
    {
        private IEnumerable<PageAdapter> m_SelectedTeams;

        public FavoriteTeamsStrategy(IEnumerable<PageAdapter> i_SelectedTeams)
        {
            this.m_SelectedTeams = i_SelectedTeams;
        }

        public bool Match(UserFacade friend)
        {
            IEnumerable<string> selectedTeamNames = m_SelectedTeams.Select(team => team.Id);
            IEnumerable<string> friendTeamNames = friend.FavoriteTeams.Select(team => team.Id);

            return !m_SelectedTeams.Any() || friendTeamNames.ToList().Intersect(selectedTeamNames).Any();
        }
    }
}
