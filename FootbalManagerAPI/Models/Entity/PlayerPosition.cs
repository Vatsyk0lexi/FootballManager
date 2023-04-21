
using System.ComponentModel.DataAnnotations;

namespace FootbalManagerAPI.Models.Entity
{
    public class PlayerPosition
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        public virtual List<Player> Players { get; set; }
    }
}
