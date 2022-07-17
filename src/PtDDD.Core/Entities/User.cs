using System;
using System.Collections.Generic;
using System.Text;

namespace PtDDD.Domain.Entities
{
    public class User : Entity<long>
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime LastLoginTime { get; set; }
    }
}
