using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Pages
{
    public class IndexModel : PageModel
    {
        private static int _autoId = 1;

        private static int GenerateId()
        {
            return _autoId++;
        }

        public List<ToDo> ToDos { get; set; } = new List<ToDo>();

        [BindProperty]
        public ToDo ToDo { get; set; }

        public void OnGetAsync()
        {
            FillToDos();
        }

        public IActionResult OnPostAsync(ToDo toDo)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            ToDos.Add(toDo);

            return RedirectToPage();
        }

        public IActionResult OnPostDeleteAsync(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            ToDos.Remove(new ToDo { Id = id });

            return RedirectToPage();
        }

        public IActionResult OnPostMarkAsDoneAsync(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var toDo = ToDos.FirstOrDefault(t => t.Id == id);

            toDo.Done = true;

            return RedirectToPage();
        }

        private void FillToDos()
        {
            ToDos.Add(new ToDo { Id = GenerateId(), Note = "Eat pizza" });
            ToDos.Add(new ToDo { Id = GenerateId(), Note = "Drink a water", Done = true });
        }
    }
}