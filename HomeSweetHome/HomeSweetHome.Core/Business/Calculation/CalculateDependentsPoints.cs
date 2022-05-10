using HomeSweetHome.Core.Extensions;
using HomeSweetHome.Core.Models;

namespace HomeSweetHome.Core.Business.Calculation
{
    public static class CalculateDependentsPoints
    {
        public static int GetPointsbByDependents(Family family)
        {
            int points = 0, dependentsCount = family.GetDependentsCount();

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
    }
}
