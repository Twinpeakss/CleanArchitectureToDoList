using Domain.Entities;

namespace Contracts.Persistence
{
    public interface IToDoRepository
    {
        void AddToDo(ToDoItem entity);

        void UpdateToDo(ToDoItem entity);

        void DeleteToDo(ToDoItem entity);

        void MarkToDoAsDone(ToDoItem entity);
    }
}