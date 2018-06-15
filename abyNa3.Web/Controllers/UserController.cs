using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using abyNa3.Service;
using abyNa3.Web.Models;
using abyNa3.Data;
using Microsoft.AspNetCore.Http;

namespace abyNa3.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<UserViewModel> model = new List<UserViewModel>();
            userService.GetUsers().ToList().ForEach(u =>
            {
                UserViewModel user = new UserViewModel
                {
                    Id = u.Id,
                    UserName = u.UserName,
                    Email = u.Email
                };
                model.Add(user);
            });

            return View(model);
        }
    }

}