using HomeSweetHome.Core.Models;
using HomeSweetHome.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace HomeSweetHome.UI.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index(List<Member> members)
        {
            return View(members);
        }

        public IActionResult FamilyMembers()
        {
            var members = new List<MemberViewModel>();

            if(TempData["memberData"] == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var data = TempData["memberData"].ToString();

            JsonSerializerOptions options = new JsonSerializerOptions() 
            { 
                PropertyNameCaseInsensitive = true 
            };

            try
            {
                var family = JsonSerializer.Deserialize<Family>(data, options);

                family.Members.ForEach(m => members.Add(new MemberViewModel(m)));

                return View("Index", members);

            }catch(Exception e)
            {
                return RedirectToAction("Index", "NotFound");
            }
        }
    }
}
