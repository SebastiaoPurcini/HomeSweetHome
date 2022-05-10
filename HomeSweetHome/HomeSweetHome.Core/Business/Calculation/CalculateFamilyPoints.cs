using HomeSweetHome.Core.Models;

namespace HomeSweetHome.Core.Business.Calculation
{
    public static class CalculateFamilyPoints
    {
        public static int GetCalculatedPoints(Family family)
        {
            int incomePoints = 0, dependentsPoints = 0;

            incomePoints = CalculateIncomePoints.GetPointsbByIncome(family);
            dependentsPoints = CalculateDependentsPoints.GetPointsbByDependents(family);

            return incomePoints + dependentsPoints;
        }
    }
}
