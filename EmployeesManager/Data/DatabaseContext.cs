using EmployeesManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesManager.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options):base(options)
        {}

        public DbSet<Skill> Skills { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Job> Jobs { get; set; }

    }
}
