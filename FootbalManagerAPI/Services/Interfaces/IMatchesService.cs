using FootbalManagerAPI.Models.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace FootbalManagerAPI.Services.Interfaces
{
    public interface IMatchesService
    {
        Task<IEnumerable<Match>> GetAllMatchesAsync();
        Task<List<List<Match>>> GetAmountOfLatestTeamMatchesAsync(int teamId, int amount);
        Task<IEnumerable<Match>> GetAllMatchesOfTeamAsync(int teamId);
        Task<IEnumerable<Match>> GetAllMatchesOfPlayerAsync(int playerId);
    }
}
