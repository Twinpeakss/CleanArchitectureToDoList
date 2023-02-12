namespace Application.Interfaces
{
    using Domain.Entities;

    public interface IToDoListService
    {
        void AddToDo(ToDoItem toDo);

        void UpdateToDo(ToDoItem toDo);

        void DeleteToDo(ToDoItem toDo);

        void MarkToDoAsDone(ToDoItem toDo);
    }
}