using System.ComponentModel.DataAnnotations;

namespace FootbalManagerAPI.Models.Entity
{
    public class Player
    {
        public int PlayerId { get; set; }

        [Required]
        public int TeamId { get; set; }
        
        [Required]
        public int PlayerPositionId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage ="Довжина імені повинна бути між {2} та {1}",MinimumLength =2)]
        public string FirstName{ get; set; }
        
        [Required]
        [StringLength(100, ErrorMessage = "Довжина прізвища повинна бути між {2} та {1}", MinimumLength = 2)]
        public string LastName{ get; set; }
        public string MiddleName{ get; set; }

        [Range(10, 100)]
        public int Age { get; set; }
        
        [Range(100, 300)]
        public int Height { get; set; }

        [Range(30, 150)]
        public int Weight { get; set; }
        public DateTime DateOfBith { get; set; }
        public string PlaceOfBirth { get; set; }
        
        [Range(0,100)]
        public int Number { get; set; }

        public string PlayerPhotoPath { get; set; } // url or path to file with photo

        public virtual Team Team { get; set; }
        public virtual PlayerPosition PlayerPosition { get; set; }
        public virtual List<MatchPlayerStatictic> MatchPlayerStatictics { get; set; }
        public virtual List<TournamentPlayerStatistic> TournamentPlayerStatistics { get; set; }
    }
}
