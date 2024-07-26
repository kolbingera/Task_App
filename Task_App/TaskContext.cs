using Microsoft.EntityFrameworkCore;
using Task_App.Models;

namespace Task_App.DataAccessLayer
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options) { }

        public DbSet<Task> Tasks { get; set; }  
    }
}
//context is an instance of the DbContext class, e.g. TaskDbContext