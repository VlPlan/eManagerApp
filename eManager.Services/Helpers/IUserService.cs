using System;
using System.Collections.Generic;
using System.Text;
using eManager.WebModels;

namespace eManager.Services.Helpers
{
    public interface IUserService
    {
        void Register(RegisterViewModel registerModel);
        void Login(LoginViewModel loginModel);
        void Logout();
        UserViewModel GetCurrentUser(string username);
    }
}
