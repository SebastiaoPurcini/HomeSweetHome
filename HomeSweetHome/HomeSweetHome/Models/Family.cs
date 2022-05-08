using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HomeSweetHome.Models
{
    public class Family
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome da Família")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Endereço")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Contato")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Renda Total")]
        public decimal Income { get; set; }

        [Display(Name = "Total de Pontos")]
        public int AnmountPoints { get; set; }

        [Required]
        public List<Member> Members { get; set; }

        public Family()
        {

        }
    }
}
