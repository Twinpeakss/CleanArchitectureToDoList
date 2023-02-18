using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ToDoDbContext _context;

        [BindProperty]
        public ToDo ToDo { get; set; }

        public IList<ToDo> ToDos { get; set; } = new List<ToDo>();

        public IndexModel(ToDoDbContext context)
        {
            _context = context;
        }

        public async void OnGetAsync()
        {
            if (_context.ToDos.Any())
            {
                ToDos = await _context.ToDos.ToListAsync();
            }
        }

        public async Task<IActionResult> OnPostAsync(ToDo toDo)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ToDos.Add(toDo);
            await _context.SaveChangesAsync();

            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var todo = await _context.ToDos.FindAsync(id);

            if (todo != null)
            {
                _context.ToDos.Remove(todo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostMarkAsDoneAsync(int id)
        {
            var todo = await _context.ToDos.FindAsync(id);

            if (todo != null)
            {
                todo.Done = true;
                _context.ToDos.Update(todo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}