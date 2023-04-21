using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FootbalManagerAPI.Models.Entity
{
    public class MatchPlayerStatictic
    {
        public int Id { get; set; }

        [Required]
        public int PlayerId { get; set; }

        [Required]
        public int MatchId { get; set; }

        [Required]
        [Range(0,15)]
        public int Goals { get; set; }

        [Required]
        [Range(0, 15)]
        public int Assists { get; set; }

        
        [Range(0,150)]
        public int TimePlayerPlayed { get; set; }

        [Required]
        public bool HasYellowCard { get; set; }

        [Required]
        public bool HasRedCard { get; set; }



        public virtual Player Player { get; set; }
        public virtual Match Match { get; set; }
    }
}
