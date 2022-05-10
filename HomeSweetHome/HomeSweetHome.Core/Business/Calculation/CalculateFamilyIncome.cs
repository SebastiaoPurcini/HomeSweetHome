using HomeSweetHome.Core.Models;

namespace HomeSweetHome.Core.Business.Calculation
{
    public static class CalculateFamilyIncome
    {
        public static decimal GetFamilyIncome(Family family)
        {
            decimal income = 0;

            foreach (var members in family.Members)
            {
                income += members.Salary;
            }

            return income;
        }
    }
}
