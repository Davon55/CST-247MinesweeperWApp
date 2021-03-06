﻿using Microsoft.AspNetCore.Mvc;
using MinesweeperApp.Models;
using MinesweeperApp.Services.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinesweeperApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View("Login");
        }
        //pass a user object to the login
        [HttpPost]
        public IActionResult Login(UserModel userModel)
        {
            try
            {
                //validate input
                if (!ModelState.IsValid)
                    return View("Login");

                SecurityService securityService = new SecurityService();
                Boolean success = securityService.Authenticate(userModel);

                if (success)
                {
                    return View("LoginSuccess", userModel);
                }
                else
                {
                    return View("LoginFailure", userModel);
                }
            }
            catch(Exception e)
            {
                return View("LoginFailure");
            }
        }
    }
}
