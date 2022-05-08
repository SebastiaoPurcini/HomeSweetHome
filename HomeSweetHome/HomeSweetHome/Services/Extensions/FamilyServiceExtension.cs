using HomeSweetHome.Models;
using System.Collections.Generic;
using System.Linq;

namespace HomeSweetHome.Services.Extensions
{
    public static class FamilyServiceExtension
    {
        private static int GetCalculatedPoints(Family family)
        {
            int dependentsCount = 0;
            int points = 0;

            if (family.Income <= 900)
            {
                points += 5;
            }
            else if (family.Income > 900 && family.Income <= 1500)
            {
                points += 3;
            }

            dependentsCount = family.Members.Where(m => m.MemberType != null && m.Age < 18 && m.MemberType.Id == 3).Count();

            if (dependentsCount >= 3)
            {
                points += 3;
            }
            else if (dependentsCount >= 1)
            {
                points += 2;
            }

            return points;
        }
        public static void SetAnmountPoints(this Family family)
        {
            family.AnmountPoints = GetCalculatedPoints(family);
        }
    }
}
