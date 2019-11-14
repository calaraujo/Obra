using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Obra.Web.Data.Entities
{
    public class Region
    {
        public int Id { get; set; }

        [Display(Name = "Região")]
        [MaxLength(30, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Name { get; set; }
        public ICollection<Country> Countries { get; set; }
        public ICollection<Company> Companies { get; set; }
        public ICollection<Construction> Constructions { get; set; }
    }
}
