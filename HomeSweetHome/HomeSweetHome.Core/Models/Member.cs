using System.ComponentModel.DataAnnotations;

namespace HomeSweetHome.Core.Models
{
    public class Member
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string FirstName { get; set; }

        [Display(Name = "Sobrenome")]
        public string LastName { get; set; }

        [Display(Name = "Idade")]
        public int Age { get; set; }

        [Display(Name = "Salário")]

        public decimal Salary { get; set; }

        public MemberType MemberType { get; set; }

        public string FullName => FirstName + " " + LastName;

        public Member() { }
    }
}
