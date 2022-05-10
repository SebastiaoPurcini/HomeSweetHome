using HomeSweetHome.Core.Business.Calculation;
using HomeSweetHome.Core.Models;
using System.Linq;

namespace HomeSweetHome.Core.Extensions
{
    public static class FamilyExtension
    {
        public static decimal GetTotalIncome(this Family family)
        {
            return CalculateFamilyIncome.GetFamilyIncome(family);
        }

        public static int GetAnmountPoints(this Family family)
        {
            return CalculateFamilyPoints.GetCalculatedPoints(family);
        }

        public static int GetDependentsCount(this Family family)
        {
            return family.Members.Where(m => m.MemberType != null && m.Age < 18 && m.MemberType.Id == 3).Count();
        }
    }
}
