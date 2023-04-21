using FootbalManagerAPI.Models.Entity;
using FootbalManagerAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootbalManagerAPI.Services.Repositories
{
    public class MatchesRepository : IMatchesRepository
    {
        private readonly FootballManagerContext _context;
        public MatchesRepository(FootballManagerContext context)
        {
            _context = context;
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

            var matchesid = await _context
                .TeamMatch
                .Include(x => x.Match)
                .Where(x => x.TeamId == teamId)
                .OrderBy(x => x.Match.Date)
                .Reverse()
                .Take(amount)
                .Select(x => x.MatchId)
                .ToListAsync();

            

            List<List<Match>> matches = new List<List<Match>>();

            for(int i =0;i< matchesid.Count; i++ )
            {
                var latestmatch = await _context
                .Matches
                .Include(x=>x.TeamMatches)
                    .ThenInclude(x=>x.Team)
                .Include(x => x.Tournament)
                .Where(x => x.MatchId == matchesid[i])
                .ToListAsync();
                matches.Add(latestmatch);
            }
      
            return matches;
        }
    }
}
