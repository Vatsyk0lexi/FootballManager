using FootbalManagerAPI.Models.Entity;
using FootbalManagerAPI.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace FootbalManagerAPI.Services.Interfaces
{
    public interface ITournamentService
    {
        Task<IEnumerable<MatchPlayerStatictic>> GetBestGolleadorsOfTeamOfTournament(int tournamentId, int teamId);
        Task<IEnumerable<MatchPlayerStatictic>> GetBestAssistorsOfTeamOfTournament(int tournamentId, int teamId);
        Task<IEnumerable<TournamentTeamStatistic>> GetInfoAboutTeamsOfTournament(int tournamentId);
    }
}
