using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Context
{
    public class UserContext:DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
           :base(options)
        { 
        
        }

        public DbSet<User> Users { get; set; }

    }
}
