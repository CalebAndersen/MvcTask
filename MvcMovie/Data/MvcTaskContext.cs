using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcTasks.Models;

namespace MvcTask.Data
{
    public class MvcTaskContext : DbContext
    {
        public MvcTaskContext (DbContextOptions<MvcTaskContext> options)
            : base(options)
        {
        }

        public DbSet<MvcTasks.Models.Task> Task { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MvcTasks.Models.Task>()
                .Ignore(t => t.timerEnded);
        }
    }
}
