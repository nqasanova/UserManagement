using AuthenticationWithClie.Database.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationWithClie.Database.Models
{
    public class Admin : User
    {
        private Func<string> getFirstName;
        private Func<string> getLastName;
        private string v1;
        private string v2;

        public Admin(string firstName, string lastName, string email, string password, int id)
            : base(firstName, lastName, email, password, id)
        {


        }

        public Admin(string firstName, string lastName, string email, string password)
            : base(firstName, lastName, email, password)
        {


        }

        public Admin(Func<string> getFirstName, Func<string> getLastName, string v1, string v2)
        {
            this.getFirstName = getFirstName;
            this.getLastName = getLastName;
            this.v1 = v1;
            this.v2 = v2;
        }

        public override string GetInfo()
        {
            return $"Hello admin, {FirstName} {LastName} {Email}";
        }
    }
}