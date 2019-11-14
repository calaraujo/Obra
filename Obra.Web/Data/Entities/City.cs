using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Obra.Web.Data.Entities
{
    public class City
    {
        public int Id { get; set; }

        [Display(Name = "Cidade")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Name { get; set; }

        [Display(Name = "Estado")]
        public int State_id { get; set; }

        [Display(Name = "Cód.IBGE")]
        [MaxLength(10, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string IbgeCode { get; set; }

        [Display(Name = "Estado")]
        public State State { get; set; }
        public ICollection<Company> Companies { get; set; }
        public ICollection<Construction> Constructions { get; set; }
    }
}
