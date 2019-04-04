using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using static Project.Models.EF_Models;
using System.Threading.Tasks;

namespace Project.DataAccess
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Login> Login{ get; set; }
        public DbSet<Company> Company { get; set; }


    }
}
