using Domain.Entities;
using System.Collections.Generic;

namespace Contracts.Persistence
{
    public interface IToDoRepository
    {
        IEnumerable<ToDoItem> GetAllToDos();

        ToDoItem FindToDo(ToDoItem entity);

        void AddToDo(ToDoItem entity);

        void UpdateToDo(ToDoItem entity);

        void DeleteToDo(ToDoItem entity);

        void MarkToDoAsDone(ToDoItem entity);
    }
}