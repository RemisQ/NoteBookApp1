using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookApp.Repository.Entities
{
    public class Note
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public string Photo { get; set; }
        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Note(string title, string content, string photo)
        {
            Id = Guid.NewGuid();
            Title = title;
            Content = content;
            Photo = photo;
        }
        public Note()
        {

        }
    }
}
