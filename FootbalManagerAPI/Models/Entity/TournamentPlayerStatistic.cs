using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FootbalManagerAPI.Models.Entity
{
    public class TournamentPlayerStatistic
    {
        public int Id { get; set; }

        [Required]
        public int PlayerId { get; set; }

        [Required]
        public int TournamentId { get; set; }
        //public int CountOfMatches { get; set; }

        public int Goals { get; set; }

        public int Assists { get; set; }

        public int TimePlayerPlayed { get; set; }

        public int YellowCards { get; set; }

        public int RedCards { get; set; }

        public virtual Tournament Tournament { get; set; }
        public virtual Player Player { get; set; }
    }
}
