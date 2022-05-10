using HomeSweetHome.Core.Interfaces;
using HomeSweetHome.Core.Models;
using HomeSweetHome.Core.Services.Factories.Family;
using System.Collections.Generic;

namespace HomeSweetHome.Infra.Implementations
{
    public class FamilyImplementation : IFamily
    {
        private int _count;

        public FamilyImplementation(int count = 10)
        {
            _count = count;
        }
        public List<Family> GetAll()
        {
            var families = new List<Family>();

            for (int i = 0; i < _count; i++)
            {
                families.Add(GetFamily());
            }

            return families;
        }

        private Family GetFamily()
        {
            var memberImplementation = new MemberImplementation();

            var family = new FamilyFactory().GetNewFamily();

            family.Members = memberImplementation.GetByFamily();

            return family;
        }
    }
}
