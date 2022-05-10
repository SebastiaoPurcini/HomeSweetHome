using HomeSweetHome.Core.Interfaces;

namespace HomeSweetHome.Core.Services.Factories.Family
{
    public class FamilyFactory : IFamilyFactory
    {
        public Models.Family GetNewFamily()
        {
            int id = CommonFactory.GenerateId();

            var family = new Models.Family()
            {
                Id = id,
                Name = $"Familia {id}",
                Address = $"Endereco Familia {id}",
                PhoneNumber = $"354{id}-4{id}1{id}"
            };

            return family;
        }
    }
}
