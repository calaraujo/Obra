using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Obra.Web.Data.Entities
{
    public class Company
    {
        public int Id { get; set; }

        [Display(Name = "Razão Social")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Name { get; set; }

        [Display(Name = "Nome Comercial")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string FantasyName { get; set; }

        [Display(Name = "Tipo Parceiro")]
        public int PartnerType_id { get; set; }

        [Display(Name = "Tipo Pessoa")]
        public int PersonType_id { get; set; }

        [Display(Name = "CNPJ / CPF")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string NationalDocument { get; set; }

        [Display(Name = "Insc.Estadual")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string StateDocument { get; set; }

        [Display(Name = "Insc.Municipal")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string CountyDocument { get; set; }

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

        [Display(Name = "Telefone")]
        [MaxLength(15, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Phone { get; set; }

        [Display(Name = "Logo")]
        public string ImageUrl { get; set; }

        [Display(Name = "Region")]
        public int Region_id { get; set; }

        [Display(Name = "País")]
        public int Country_id { get; set; }

        [Display(Name = "Estado")]
        public int State_id { get; set; }

        [Display(Name = "Cidade")]
        public int City_id { get; set; }

        [Display(Name = "Tipo Parceiro")]
        public PartnerType PartnerType { get; set; }

        [Display(Name = "Tipo Pessoa")]
        public PersonType PersonType { get; set; }

        [Display(Name = "Região")]
        public Region Region { get; set; }

        [Display(Name = "País")]
        public Country Country { get; set; }

        [Display(Name = "Estado")]
        public State State { get; set; }

        [Display(Name = "Cidade")]
        public City City { get; set; }

        public string ImagePath
        {
            get
            {
                return string.IsNullOrEmpty(ImageUrl)
                    ? null
                    : $"https://cadearaujo.com{ImageUrl.Substring(1)}";
            }
        }

        public ICollection<Construction> Constructions { get; set; }
    }
}
