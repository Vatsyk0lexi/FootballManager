using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FootbalManagerAPI.Models.Entity
{
    public class Match
    {
        public int MatchId { get; set; }

        [Required]
        public int TournamentId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [ForeignKey("Home "+nameof(Team))]
        public int HomeTeamId { get; set; }

        [ForeignKey("Guest " + nameof(Team))]
        public int GuestTeamId { get; set; }
        public int HomeTeamScore { get; set; }
        public int GuestTeamScore { get; set; }

        public virtual Team HomeTeam { get; set; }
        public virtual Team AwayTeam { get; set; }
        public virtual Tournament Tournament { get; set; }
        public virtual List<MatchPlayerStatictic> MatchPlayerStatictics { get; set; }
    }
}
