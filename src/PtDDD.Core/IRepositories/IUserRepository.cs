using PtDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PtDDD.Domain.IRepositories
{
    public interface IUserRepository : IRepository<UserEntity, long>
    {
    }
}
