using Microsoft.AspNetCore.Identity;
using project1_4.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project1_4.Data
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
