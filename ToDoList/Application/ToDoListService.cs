namespace Application
{
    using Application.Interfaces;
    using Contracts.Persistence;
    using Domain.Entities;
    using System.Collections.Generic;

    public class ToDoListService : IToDoListService
    {
        private readonly IToDoRepository toDoRepository;

        public ToDoListService(IToDoRepository toDoRepository)
        {
            this.toDoRepository = toDoRepository;
        }

        public void AddToDo(ToDoItem toDo)
        {
            toDoRepository.AddToDo(toDo);
        }

        public void DeleteToDo(ToDoItem toDo)
        {
            toDoRepository.DeleteToDo(toDo);
        }

        public ToDoItem FindToDo(ToDoItem toDo)
        {
            return toDoRepository.FindToDo(toDo);
        }

        public IEnumerable<ToDoItem> GetAllToDos()
        {
            return toDoRepository.GetAllToDos();
        }

        public void MarkToDoAsDone(ToDoItem toDo)
        {
            toDoRepository.MarkToDoAsDone(toDo);
        }

        public void UpdateToDo(ToDoItem toDo)
        {
            toDoRepository.UpdateToDo(toDo);
        }
    }
}