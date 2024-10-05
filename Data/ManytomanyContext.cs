using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Manytomany.Models;

namespace Manytomany.Data
{
    public class ManytomanyContext : DbContext
    {
        public ManytomanyContext (DbContextOptions<ManytomanyContext> options)
            : base(options)
        {
        }

        public DbSet<Manytomany.Models.Course> Course { get; set; }

        public DbSet<Manytomany.Models.Student> Student { get; set; }

        public DbSet<Manytomany.Models.StudentCourse> StudentCourse { get; set; }
    }
}
