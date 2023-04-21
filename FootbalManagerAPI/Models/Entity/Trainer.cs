using System.ComponentModel.DataAnnotations;

namespace FootbalManagerAPI.Models.Entity
{
    public class Trainer
    {
        public int Id { get; set; }

        [Required]
        public int TeamId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Довжина імені повинна бути між {2} та {1}", MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Довжина прізвища повинна бути між {2} та {1}", MinimumLength = 2)]
        public string LastName { get; set; }

        public string MiddleName { get; set; }

        [Range(20,90)]
        public int Age { get; set; }


        public virtual Team Team { get; set; }
    }
}
