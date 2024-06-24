using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCPLibrarySol.Accounts;

namespace OCPLibrarySol.Applicants
{
    public class PersonModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public IAccounts AccountProcessor { get; set; } = new StandardAccount();
    }
}
