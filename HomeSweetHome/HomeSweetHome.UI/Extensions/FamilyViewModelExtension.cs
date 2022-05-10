using HomeSweetHome.UI.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace HomeSweetHome.UI.Extensions
{
    public static class FamilyViewModelExtension
    {
        public static IOrderedEnumerable<FamilyViewModel> OrderFamiliesByScore(this List<FamilyViewModel> families)
        {
            return families.OrderByDescending(f => f.AnmountPoints)
                           .ThenByDescending(f => f.MembersCount)
                           .ThenBy(f => f.Income);
        }
    }
}
