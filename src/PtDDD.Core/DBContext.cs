using Microsoft.EntityFrameworkCore;
using PtDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PtDDD.Domain
{
    public class DBContext:DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
            : base(options) 
        {
        }
        public virtual DbSet<UserEntity> Users { get; set; }
    }
}
