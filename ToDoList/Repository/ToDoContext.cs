using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Repository
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions contextOptions)
            : base(contextOptions)
        {
        }

        public DbSet<ToDoItem> toDoItems;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
        }
    }
}