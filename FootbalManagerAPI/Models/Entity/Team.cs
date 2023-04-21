using System.ComponentModel.DataAnnotations;

namespace FootbalManagerAPI.Models.Entity
{
    public class Team
    {
        public int TeamId { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "{0} Довжина імені команди повинна бути між {2} та {1}.", MinimumLength = 3)]
        public string Name{ get; set; }
        public string Location { get; set; }
        
        public string LogoPhotoPath { get; set; }
    
        public virtual List<Player> Players  { get; set; }
        public virtual List<Trainer> Trainers  { get; set; }
        public virtual List<TournamentTeamStatistic> TournamentTeams { get; set; }
    }
}
