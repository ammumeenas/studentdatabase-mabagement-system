using Microsoft.EntityFrameworkCore;
using Studentdatabase_management_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studentdatabase_management_system.Data
{
    public class StudentDbContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Batch> Batches { get; set; }

        public StudentDbContext(DbContextOptions<StudentDbContext> options)
            : base(options)
        {
        }
    }
}
