namespace Domain.Entities
{
    using System;

    public class ToDoItem
    {
        public int Id { get; set; }

        public string Note { get; set; }

        public DateTime CreationTime { get; set; }

        public bool Done { get; set; }
    }
}