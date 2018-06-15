using System;
using System.Collections.Generic;
using System.Text;

namespace abyNa3.Data
{
    public class User:BaseEntity
    {
        public User(Int32 id, string username, string email, string password)
        {
            this.Id = id;
            this.UserName = username;
            this.Email = email;
            this.Password = password;
        }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
}
}
