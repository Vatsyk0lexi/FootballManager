using FootbalManagerAPI.Models.Entity;
using FootbalManagerAPI.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FootbalManagerAPI.Services
{
    public class PlayersService : IPlayersService
    {
        private readonly IPlayersRepository _repository;
        public PlayersService(IPlayersRepository repository)
        {
            _repository = repository;
        }
        public  async Task<IEnumerable<Player>> GetAllPlayersOfTeam(int teamId)
        {
            return await _repository.GetAllPlayersOfTeam(teamId);
        }

        public async Task<IEnumerable<TournamentPlayerStatistic>> GetPlayerStatisticofTournament(int playerId, int teamId, int tournamentId)
        {
           return await _repository.GetPlayerStatisticofTournament(playerId, teamId, tournamentId); 
        }
    }
}
