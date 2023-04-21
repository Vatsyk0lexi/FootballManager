
using FootbalManagerAPI.Models.Entity;
using FootbalManagerAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootbalManagerAPI.Services.Repositories
{
    public class TournamentRepository : ITournamentRepository
    {
        private readonly FootballManagerContext _context;

        public TournamentRepository(FootballManagerContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TournamentTeamStatistic>> GetInfoAboutTeamsOfTournament(int tournamentId)
        {
            return await _context
                .TournamentTeamStatistics
                .Include(x => x.Team)
                 .Include(x => x.Tournament)
                .Where(x => x.TournamentId == tournamentId)
                .OrderBy(x => x.TeamPoints)
                .Reverse()
                .ToListAsync();
        }

        public async Task<IEnumerable<MatchPlayerStatictic>> GetBestGolleadorsOfTeamOfTournament(int tournamentId, int teamId)
        {
            return await
                _context
                .MatchPlayerStatictics
                .Include(x => x.Match)
                .Include(x => x.Player)
                .Where(x => x.Match.TournamentId == tournamentId && x.Player.TeamId == teamId)
                .OrderBy(x => x.Goals)
                .Reverse()
                .Take(10)
                .ToListAsync();
        }

        public async Task<IEnumerable<MatchPlayerStatictic>> GetBestAssistorsOfTeamOfTournament(int tournamentId, int teamId)
        {
            return await
                _context
                .MatchPlayerStatictics
                .Include(x => x.Match)
                .Include(x => x.Player)
                .Where(x => x.Match.TournamentId == tournamentId && x.Player.TeamId == teamId)
                .OrderBy(x => x.Assists)
                .Reverse()
                .Take(10)
                .ToListAsync();
        }
    }
}
