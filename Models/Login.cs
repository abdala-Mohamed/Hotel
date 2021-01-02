using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web;

namespace Hotel.Models
{
    public class Login
    {
        public string SSN { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
        public Boolean Administrator { set; get; }

        public Login(string SSN,string Name,string Email,string Password,Boolean Administrator)
        {
            this.SSN = SSN;
            this.Name = Name;
            this.Email = Email;
            this.Password = Password;
            this.Administrator = Administrator;
        }

        public class LoginDBContext : DbContext
        {
            public LoginDBContext()
            { }
            public DbSet<Login> Account { get; set; }

        }


    }
}
