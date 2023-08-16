using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CourseApp.Models;

namespace CourseApp.Data
{
    public class coursesContext : DbContext
    {
        public coursesContext (DbContextOptions<coursesContext> options)
            : base(options)
        {
        }

        public DbSet<CourseApp.Models.Course> Course { get; set; } = default!;
    }
}
