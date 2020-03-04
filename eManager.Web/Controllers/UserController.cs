using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using eManager.Services.Helpers;
using eManager.WebModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using Serilog;

namespace eManager.Controllers
{
  
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IToastNotification _toastNotification;

        public UserController(IUserService userService, IToastNotification toastNotification)
        {
            _userService = userService;
            _toastNotification = toastNotification;
        }

    
        public IActionResult LogIn()
    {
        return View(new LoginViewModel());
    }

       
        [HttpPost]
    public IActionResult LogIn(LoginViewModel model)
    {
          

            if (ModelState.IsValid)
            {
                _userService.Login(model);
                if (User.IsInRole("admin"))
                {
                    
                    _toastNotification.AddSuccessToastMessage("You have successfully logged in!");
                    Log.Information($"User with username {model.Username} logged in as admin!");
                    return RedirectToAction("index", "home");
                }
                Thread.Sleep(1000);
                _toastNotification.AddSuccessToastMessage("You have successfully logged in!");
                Log.Error($"User with username {model.Username} logged in as regular user!");
                return RedirectToAction("Index", "Home");
            }
        
        _toastNotification.AddWarningToastMessage("Username or password are incorect!");
            return View(model);
    }

      
        public IActionResult Register()
    {
        return View(new RegisterViewModel());
    }

      
        [HttpPost]
    public IActionResult Register(RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            _userService.Register(model);
            return RedirectToAction("index", "home");
        }
        return View(model);
    }

    public IActionResult LogOut()
    {
        _userService.Logout();
        return RedirectToAction("index", "home");
    }
}
}