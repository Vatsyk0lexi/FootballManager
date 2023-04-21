using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FootbalManagerAPI.Models.Entity
{
    public class Tournament
    {
        public int Tournamentid{ get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        [MaxLength(150)]
        public string Name { get; set; }

        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Description { get; set; }

        public virtual List<TournamentTeamStatistic> TournamentTeams { get; set; }
        public virtual List<TournamentPlayerStatistic> TournamentPlayerStatistics  { get; set; }
    }
}
