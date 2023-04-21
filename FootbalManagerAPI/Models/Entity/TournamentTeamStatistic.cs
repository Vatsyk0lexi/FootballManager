using System.ComponentModel.DataAnnotations;

namespace FootbalManagerAPI.Models.Entity
{
    public class TournamentTeamStatistic
    {
        public int Id { get; set; }
        public int TournamentId { get; set; }
        public int TeamId { get; set; }
        public int CountTeamScored { get; set; }
        public int CountTeamMissed { get; set; }
        public int CountTeamMatches { get; set; }
        public int CountTeamWin { get; set; }
        public int CountTeamLoose { get; set; }
        public int CountTeamDraw { get; set; }
        public int TeamPoints{ get; set; }

        public virtual Tournament Tournament { get; set; }
        public virtual Team Team{ get; set; }

    }
}
