using HomeSweetHome.Core.Models;

namespace HomeSweetHome.Core.Business.Calculation
{
    public static class CalculateIncomePoints
    {
        public static int GetPointsbByIncome(Family family)
        {
            int points = 0;

            var income = CalculateFamilyIncome.GetFamilyIncome(family);

            if (income <= 900)
            {
                points += 5;
            }
            else if (income > 900 && income <= 1500)
            {
                points += 3;
            }

            return points;
        }
    }
}
