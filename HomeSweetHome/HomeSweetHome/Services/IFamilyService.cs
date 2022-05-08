using HomeSweetHome.Models;
using System.Collections.Generic;

namespace HomeSweetHome.Services
{
    public interface IFamilyService
    { 
        List<Family> GetAll();
    }
}
