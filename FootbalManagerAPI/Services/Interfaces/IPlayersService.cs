using FootbalManagerAPI.Models.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace FootbalManagerAPI.Services.Interfaces
{
    public interface IPlayersService
    {
        Task<IEnumerable<Player>> GetAllPlayersOfTeam(int teamId);
        Task<IEnumerable<TournamentPlayerStatistic>> GetPlayerStatisticofTournament(int playerId, int teamId, int tournamentId);
    }
}
