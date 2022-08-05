using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookApp.Repository.Entities
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Specification { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public List<Note> Notes { get; set; }
        public Category(string title, string specification)
        {
            Id = Guid.NewGuid();
            Title = title;
            Specification = specification;
            Notes = new List<Note>();
        }
        public Category()
        {

        }
    }
}
