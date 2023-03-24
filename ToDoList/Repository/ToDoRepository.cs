using System;
using Contracts.Persistence;
using Domain.Entities;

namespace Repository
{
    public class ToDoRepository : IToDoRepository
    {
        public ToDoRepository()
        {
        }

        public void AddToDo(ToDoItem entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteToDo(ToDoItem entity)
        {
            throw new NotImplementedException();
        }

        public void MarkToDoAsDone(ToDoItem entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateToDo(ToDoItem entity)
        {
            throw new NotImplementedException();
        }
    }
}