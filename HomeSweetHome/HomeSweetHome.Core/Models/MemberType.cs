using System.ComponentModel.DataAnnotations;

namespace HomeSweetHome.Core.Models
{
    public class MemberType
    {
        public int Id { get; set; }
        
        [Display(Name = "Tipo")]
        public string Type { get; set; }

        public MemberType()
        {

        }
    }
}
