using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace TMSystems.DomainModel
{
   public class Role:IdentityRole<long>
    {
        public IList<UserRole> Users { get; set; } = new List<UserRole>();
    }
}
