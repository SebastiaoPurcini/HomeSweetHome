using HomeSweetHome.Models;
using HomeSweetHome.Services.Implementations;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HomeSweetHome.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index(List<Member> members)
        {
            //var memberImplementation = new MemberServiceImplementation();

            return View(members);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
