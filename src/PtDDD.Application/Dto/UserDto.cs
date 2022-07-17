using System;
using System.Collections.Generic;
using System.Text;

namespace PtDDD.Application.Dto
{
    public class UserDto
    {
        public long? Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime LastLoginTime { get; set; }
    }
}
