using System.ComponentModel.DataAnnotations;

namespace WebUI.Pages
{
    public class ToDo
    {
        public ToDo()
        {
        }

        public ToDo(int Id, string Note, bool Done = false)
        {
            this.Id = Id;
            this.Note = Note;
            this.Done = Done;
        }

        public int Id { get; set; }

        [Required, MinLength(3)]
        public string Note { get; set; }

        public bool Done { get; set; }
    }
}