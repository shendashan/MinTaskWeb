using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskWebS.Mode;

namespace TaskWebS.EFCore
{
    public class EntityFrameworkDbContext:DbContext
    {
        public EntityFrameworkDbContext(DbContextOptions<EntityFrameworkDbContext> options):base(options)
        {

        }
        public DbSet<TaskTag> TaskTags { get; set; }
        public DbSet<TaskError> TaskErrors { get; set; }
        public DbSet<TaskUser> TaskUsers { get; set; }
        public DbSet<TaskTable> TaskTables { get; set; }
        public DbSet<TaskMessage> TaskMessages { get; set; }
        public DbSet<TaskAndUser> TaskAndUsers { get; set; }
    }
}
