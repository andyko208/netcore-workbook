using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models
{
    public class ToDo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Don't be stupid, write something")]
        public string Title { get; set; }

        [Required]
        [MaxLength(140)]
        [MinLength(1)]
        public string Description { get; set; }

        [UIHint("Status")]
        public Status Status { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? Created { get; set; }
    }
}
