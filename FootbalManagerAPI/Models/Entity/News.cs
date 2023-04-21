using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FootbalManagerAPI.Models.Entity
{
    public class News
    {
        [Required]
        public int NewsId { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "{0} Довжина заголовку повинна бути між {2} та {1}.", MinimumLength = 10)]
        [Display(Name = "Заголовок")]
        public string Title { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "{0} Довжина тексту повинна бути між {2} та {1}.", MinimumLength = 30)]
        [Display(Name = "Текст")]
        public string Body { get; set; }

        public string NewsPhotoId { get; set; }


        [DataType(DataType.DateTime)]
        public DateTime  CreatedAt { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime  UpdatedAt { get; set; }
    }
}
