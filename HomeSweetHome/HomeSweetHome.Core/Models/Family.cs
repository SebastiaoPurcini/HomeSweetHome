using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HomeSweetHome.Core.Models
{
    public class Family
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Endereço")]
        public string Address { get; set; }

        [Display(Name = "Telefone")]
        public string PhoneNumber { get; set; }

        public List<Member> Members { get; set; }

        [Display(Name = "Selecionado")]
        public bool Selected { get; set; }

        public Family()
        {

        }
    }
}
