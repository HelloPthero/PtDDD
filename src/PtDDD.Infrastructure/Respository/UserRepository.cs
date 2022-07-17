using Microsoft.EntityFrameworkCore;
using PtDDD.Domain;
using PtDDD.Domain.Entities;
using PtDDD.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PtDDD.Infrastructure.Respository
{
    public class UserRepository : RepositoryBase<UserEntity, long>,IUserRepository
    {
        public UserRepository(DBContext db) : base(db) 
        {
        }

    }
}
