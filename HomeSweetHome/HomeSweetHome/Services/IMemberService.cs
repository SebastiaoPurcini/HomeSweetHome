using HomeSweetHome.Models;
using System.Collections.Generic;

namespace HomeSweetHome.Services
{
    public interface IMemberService
    {
        List<Member> GetAll();
    }
}
