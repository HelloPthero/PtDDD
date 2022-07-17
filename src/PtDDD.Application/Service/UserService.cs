using PtDDD.Application.Dto;
using PtDDD.Application.ISerivce;
using PtDDD.Domain.IRepositories;
using PtDDD.Infrastructure.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PtDDD.Application.Service
{
    public class UserService:IUserService
    {
        protected IUserRepository UserRepository { get; set; }
        public UserService(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        public DataResult ValidUser(UserDto input) 
        {
            var user = UserRepository.Find(t => t.Name == input.Name && t.Password == input.Password);
            if(user != null)
            {
                return DataResult.Success("找到了");
            }
            else
            {
                return DataResult.False("没找到");
            }
        }

        public List<UserDto> GetUsers()
        {
            return UserRepository.ALL()
                .Select(t => new UserDto
                {
                    Name = t.Name,
                    Password = t.Password,
                    Email = t.Email,
                    LastLoginTime = t.LastLoginTime,
                    Id = t.Id
                }).ToList() ;
        }
    }
}
