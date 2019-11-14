using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Obra.Web.Data.Entities
{
    public class Construction
    {
        public int Id { get; set; }

        [Display(Name = "Nome da Obra")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Name { get; set; }

        [Display(Name = "Empresa")]
        public int Company_Id { get; set; }

        [Display(Name = "Endereço")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Address { get; set; }

        [Display(Name = "Complemento")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Complement { get; set; }

        [Display(Name = "Bairro")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Neighborhood { get; set; }

        [Display(Name = "CEP")]
        [MaxLength(15, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string ZipCode { get; set; }

        [Display(Name = "Region")]
        public int Region_id { get; set; }

        [Display(Name = "País")]
        public int Country_id { get; set; }

        [Display(Name = "Estado")]
        public int State_id { get; set; }

        [Display(Name = "Cidade")]
        public int City_id { get; set; }

        [Display(Name = "Empresa")]
        public Company Company { get; set; }

        [Display(Name = "Região")]
        public Region Region { get; set; }

        [Display(Name = "País")]
        public Country Country { get; set; }

        [Display(Name = "Estado")]
        public State State { get; set; }

        [Display(Name = "Cidade")]
        public City City { get; set; }
        public ICollection<CostCenter> CostCenters { get; set; }
        public ICollection<ProfitCenter> ProfitCenters { get; set; }
    }
}
