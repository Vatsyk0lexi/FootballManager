using FootbalManagerAPI.Models.Entity;
using FootbalManagerAPI.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FootbalManagerAPI.Services
{
    public class MatchesService : IMatchesService
    {
        private readonly IMatchesRepository _repository;
        public MatchesService(IMatchesRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<Match>> GetAllMatchesAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Match>> GetAllMatchesOfPlayerAsync(int playerId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Match>> GetAllMatchesOfTeamAsync(int teamId)
        {
            throw new System.NotImplementedException();
        }

 

        public async Task<List<List<Match>>> GetAmountOfLatestTeamMatchesAsync(int teamId, int amount)
        {
            return await _repository.GetAmountOfLatestTeamMatchesAsync(teamId, amount);
        }
    }
}
