using Microsoft.EntityFrameworkCore;
using TaskManager.Models; // Dodaj referencję do modeli

namespace TaskManager.Data
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options) { }

        public DbSet<TaskItem> Tasks { get; set; }
    }
}
