using Contracts.Persistence;
using Domain.Entities;
using System.Collections.Generic;

namespace Repository
{
    public class ToDoRepository : IToDoRepository
    {
        public readonly ToDoContext _toDoContext;

        public ToDoRepository(ToDoContext toDoContext)
        {
            _toDoContext = toDoContext;
        }

        public async void AddToDo(ToDoItem entity)
        {
            await _toDoContext.AddAsync(entity);
            await _toDoContext.SaveChangesAsync();
        }

        public async void DeleteToDo(ToDoItem entity)
        {
            _toDoContext.Remove(entity);
            await _toDoContext.SaveChangesAsync();
        }

        public ToDoItem FindToDo(ToDoItem entity)
        {
            return _toDoContext.Find<ToDoItem>(entity);
        }

        public IEnumerable<ToDoItem> GetAllToDos()
        {
            return _toDoContext.toDoItems;
        }

        public async void MarkToDoAsDone(ToDoItem entity)
        {
            _toDoContext.Update(entity);
            await _toDoContext.SaveChangesAsync();
        }

        public async void UpdateToDo(ToDoItem entity)
        {
            _toDoContext.Update(entity);
            await _toDoContext.SaveChangesAsync();
        }
    }
}