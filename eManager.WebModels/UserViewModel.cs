using System;
using System.Collections.Generic;
using System.Text;
using eManager.Domain;

namespace eManager.WebModels
{
 
        public class UserViewModel
        {
        public UserViewModel()
        {

        }

        public UserViewModel(User user)
        {

            Id = user.Id;
            UserName = user.UserName;
            FullName = user.FullName;

        }
            public string Id { get; set; }
            public string FullName { get; set; }
            public string UserName { get; set; }
        
    }
    
}
