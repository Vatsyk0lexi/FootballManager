using FootbalManagerAPI.Models.Entity;
using FootbalManagerAPI.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FootbalManagerAPI.Services
{
    public class TournamentService : ITournamentService
    {
        private readonly ITournamentRepository _tournamentRepository;
        public TournamentService(ITournamentRepository tournamentRepository)
        {
            _tournamentRepository = tournamentRepository;
        }

        public async Task<IEnumerable<MatchPlayerStatictic>> GetBestAssistorsOfTeamOfTournament(int tournamentId, int teamId)
        {
           return await _tournamentRepository.GetBestAssistorsOfTeamOfTournament(tournamentId, teamId).ConfigureAwait(false);
        }

        public async Task<IEnumerable<MatchPlayerStatictic>> GetBestGolleadorsOfTeamOfTournament(int tournamentId, int teamId)
        {
            return await _tournamentRepository.GetBestGolleadorsOfTeamOfTournament(tournamentId, teamId);
        }

        public async Task<IEnumerable<TournamentTeamStatistic>> GetInfoAboutTeamsOfTournament(int tournamentId)
        {
            return await _tournamentRepository.GetInfoAboutTeamsOfTournament(tournamentId);
        }
    }
}
