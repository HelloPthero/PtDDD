using PtDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PtDDD.Domain.IRepositories
{
    public interface IUserRepository : IRepository<User, long>
    {
   
    }
}
