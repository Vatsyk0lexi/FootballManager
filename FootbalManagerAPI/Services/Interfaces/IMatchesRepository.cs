using FootbalManagerAPI.Models.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace FootbalManagerAPI.Services.Interfaces
{
    public interface IMatchesRepository
    {
        Task<IEnumerable<Match>> GetAllMatchesAsync();
        /// <summary>
        /// Method which return you collection(amount you also send as parametr) of latest matches of team which you want
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="amount"></param>
        /// <returns>Collection of Matches of Team</returns>
        Task<List<List<Match>>> GetAmountOfLatestTeamMatchesAsync(int teamId, int amount);
        Task<IEnumerable<Match>> GetAllMatchesOfTeamAsync(int teamId);
        Task<IEnumerable<Match>> GetAllMatchesOfPlayerAsync(int playerId);

    }
}
