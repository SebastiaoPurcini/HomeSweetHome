using HomeSweetHome.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace HomeSweetHome.UI.ViewModels
{
    public class MemberViewModel
    {
        [Required]
        public Member Member { get; private set; }

        public MemberViewModel(Member member) 
        {
            Member = member;
        }
    }
}
