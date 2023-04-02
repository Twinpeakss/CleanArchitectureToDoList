using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace WebUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IToDoListService _toDoListService;

        private readonly IMapper _mapper;

        [BindProperty]
        public ToDo ToDo { get; set; }

        public IList<ToDo> ToDos { get; set; } = new List<ToDo>();

        public IndexModel(IToDoListService toDoRepository,
                          IMapper mapper)
        {
            _toDoListService = toDoRepository;
            _mapper = mapper;
        }

        public void OnGetAsync()
        {
            var collection = _toDoListService.GetAllToDos();
            var mapped = _mapper.Map<ToDoItem>(collection);
            ToDos = (IList<ToDo>)mapped;
        }

        public IActionResult OnPostAsync(ToDo toDo)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _toDoListService.AddToDo(_mapper.Map<ToDoItem>(toDo));

            return RedirectToPage();
        }

        public IActionResult OnPostDeleteAsync(ToDo toDo)
        {
            var dto = _mapper.Map<ToDoItem>(toDo);
            var todo = _toDoListService.FindToDo(dto);

            if (todo != null)
            {
                _toDoListService.DeleteToDo(dto);
            }

            return RedirectToPage();
        }

        public IActionResult OnPostMarkAsDoneAsync(ToDo toDo)
        {
            var dto = _mapper.Map<ToDoItem>(toDo);
            var todo = _toDoListService.FindToDo(dto);

            if (todo != null)
            {
                todo.Done = true;
                _toDoListService.MarkToDoAsDone(dto);
            }

            return RedirectToPage();
        }
    }
}