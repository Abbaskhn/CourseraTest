using Microsoft.EntityFrameworkCore;
using System;

namespace CourseraTest
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }

}
