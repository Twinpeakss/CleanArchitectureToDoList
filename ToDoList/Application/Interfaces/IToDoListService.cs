namespace Application.Interfaces
{
    using Domain.Entities;
    using System.Collections.Generic;

    public interface IToDoListService
    {
        IEnumerable<ToDoItem> GetAllToDos();

        ToDoItem FindToDo(ToDoItem toDo);

        void AddToDo(ToDoItem toDo);

        void UpdateToDo(ToDoItem toDo);

        void DeleteToDo(ToDoItem toDo);

        void MarkToDoAsDone(ToDoItem toDo);
    }
}