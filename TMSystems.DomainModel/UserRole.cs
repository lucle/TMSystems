using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace TMSystems.DomainModel
{
    public class UserRole:IdentityUserRole<long>
    {
        public override long UserId { get; set ; }

        public User User { get; set; }

        public override long RoleId { get; set; }

        public Role Role { get; set; }
    }
}
