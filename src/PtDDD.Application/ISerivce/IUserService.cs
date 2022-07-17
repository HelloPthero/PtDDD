using PtDDD.Application.Dto;
using PtDDD.Infrastructure.Common.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PtDDD.Application.ISerivce
{
    public interface IUserService
    {
        public DataResult ValidUser(UserDto input);
        public List<UserDto> GetUsers();
    }
}
