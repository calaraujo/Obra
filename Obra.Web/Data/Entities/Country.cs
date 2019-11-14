using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Obra.Web.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "País")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Name { get; set; }

        [Display(Name = "Região")]
        public int Region_id { get; set; }

        [Display(Name = "Cód.Internacional")]
        [MaxLength(5, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string IsoCode { get; set; }

        [Display(Name = "Moeda")]
        public int Currency_id { get; set; }

        [Display(Name = "Região")]
        public Region Region { get; set; }

        [Display(Name = "Moeda")]
        public Currency Currency { get; set; }
        public ICollection<State> States { get; set; }
        public ICollection<Company> Companies { get; set; }
        public ICollection<Construction> Constructions { get; set; }
    }
}
