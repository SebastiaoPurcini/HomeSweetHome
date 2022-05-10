using HomeSweetHome.Core.Models;

namespace HomeSweetHome.Core.Business.Calculation
{
    public static class CalculateFamilyPoints
    {
        public static int GetCalculatedPoints(Family family)
        {
            int incomePoints, dependentsPoints;

            incomePoints = CalculateIncomePoints.GetPointsbByIncome(family);
            dependentsPoints = CalculateDependentsPoints.GetPointsbByDependents(family);

            return incomePoints + dependentsPoints;
        }
    }
}
