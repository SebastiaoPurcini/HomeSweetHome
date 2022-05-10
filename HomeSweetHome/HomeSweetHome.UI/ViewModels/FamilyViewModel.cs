using HomeSweetHome.Core.Extensions;
using HomeSweetHome.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace HomeSweetHome.UI.ViewModels
{
    public class FamilyViewModel 
    {
        [Required]
        public Family Family { get; private set; }

        [Display(Name = "Nº de Membros")]
        public int MembersCount { get; private set; }

        [Display(Name = "Renda")]
        public decimal Income { get; private set; }

        [Display(Name = "Total de Pontos")]
        public int AnmountPoints { get; private set; }

        [Display(Name = "Nº de Dependentes")]
        public int DependentsCount { get; private set; }

        public FamilyViewModel(Family family)
        {
            Family = family;
            MembersCount = family.Members.Count;
            Income = family.GetTotalIncome();
            AnmountPoints = family.GetAnmountPoints();
            DependentsCount = family.GetDependentsCount();
        }
    }
}
