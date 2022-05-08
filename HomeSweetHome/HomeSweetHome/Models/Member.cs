using System.ComponentModel.DataAnnotations;

namespace HomeSweetHome.Models
{
    public class Member
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Sobrenome")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Idade")]
        public int Age { get; set; }

        [Display(Name = "Salário")]
        public decimal Salary { get; set; }

        [Required]
        [Display(Name = "Tipo")]
        public MemberType MemberType { get; set; }

        public Member()
        {

        }
    }
}
