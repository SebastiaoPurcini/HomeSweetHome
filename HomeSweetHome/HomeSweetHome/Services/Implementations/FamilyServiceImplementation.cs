using HomeSweetHome.Models;
using HomeSweetHome.Services.Extensions;
using System.Collections.Generic;
using System.Threading;

namespace HomeSweetHome.Services.Implementations
{
    public class FamilyServiceImplementation : IFamilyService
    {
        private volatile int _memberId;

        public List<Family> GetAll()
        {
            var families = new List<Family>();

            for (int i = 0; i < 5; i++)
            {
                families.Add(GetFamily());
            }

            return families;
        }

        private Family GetFamily()
        {
            int id = GenerateId();

            var memberImplementation = new MemberServiceImplementation();

            var family = new Family()
            {
                Id = id,
                Name = "Familia " + id,
                Address = "Endereço Familia " + 1,
                PhoneNumber = "00000" + id,
                Members = memberImplementation.GetByFamily()
            };

            family.SetAnmountPoints();

            return family;
        }

        private int GenerateId()
        {
            return Interlocked.Increment(ref _memberId);
        }
    }
}
