using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Obra.Web.Data.Entities
{
    public class State
    {
        public int Id { get; set; }

        [Display(Name = "Estado")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Name { get; set; }

        [Display(Name = "País")]
        public int Country_id { get; set; }

        [Display(Name = "Cód.Internacional")]
        [MaxLength(5, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Initials { get; set; }

        [Display(Name = "País")]
        public Country Country { get; set; }
        public ICollection<City> Cities { get; set; }
        public ICollection<Company> Companies { get; set; }
        public ICollection<Construction> Constructions { get; set; }
    }
}
