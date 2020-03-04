using System;
using System.Collections.Generic;
using System.Text;
using eManager.DataAccess;
using eManager.Domain;
using eManager.Services.Helpers;
using eManager.WebModels;
using Microsoft.AspNetCore.Identity;
using System.Linq;

namespace eManager.Services.Services
{
    public class UserService:IUserService
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly IUserRepository _userRepository;
        public UserService(SignInManager<User> signInManager,
                           UserManager<User> userManager,
                           IUserRepository userRepository)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _userRepository = userRepository;
           
        }

        public UserViewModel GetCurrentUser(string username)
        {
            try
            {
                User user = _userRepository.GetByUsername(username);

                var UserModel = new UserViewModel()
                {
                    UserName = user.UserName,
                    Id = user.Id,
                    FullName = user.FullName
                };
                return UserModel;
                
            }
            catch (Exception ex)
            {
                string message = $"User with username {username} does not exist!";
                throw new Exception(message, ex);
            }
            
        }

        public void Login(LoginViewModel loginModel)
        {
            SignInResult result = _signInManager
                         .PasswordSignInAsync(loginModel.Username, loginModel.Password, false, false).Result;

            if (result.IsNotAllowed)
            {
                throw new Exception("Username or Password is not correct!");
            }
        }

        public void Logout()
        {
            _signInManager.SignOutAsync();
        }

        public void Register(RegisterViewModel registerModel)
        {
            User user = new User()
            {
                UserName = registerModel.Username,
                FullName = registerModel.FirstName+' '+ registerModel.LastName,
                Email=registerModel.Email,
                Procurements = new List<Procurement>()
                {
                    new Procurement()
                    {
                        ProcurementStatus = ProcurementStatus.Pending
                    }
                }
            };
            var password = registerModel.Password;

            var result = _userManager.CreateAsync(user, registerModel.Password).Result;

            if (result.Succeeded)
            {
                var currentUser = _userManager.FindByNameAsync(user.UserName).Result;
                _userManager.AddToRoleAsync(user, "user");

                Login(new LoginViewModel()
                {
                    Username = registerModel.Username,
                    Password = registerModel.Password
                    
                });
            }
            else
            {
                throw new Exception($"Register failed! , {result.Errors.First().Description}");
            }
        }
        }
}
