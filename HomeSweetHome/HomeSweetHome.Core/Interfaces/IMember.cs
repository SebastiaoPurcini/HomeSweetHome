using HomeSweetHome.Core.Models;
using System.Collections.Generic;

namespace HomeSweetHome.Core.Interfaces
{
    public interface IMember
    {
        List<Member> GetByFamily();
    }
}
