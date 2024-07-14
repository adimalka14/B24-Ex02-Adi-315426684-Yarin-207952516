using System.Collections.Generic;
using System.Linq;
using BasicFacebookFeatures.Adapter;
using BasicFacebookFeatures.NewUser;
using BasicFacebookFeatures.Strategy;

namespace BasicFacebookFeatures.MatchStrategy
{
    internal class FavoriteTeamsStrategy : IMatchStrategy
    {
        private readonly IEnumerable<PageAdapter> r_SelectedTeams;

        public FavoriteTeamsStrategy(IEnumerable<PageAdapter> i_SelectedTeams)
        {
            this.r_SelectedTeams = i_SelectedTeams;
        }

        public bool Match(UserFacade i_Friend)
        {
            IEnumerable<string> selectedTeamNames = r_SelectedTeams.Select(team => team.Id);
            IEnumerable<string> friendTeamNames = i_Friend.FavoriteTeams.Select(team => team.Id);

            return !r_SelectedTeams.Any() || friendTeamNames.ToList().Intersect(selectedTeamNames).Any();
        }
    }
}