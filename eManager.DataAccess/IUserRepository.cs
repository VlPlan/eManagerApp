using System;
using System.Collections.Generic;
using System.Text;
using eManager.Domain;

namespace eManager.DataAccess
{
    public interface IUserRepository
    {
        User GetByUsername(string username);
        User GetById(string id);
    }
}
