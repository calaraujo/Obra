using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Obra.Web.Data.Entities
{
    public class ProfitCenter
    {
        public int Id { get; set; }

        [Display(Name = "Cód.C.Lucro")]
        [MaxLength(10, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Code { get; set; }

        [Display(Name = "Nome C.Lucro")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [Range(0, double.MaxValue, ErrorMessage = "The {0} must be between {1} and {2}")]
        [Display(Name = "Débitos")]
        //[NumeroBrasil(DecimalRequerido = true, PontoMilharPermitido = true)]
        public double DebitSum { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [Range(0, double.MaxValue, ErrorMessage = "The {0} must be between {1} and {2}")]
        [Display(Name = "Créditos")]
        //[NumeroBrasil(DecimalRequerido = true, PontoMilharPermitido = true)]
        public double CreditSum { get; set; }

        [Display(Name = "Obra")]
        public int Construction_id { get; set; }

        [Display(Name = "Obra")]
        public Construction Construction { get; set; }
        public ICollection<CostCenter> CostCenters { get; set; }
    }
}
