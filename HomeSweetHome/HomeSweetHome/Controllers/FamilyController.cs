using HomeSweetHome.Models;
using HomeSweetHome.Services.Implementations;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HomeSweetHome.Controllers
{
    public class FamilyController : Controller
    {
        public IActionResult Index()
        {
            var familyImplementation = new FamilyServiceImplementation();

            return View(familyImplementation.GetAll());
        }

        public IActionResult ViewMembers(List<Member> members)
        {
            return RedirectToAction("Index", "Member", new { members = members });
        }
    }
}
