using Microsoft.EntityFrameworkCore;
using WebUI.Pages;

namespace WebUI
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext(DbContextOptions contextOptions)
            : base(contextOptions)
        {
        }

        public DbSet<ToDo> ToDos { get; set; }
    }
}