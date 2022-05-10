using HomeSweetHome.Infra.Implementations;
using HomeSweetHome.UI.Extensions;
using HomeSweetHome.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace HomeSweetHome.UI.Controllers
{
    public class FamilyController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                var families = new List<FamilyViewModel>();

                var implementation = new FamilyImplementation();

                implementation.GetAll().ForEach(f => families.Add(new FamilyViewModel(f)));

                return View(families.OrderFamiliesByScore());
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "NotFound");
            }
        }

        public IActionResult ViewMembers(string data)
        {
            TempData["memberData"] = data;

            return RedirectToAction("FamilyMembers", "Member");
        }
    }
}
