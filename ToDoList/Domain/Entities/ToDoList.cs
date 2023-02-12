namespace Domain.Entities
{
    using System.Collections.Generic;

    public class ToDoList
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public IList<ToDoItem> Items { get; set; } = new List<ToDoItem>();
    }
}