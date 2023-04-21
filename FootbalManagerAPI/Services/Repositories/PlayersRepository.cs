using FootbalManagerAPI.Models.Entity;
using FootbalManagerAPI.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;

namespace FootbalManagerAPI.Services.Repositories
{
    public class PlayersRepository : IPlayersRepository
    {
        private readonly FootballManagerContext _context;
        public PlayersRepository(FootballManagerContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Player>> GetAllPlayersOfTeam(int teamId)
        {
            return await
                _context
                .Players
                .Include(p=> p.PlayerPosition)
                .Where(x => x.TeamId == teamId)
                .ToListAsync();
        }



        public async Task<IEnumerable<TournamentPlayerStatistic>> GetPlayerStatisticofTournament(int playerId, int teamId, int tournamentId)
        {
            return await
                _context
                .TournamentPlayerStatistics
                .Include(x => x.Player)
                .Include(x => x.Tournament)
                .Where(x => x.PlayerId == playerId && x.Player.TeamId == teamId && x.TournamentId == tournamentId)
                .ToListAsync();
        }
    }
}
